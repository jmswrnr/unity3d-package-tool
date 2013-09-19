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

namespace BinaryHelper
{
    public static class Extensions
    {
        public static string ReadNullTerminatedString(this BinaryReader Reader)
        {
            string str = ""; int num = 0;
            while (true)
            {
                char ch = (char) Reader.ReadByte();  num++;
                if (ch == '\0')
                    break;
                str = str + ch;
            }
            int num2 = str.Length - num;
            Reader.BaseStream.Seek((long) (num2 + 1), SeekOrigin.Current);
            return str;
        }

        // Big Endian Reader

        public static int ReadBInt32(this BinaryReader Reader)
        {
            byte[] array = Reader.ReadBytes(4);
                Array.Reverse(array);
            return BitConverter.ToInt32(array, 0);
        }
        public static long ReadBInt64(this BinaryReader Reader)
        {
            byte[] array = Reader.ReadBytes(8);
                Array.Reverse(array);
            return BitConverter.ToInt64(array, 0);
        }
        public static uint ReadBUInt32(this BinaryReader Reader)
        {
            byte[] array = Reader.ReadBytes(4);
                Array.Reverse(array);
            return BitConverter.ToUInt32(array, 0);
        }
        public static ulong ReadBUInt64(this BinaryReader Reader)
        {
            byte[] array = Reader.ReadBytes(8);
                Array.Reverse(array);
            return BitConverter.ToUInt64(array, 0);
        }

        // Big Endian Writer
        
        public static void BWrite(this BinaryWriter Writer, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
                Array.Reverse(bytes);
            Writer.Write(bytes);
        }
        public static void BWrite(this BinaryWriter Writer, uint value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
                Array.Reverse(bytes);
            Writer.Write(bytes);
        }
    }
}
