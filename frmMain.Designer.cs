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
namespace Unity3dPackageTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCredits = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageExtract = new System.Windows.Forms.TabPage();
            this.treeViewExtract = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxExtractMakeFolder = new System.Windows.Forms.CheckBox();
            this.buttonExtractPackage = new System.Windows.Forms.Button();
            this.buttonExtractOpenPackage = new System.Windows.Forms.Button();
            this.tabPagePackage = new System.Windows.Forms.TabPage();
            this.treeViewPackage = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxPackageFullVersion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPackageMaskedVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericPackageCoreVersion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPackageDefaults = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPackageCreate = new System.Windows.Forms.Button();
            this.buttonPackageSelectDirectory = new System.Windows.Forms.Button();
            this.ExtractMenu = new System.Windows.Forms.ContextMenu();
            this.ExtractMenuExtract = new System.Windows.Forms.MenuItem();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageExtract.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPagePackage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPackageCoreVersion)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCredits});
            this.statusStrip.Location = new System.Drawing.Point(4, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(376, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            // 
            // toolStripStatusLabelCredits
            // 
            this.toolStripStatusLabelCredits.ActiveLinkColor = System.Drawing.Color.Gray;
            this.toolStripStatusLabelCredits.IsLink = true;
            this.toolStripStatusLabelCredits.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabelCredits.Name = "toolStripStatusLabelCredits";
            this.toolStripStatusLabelCredits.Size = new System.Drawing.Size(361, 17);
            this.toolStripStatusLabelCredits.Spring = true;
            this.toolStripStatusLabelCredits.Text = "by James Warner - jmswrnr.com";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageExtract);
            this.tabControl.Controls.Add(this.tabPagePackage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(376, 431);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 2;
            // 
            // tabPageExtract
            // 
            this.tabPageExtract.Controls.Add(this.treeViewExtract);
            this.tabPageExtract.Controls.Add(this.panel1);
            this.tabPageExtract.Location = new System.Drawing.Point(4, 22);
            this.tabPageExtract.Name = "tabPageExtract";
            this.tabPageExtract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExtract.Size = new System.Drawing.Size(368, 405);
            this.tabPageExtract.TabIndex = 0;
            this.tabPageExtract.Text = "Extract";
            this.tabPageExtract.UseVisualStyleBackColor = true;
            // 
            // treeViewExtract
            // 
            this.treeViewExtract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewExtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewExtract.Location = new System.Drawing.Point(3, 46);
            this.treeViewExtract.Name = "treeViewExtract";
            this.treeViewExtract.Size = new System.Drawing.Size(362, 356);
            this.treeViewExtract.TabIndex = 1;
            this.treeViewExtract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewExtract_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxExtractMakeFolder);
            this.panel1.Controls.Add(this.buttonExtractPackage);
            this.panel1.Controls.Add(this.buttonExtractOpenPackage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(362, 43);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxExtractMakeFolder
            // 
            this.checkBoxExtractMakeFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxExtractMakeFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxExtractMakeFolder.Location = new System.Drawing.Point(128, 11);
            this.checkBoxExtractMakeFolder.Name = "checkBoxExtractMakeFolder";
            this.checkBoxExtractMakeFolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxExtractMakeFolder.Size = new System.Drawing.Size(106, 22);
            this.checkBoxExtractMakeFolder.TabIndex = 2;
            this.checkBoxExtractMakeFolder.Text = "Make Folder";
            this.checkBoxExtractMakeFolder.UseVisualStyleBackColor = true;
            // 
            // buttonExtractPackage
            // 
            this.buttonExtractPackage.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExtractPackage.Enabled = false;
            this.buttonExtractPackage.Location = new System.Drawing.Point(234, 10);
            this.buttonExtractPackage.Name = "buttonExtractPackage";
            this.buttonExtractPackage.Size = new System.Drawing.Size(128, 23);
            this.buttonExtractPackage.TabIndex = 1;
            this.buttonExtractPackage.Text = "Extract All";
            this.buttonExtractPackage.UseVisualStyleBackColor = true;
            this.buttonExtractPackage.Click += new System.EventHandler(this.buttonExtractPackage_Click);
            // 
            // buttonExtractOpenPackage
            // 
            this.buttonExtractOpenPackage.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonExtractOpenPackage.Location = new System.Drawing.Point(0, 10);
            this.buttonExtractOpenPackage.Name = "buttonExtractOpenPackage";
            this.buttonExtractOpenPackage.Size = new System.Drawing.Size(128, 23);
            this.buttonExtractOpenPackage.TabIndex = 0;
            this.buttonExtractOpenPackage.Text = "Open Package";
            this.buttonExtractOpenPackage.UseVisualStyleBackColor = true;
            this.buttonExtractOpenPackage.Click += new System.EventHandler(this.buttonExtractOpenPackage_Click);
            // 
            // tabPagePackage
            // 
            this.tabPagePackage.Controls.Add(this.treeViewPackage);
            this.tabPagePackage.Controls.Add(this.panel3);
            this.tabPagePackage.Controls.Add(this.panel2);
            this.tabPagePackage.Location = new System.Drawing.Point(4, 22);
            this.tabPagePackage.Name = "tabPagePackage";
            this.tabPagePackage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePackage.Size = new System.Drawing.Size(368, 405);
            this.tabPagePackage.TabIndex = 1;
            this.tabPagePackage.Text = "Package";
            this.tabPagePackage.UseVisualStyleBackColor = true;
            // 
            // treeViewPackage
            // 
            this.treeViewPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPackage.Location = new System.Drawing.Point(3, 46);
            this.treeViewPackage.Name = "treeViewPackage";
            this.treeViewPackage.Size = new System.Drawing.Size(362, 232);
            this.treeViewPackage.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 278);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(362, 124);
            this.panel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.buttonPackageDefaults);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(362, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Settings";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBoxPackageFullVersion);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 73);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.panel5.Size = new System.Drawing.Size(267, 25);
            this.panel5.TabIndex = 14;
            // 
            // textBoxPackageFullVersion
            // 
            this.textBoxPackageFullVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPackageFullVersion.Location = new System.Drawing.Point(90, 5);
            this.textBoxPackageFullVersion.Name = "textBoxPackageFullVersion";
            this.textBoxPackageFullVersion.Size = new System.Drawing.Size(167, 20);
            this.textBoxPackageFullVersion.TabIndex = 10;
            this.textBoxPackageFullVersion.Text = "4.1.5f1";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Full Version";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxPackageMaskedVersion);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 48);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.panel4.Size = new System.Drawing.Size(267, 25);
            this.panel4.TabIndex = 13;
            // 
            // textBoxPackageMaskedVersion
            // 
            this.textBoxPackageMaskedVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPackageMaskedVersion.Location = new System.Drawing.Point(90, 5);
            this.textBoxPackageMaskedVersion.Name = "textBoxPackageMaskedVersion";
            this.textBoxPackageMaskedVersion.Size = new System.Drawing.Size(167, 20);
            this.textBoxPackageMaskedVersion.TabIndex = 8;
            this.textBoxPackageMaskedVersion.Text = "3.x.x";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Masked Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.numericPackageCoreVersion);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 23);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.panel6.Size = new System.Drawing.Size(267, 25);
            this.panel6.TabIndex = 12;
            // 
            // numericPackageCoreVersion
            // 
            this.numericPackageCoreVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericPackageCoreVersion.Location = new System.Drawing.Point(90, 5);
            this.numericPackageCoreVersion.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericPackageCoreVersion.Name = "numericPackageCoreVersion";
            this.numericPackageCoreVersion.Size = new System.Drawing.Size(167, 20);
            this.numericPackageCoreVersion.TabIndex = 6;
            this.numericPackageCoreVersion.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Core Version";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonPackageDefaults
            // 
            this.buttonPackageDefaults.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPackageDefaults.Location = new System.Drawing.Point(277, 23);
            this.buttonPackageDefaults.Name = "buttonPackageDefaults";
            this.buttonPackageDefaults.Size = new System.Drawing.Size(75, 81);
            this.buttonPackageDefaults.TabIndex = 5;
            this.buttonPackageDefaults.Text = "Defaults";
            this.buttonPackageDefaults.UseVisualStyleBackColor = true;
            this.buttonPackageDefaults.Click += new System.EventHandler(this.buttonPackageDefaults_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPackageCreate);
            this.panel2.Controls.Add(this.buttonPackageSelectDirectory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(362, 43);
            this.panel2.TabIndex = 2;
            // 
            // buttonPackageCreate
            // 
            this.buttonPackageCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPackageCreate.Enabled = false;
            this.buttonPackageCreate.Location = new System.Drawing.Point(234, 10);
            this.buttonPackageCreate.Name = "buttonPackageCreate";
            this.buttonPackageCreate.Size = new System.Drawing.Size(128, 23);
            this.buttonPackageCreate.TabIndex = 1;
            this.buttonPackageCreate.Text = "Create Package";
            this.buttonPackageCreate.UseVisualStyleBackColor = true;
            this.buttonPackageCreate.Click += new System.EventHandler(this.buttonPackageCreate_Click);
            // 
            // buttonPackageSelectDirectory
            // 
            this.buttonPackageSelectDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPackageSelectDirectory.Location = new System.Drawing.Point(0, 10);
            this.buttonPackageSelectDirectory.Name = "buttonPackageSelectDirectory";
            this.buttonPackageSelectDirectory.Size = new System.Drawing.Size(128, 23);
            this.buttonPackageSelectDirectory.TabIndex = 0;
            this.buttonPackageSelectDirectory.Text = "Select Directory";
            this.buttonPackageSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonPackageSelectDirectory.Click += new System.EventHandler(this.buttonPackageSelectDirectory_Click);
            // 
            // ExtractMenu
            // 
            this.ExtractMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ExtractMenuExtract});
            // 
            // ExtractMenuExtract
            // 
            this.ExtractMenuExtract.Index = 0;
            this.ExtractMenuExtract.Text = "Extract";
            this.ExtractMenuExtract.Click += new System.EventHandler(this.ExtractMenuExtract_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unity3d Package Tool";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageExtract.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPagePackage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPackageCoreVersion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageExtract;
        private System.Windows.Forms.TabPage tabPagePackage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCredits;
        private System.Windows.Forms.TreeView treeViewExtract;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExtractOpenPackage;
        private System.Windows.Forms.Button buttonExtractPackage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPackageCreate;
        private System.Windows.Forms.Button buttonPackageSelectDirectory;
        private System.Windows.Forms.ContextMenu ExtractMenu;
        private System.Windows.Forms.MenuItem ExtractMenuExtract;
        private System.Windows.Forms.TreeView treeViewPackage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxPackageFullVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxPackageMaskedVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numericPackageCoreVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPackageDefaults;
        private System.Windows.Forms.CheckBox checkBoxExtractMakeFolder;

    }
}

