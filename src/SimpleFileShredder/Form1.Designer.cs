namespace SimpleFileShredder
{
    partial class frmShredder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShredder));
            this.ofdBrowse = new System.Windows.Forms.OpenFileDialog();
            this.ofdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShredFile = new System.Windows.Forms.Button();
            this.btnOverwrite = new System.Windows.Forms.Button();
            this.cmbOverwite = new System.Windows.Forms.ComboBox();
            this.lblOverwite = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grbFolders = new System.Windows.Forms.GroupBox();
            this.btnShredFolder = new System.Windows.Forms.Button();
            this.btnOverwriteFolder = new System.Windows.Forms.Button();
            this.cmbOverwiteFolder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grbFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShredFile);
            this.groupBox1.Controls.Add(this.btnOverwrite);
            this.groupBox1.Controls.Add(this.cmbOverwite);
            this.groupBox1.Controls.Add(this.lblOverwite);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // btnShredFile
            // 
            this.btnShredFile.Enabled = false;
            this.btnShredFile.Location = new System.Drawing.Point(15, 105);
            this.btnShredFile.Name = "btnShredFile";
            this.btnShredFile.Size = new System.Drawing.Size(156, 23);
            this.btnShredFile.TabIndex = 14;
            this.btnShredFile.Text = "Shred(Overwrite and delete)";
            this.btnShredFile.UseVisualStyleBackColor = true;
            this.btnShredFile.Click += new System.EventHandler(this.btnShredFile_Click);
            // 
            // btnOverwrite
            // 
            this.btnOverwrite.Enabled = false;
            this.btnOverwrite.Location = new System.Drawing.Point(15, 76);
            this.btnOverwrite.Name = "btnOverwrite";
            this.btnOverwrite.Size = new System.Drawing.Size(75, 23);
            this.btnOverwrite.TabIndex = 13;
            this.btnOverwrite.Text = "Overwrite";
            this.btnOverwrite.UseVisualStyleBackColor = true;
            this.btnOverwrite.Click += new System.EventHandler(this.btnOverwrite_Click);
            // 
            // cmbOverwite
            // 
            this.cmbOverwite.FormattingEnabled = true;
            this.cmbOverwite.Items.AddRange(new object[] {
            "Zeros",
            "Random data"});
            this.cmbOverwite.Location = new System.Drawing.Point(95, 46);
            this.cmbOverwite.Name = "cmbOverwite";
            this.cmbOverwite.Size = new System.Drawing.Size(121, 21);
            this.cmbOverwite.TabIndex = 12;
            // 
            // lblOverwite
            // 
            this.lblOverwite.AutoSize = true;
            this.lblOverwite.Location = new System.Drawing.Point(12, 49);
            this.lblOverwite.Name = "lblOverwite";
            this.lblOverwite.Size = new System.Drawing.Size(77, 13);
            this.lblOverwite.TabIndex = 11;
            this.lblOverwite.Text = "Overwrite with:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 16);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(50, 13);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "File path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(298, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(68, 13);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(224, 20);
            this.txtPath.TabIndex = 8;
            // 
            // grbFolders
            // 
            this.grbFolders.Controls.Add(this.btnShredFolder);
            this.grbFolders.Controls.Add(this.btnOverwriteFolder);
            this.grbFolders.Controls.Add(this.cmbOverwiteFolder);
            this.grbFolders.Controls.Add(this.label1);
            this.grbFolders.Controls.Add(this.lblFolder);
            this.grbFolders.Controls.Add(this.btnBrowseFolder);
            this.grbFolders.Controls.Add(this.txtPathFolder);
            this.grbFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbFolders.Location = new System.Drawing.Point(0, 135);
            this.grbFolders.Name = "grbFolders";
            this.grbFolders.Size = new System.Drawing.Size(385, 136);
            this.grbFolders.TabIndex = 9;
            this.grbFolders.TabStop = false;
            this.grbFolders.Text = "Folders";
            // 
            // btnShredFolder
            // 
            this.btnShredFolder.Enabled = false;
            this.btnShredFolder.Location = new System.Drawing.Point(15, 105);
            this.btnShredFolder.Name = "btnShredFolder";
            this.btnShredFolder.Size = new System.Drawing.Size(156, 23);
            this.btnShredFolder.TabIndex = 14;
            this.btnShredFolder.Text = "Shred(Overwrite and delete)";
            this.btnShredFolder.UseVisualStyleBackColor = true;
            this.btnShredFolder.Click += new System.EventHandler(this.btnShredFolder_Click);
            // 
            // btnOverwriteFolder
            // 
            this.btnOverwriteFolder.Enabled = false;
            this.btnOverwriteFolder.Location = new System.Drawing.Point(15, 76);
            this.btnOverwriteFolder.Name = "btnOverwriteFolder";
            this.btnOverwriteFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOverwriteFolder.TabIndex = 13;
            this.btnOverwriteFolder.Text = "Overwrite";
            this.btnOverwriteFolder.UseVisualStyleBackColor = true;
            this.btnOverwriteFolder.Click += new System.EventHandler(this.btnOverwriteFolder_Click);
            // 
            // cmbOverwiteFolder
            // 
            this.cmbOverwiteFolder.FormattingEnabled = true;
            this.cmbOverwiteFolder.Items.AddRange(new object[] {
            "Zeros",
            "Random data"});
            this.cmbOverwiteFolder.Location = new System.Drawing.Point(95, 46);
            this.cmbOverwiteFolder.Name = "cmbOverwiteFolder";
            this.cmbOverwiteFolder.Size = new System.Drawing.Size(121, 21);
            this.cmbOverwiteFolder.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Overwrite with:";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(12, 16);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 10;
            this.lblFolder.Text = "Folder:";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(298, 11);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFolder.TabIndex = 9;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Location = new System.Drawing.Point(68, 13);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.Size = new System.Drawing.Size(224, 20);
            this.txtPathFolder.TabIndex = 8;
            // 
            // frmShredder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 279);
            this.Controls.Add(this.grbFolders);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShredder";
            this.Text = "Simple File Shredder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbFolders.ResumeLayout(false);
            this.grbFolders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdBrowse;
        private System.Windows.Forms.FolderBrowserDialog ofdFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShredFile;
        private System.Windows.Forms.Button btnOverwrite;
        private System.Windows.Forms.ComboBox cmbOverwite;
        private System.Windows.Forms.Label lblOverwite;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox grbFolders;
        private System.Windows.Forms.Button btnShredFolder;
        private System.Windows.Forms.Button btnOverwriteFolder;
        private System.Windows.Forms.ComboBox cmbOverwiteFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtPathFolder;
    }
}

