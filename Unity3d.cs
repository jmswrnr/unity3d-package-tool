/*
 Copyright (c) 2013 James Warner
 
 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:
 
 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.
 
 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
*/
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;

using BinaryHelper;
using SevenZip;

namespace Unity3d
{
    public class File
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value.Replace('\\', '/'); }
        }
        public int Offset;
        public int Size;
        public byte[] Buffer;

        public void Extract(string FileName)
        {
            using (FileStream Stream = System.IO.File.Create(FileName))
            {
                Stream.Write(Buffer, 0, Buffer.Length);
            }
        }
    }

    public class FileContainer : List<File>
    {
        public void FillNodes(TreeNodeCollection Nodes)
        {
            foreach (File File in this)
                AddNode(Nodes, File.Name, File);
        }
        private void AddNode(TreeNodeCollection Nodes, string Path, File File)
        {
            string Current = "";
            int Loc = Path.IndexOf('/');

            if ( Loc == -1 )
            {
                Current = Path; Path = "";
            }
            else
            {
                Current = Path.Substring(0, Loc); Loc++;
                Path = Path.Substring(Loc, Path.Length - Loc);
            }
            
            TreeNode Node = null;
            foreach (TreeNode SearchNode in Nodes)
                if (SearchNode.Text == Current) Node = SearchNode;
            if (Node == null)
                Nodes.Add(Node = new TreeNode(Current) { Tag = Path == "" ? File : null });
            if (Path != "")
                AddNode(Node.Nodes, Path, File);
        }
    }

    public class Package
    {
        public class Meta
        {
            public string Magic = "UnityWeb";
            public byte VersionSmall;
            public string VersionGeneric;
            public string Version;
            public int PackageSize;
            public int CompressedDataOffset;
            public uint Unknown1 = 0x00000001;
            public uint Unknown2 = 0x00000001;
            public int CompressedDataSize;
            public int DataSize;
            public int FirstChildSize;
            
            public Meta() { }
            public Meta(BinaryReader Reader)
            {
                // Reads Header with BinaryReader
                Magic = Encoding.ASCII.GetString(Reader.ReadBytes(8));
                Reader.BaseStream.Position += 4;
                VersionSmall = Reader.ReadByte();
                VersionGeneric = Reader.ReadNullTerminatedString();
                Version = Reader.ReadNullTerminatedString();
                PackageSize = Reader.ReadBInt32();
                CompressedDataOffset = Reader.ReadBInt32();
                Unknown1 = Reader.ReadBUInt32();
                Unknown2 = Reader.ReadBUInt32();
                CompressedDataSize = Reader.ReadBInt32();
                DataSize = Reader.ReadBInt32();
                Reader.BaseStream.Position += 4;
                FirstChildSize = Reader.ReadBInt32();
            }
        }
        
        public string FileName;
        public Meta Header = new Meta();
        public FileContainer Files = new FileContainer();

        public Package(string FileName = null)
        {
            if (FileName != null) Read(FileName);
        }

        public void Read(string FileName)
        {
            FileStream Stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            BinaryReader Reader = new BinaryReader(Stream);
            this.FileName = Path.GetFileName(FileName);
            Header = new Meta(Reader);
            DecompressRead(Reader);
            Reader.Close();
            Stream.Close();
        }

        private void DecompressRead(BinaryReader Reader)
        {
            if (Header == null) throw new Exception("File Not Read");

            SevenZip.Compression.LZMA.Decoder Decoder = new SevenZip.Compression.LZMA.Decoder();
            MemoryStream Output = new MemoryStream();
            Reader.BaseStream.Position = Header.CompressedDataOffset;
            byte[] Properties = Reader.ReadBytes(5);
            long FileLength = Reader.ReadInt64();
            Decoder.SetDecoderProperties(Properties);
            Decoder.Code(Reader.BaseStream, Output, Header.CompressedDataSize, Header.DataSize, null);
            Output.Flush();
            ReadFiles(Output);
        }

        private void ReadFiles(Stream Stream)
        {
            BinaryReader Reader = new BinaryReader(Stream);
            Files = new FileContainer();
            Stream.Position = 0;
            int FileCount = Reader.ReadBInt32();
            for (int i = 0; i < FileCount; i++)
            {
                File File = new File();
                File.Name = Reader.ReadNullTerminatedString();
                File.Offset = Reader.ReadBInt32();
                File.Size = Reader.ReadBInt32();
                Files.Add(File);
            }
            foreach (File File in Files)
            {
                Stream.Position = File.Offset;
                File.Buffer = Reader.ReadBytes(File.Size);
            }
            Reader.Close();
            Stream.Close();
        }

        public static Package Load(string Path)
        {
            string[] Files = Directory.GetFiles(Path, "*.*", System.IO.SearchOption.AllDirectories);
            Package Package = new Package() { FileName = System.IO.Path.GetFileName(Path) + ".unity3d" };
            foreach (string FilePath in Files)
            {
                File File = new File();
                File.Name = FilePath.Replace(Path + '\\', "");
                FileStream Stream = System.IO.File.OpenRead(FilePath);
                File.Buffer = new byte[Stream.Length];
                Stream.Read(File.Buffer, 0, (int)Stream.Length);
                File.Size = (int)Stream.Length;
                Package.Files.Add(File);
            }
            return Package;
        }

        public void Build(string FileName)
        {
            int HeaderSize = 4;
            int FileSize = 0;
            int FileOffset = 0;
            int FileCount = Files.Count;

            foreach (File File in Files)
            {
                HeaderSize += File.Name.Length + 9;
                FileSize += File.Size;
            }

            HeaderSize = (int) Math.Ceiling(HeaderSize / 4.0) * 4;
            
            foreach (File File in Files)
            {
                File.Offset = HeaderSize + FileOffset;
                FileOffset += File.Size;
            }

            byte[] Data = new byte[HeaderSize + FileSize];
            
            MemoryStream DataStream = new MemoryStream(Data);
            BinaryWriter DataWriter = new BinaryWriter(DataStream);

            DataWriter.BWrite((Int32)FileCount);
            
            foreach (File File in Files)
            {
                DataWriter.Write(Encoding.ASCII.GetBytes(File.Name));
                DataWriter.Write((byte)0x00);
                DataWriter.BWrite((Int32)File.Offset);
                DataWriter.BWrite((Int32)File.Size);
            }

            DataStream.Position = HeaderSize;
            
            foreach (File File in Files)
            {
                DataWriter.Write(File.Buffer);
            }

            DataStream.Position = 0;

            SevenZip.Compression.LZMA.Encoder Encoder = new SevenZip.Compression.LZMA.Encoder();
            Encoder.SetCoderProperties(new CoderPropID[] {
                CoderPropID.DictionarySize
            },
            new object[] {
                0x00080000
            });

            MemoryStream CompressionStream = new MemoryStream();
            Encoder.WriteCoderProperties(CompressionStream);
            CompressionStream.Write(BitConverter.GetBytes(DataStream.Length), 0, 8);
            Encoder.Code(DataStream, CompressionStream, DataStream.Length, -1, null);
            CompressionStream.Flush();
            CompressionStream.Close();

            byte[] CompressedBuffer = CompressionStream.ToArray();

            Header.CompressedDataOffset =
                Header.Magic.Length +
                Header.VersionGeneric.Length +
                Header.Version.Length + 0x28;

            Header.CompressedDataSize = CompressedBuffer.Length;
            Header.PackageSize = Header.CompressedDataSize + Header.CompressedDataOffset;

            using (FileStream FileStream = System.IO.File.Create(FileName))
            {
                using (BinaryWriter FileWriter = new BinaryWriter(FileStream))
                {
                    FileWriter.Write(Encoding.ASCII.GetBytes(Header.Magic));
                    FileWriter.Write((Int32)0);
                    FileWriter.Write((byte)Header.VersionSmall);
                    FileWriter.Write(Encoding.ASCII.GetBytes(Header.VersionGeneric));
                    FileWriter.Write((byte)0x00);
                    FileWriter.Write(Encoding.ASCII.GetBytes(Header.Version));
                    FileWriter.Write((byte)0x00);
                    FileWriter.BWrite((Int32)Header.PackageSize);
                    FileWriter.BWrite((Int32)Header.CompressedDataOffset);
                    FileWriter.BWrite((Int32)Header.Unknown1);
                    FileWriter.BWrite((Int32)Header.Unknown2);
                    FileWriter.BWrite((Int32)Header.CompressedDataSize);
                    FileWriter.BWrite((Int32)FileSize);
                    FileWriter.BWrite((Int32)Header.PackageSize);
                    FileWriter.BWrite((Int32)Files[0].Size);
                    FileWriter.Write((byte)0x00);
                    FileWriter.Write(CompressedBuffer);
                }
            }

            DataWriter.Close();
            DataStream.Flush();
            DataStream.Close();
        }
    }
}
