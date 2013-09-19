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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Unity3dPackageTool
{
    public partial class frmMain : Form
    {
        TreeNode LastNode;

        Unity3d.Package SelectedExtract;
        Unity3d.Package CurrentPackage;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open package to be extracted
        /// </summary>
        private void buttonExtractOpenPackage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Unity3d Web Packages (*.unity3d)|*.unity3d|All files (*.*)|*.*" ;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                SelectedExtract = new Unity3d.Package(OFD.FileName);
                SelectedExtract.Files.FillNodes(treeViewExtract.Nodes);
                buttonExtractPackage.Enabled = true;
            }
        }

        /// <summary>
        /// Right click extract treeView
        /// </summary>
        private void treeViewExtract_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            Point Point = new Point(e.X, e.Y);
            TreeNode TreeNode = treeViewExtract.GetNodeAt(Point);

            // Didn't click on a node || directory with no children
            if (TreeNode == null || TreeNode.Tag == null && TreeNode.Nodes.Count == 0) return;

            LastNode = TreeNode;
            treeViewExtract.SelectedNode = TreeNode;
            ExtractMenu.Show(treeViewExtract, Point);
        }
        
        /// <summary>
        /// Extract all files
        /// </summary>
        private void buttonExtractPackage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string ContainingPath = FBD.SelectedPath;
                if (checkBoxExtractMakeFolder.Checked)
                    ContainingPath += '\\' + SelectedExtract.FileName + '_' + TimeStamp();
                
                if (!Directory.Exists(ContainingPath)) Directory.CreateDirectory(ContainingPath);

                foreach (TreeNode Node in treeViewExtract.Nodes)
                {
                    if (Node.Tag == null)
                    {
                        // Directory Extract
                        ExtractDirectory(Node, ContainingPath);
                    }
                    else
                    {
                        // Single File Extract
                        Unity3d.File File = (Unity3d.File)Node.Tag;
                        File.Extract(ContainingPath + '\\' + Path.GetFileName(File.Name));
                    }
                }
            }
        }

        /// <summary>
        /// Extract single node from treeview
        /// </summary>
        private void ExtractMenuExtract_Click(object sender, EventArgs e)
        {
            if (LastNode.Tag == null)
            {
                // Directory Extract
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                if (FBD.ShowDialog() == DialogResult.OK)
                    ExtractDirectory(LastNode, FBD.SelectedPath);
            }
            else
            {
                // Single File Extract
                SaveFileDialog SFD = new SaveFileDialog();
                Unity3d.File File = (Unity3d.File)LastNode.Tag;
                SFD.FileName = File.Name;
                if (SFD.ShowDialog() == DialogResult.OK)
                    File.Extract(SFD.FileName);
            }
        }

        /// <summary>
        /// Extract directory of files from TreeNode
        /// </summary>
        private void ExtractDirectory(TreeNode Node, string ContainingPath)
        {
            ContainingPath += '\\' + Node.Text;
            if (!Directory.Exists(ContainingPath)) Directory.CreateDirectory(ContainingPath);
            foreach (TreeNode Child in Node.Nodes)
            {
                if (Child.Tag == null)
                {
                    // Another Directory
                    ExtractDirectory(Child, ContainingPath);
                }
                else
                {
                    // File
                    Unity3d.File File = (Unity3d.File)Child.Tag;
                    File.Extract(ContainingPath + '\\' + Path.GetFileName(File.Name));
                }
            }
        }

        /// <summary>
        /// Set form defaults for package settings
        /// </summary>
        private void buttonPackageDefaults_Click(object sender, EventArgs e)
        {
            numericPackageCoreVersion.Value = 3;
            textBoxPackageMaskedVersion.Text = "3.x.x";
            textBoxPackageFullVersion.Text = "4.1.5f1";
        }

        /// <summary>
        /// Select directory ready for packaging
        /// </summary>
        private void buttonPackageSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                CurrentPackage = Unity3d.Package.Load(FBD.SelectedPath);
                CurrentPackage.Files.FillNodes(treeViewPackage.Nodes);
                buttonPackageCreate.Enabled = true;
            }
        }

        /// <summary>
        /// Build and save a package
        /// </summary>
        private void buttonPackageCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.FileName = CurrentPackage.FileName;
            if(SFD.ShowDialog() == DialogResult.OK)
            {
                CurrentPackage.Header.VersionSmall = (byte) numericPackageCoreVersion.Value;
                CurrentPackage.Header.VersionGeneric = textBoxPackageMaskedVersion.Text;
                CurrentPackage.Header.Version = textBoxPackageFullVersion.Text;
                CurrentPackage.Build(SFD.FileName);
            }
        }

        /// <summary>
        /// Get current timestamp for filename
        /// </summary>
        /// <returns></returns>
        private string TimeStamp()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

    }
}
