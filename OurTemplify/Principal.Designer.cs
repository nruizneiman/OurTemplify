namespace OurTemplify
{
    partial class Principal
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
            this.btnTemplify = new System.Windows.Forms.Button();
            this.txtTargetKey = new System.Windows.Forms.TextBox();
            this.txtSourceKey = new System.Windows.Forms.TextBox();
            this.lblSourceKey = new System.Windows.Forms.Label();
            this.lblTargetKey = new System.Windows.Forms.Label();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.lblTargetDirectory = new System.Windows.Forms.Label();
            this.fbdSourceDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.gbxDirectory = new System.Windows.Forms.GroupBox();
            this.btnTargetDirectory = new System.Windows.Forms.Button();
            this.btnSourceDirectory = new System.Windows.Forms.Button();
            this.gbxKey = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFileExclusions = new System.Windows.Forms.TextBox();
            this.txtFolderExclusions = new System.Windows.Forms.TextBox();
            this.lblFileExclusions = new System.Windows.Forms.Label();
            this.lblFolderExclusions = new System.Windows.Forms.Label();
            this.txtGlobalExtensionExclusions = new System.Windows.Forms.TextBox();
            this.lblGlobalExtensionExclusions = new System.Windows.Forms.Label();
            this.txtTokenExtensionExclusions = new System.Windows.Forms.TextBox();
            this.lblTokenExtensionExclusions = new System.Windows.Forms.Label();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.gbxDirectory.SuspendLayout();
            this.gbxKey.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemplify
            // 
            this.btnTemplify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemplify.FlatAppearance.BorderSize = 2;
            this.btnTemplify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplify.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemplify.Location = new System.Drawing.Point(297, 481);
            this.btnTemplify.Name = "btnTemplify";
            this.btnTemplify.Size = new System.Drawing.Size(155, 39);
            this.btnTemplify.TabIndex = 7;
            this.btnTemplify.Text = "Templify!";
            this.btnTemplify.UseVisualStyleBackColor = true;
            this.btnTemplify.Click += new System.EventHandler(this.BtnTemplify_Click);
            // 
            // txtTargetKey
            // 
            this.txtTargetKey.Location = new System.Drawing.Point(133, 50);
            this.txtTargetKey.Name = "txtTargetKey";
            this.txtTargetKey.Size = new System.Drawing.Size(329, 22);
            this.txtTargetKey.TabIndex = 6;
            // 
            // txtSourceKey
            // 
            this.txtSourceKey.Location = new System.Drawing.Point(133, 24);
            this.txtSourceKey.Name = "txtSourceKey";
            this.txtSourceKey.Size = new System.Drawing.Size(329, 22);
            this.txtSourceKey.TabIndex = 5;
            // 
            // lblSourceKey
            // 
            this.lblSourceKey.AutoSize = true;
            this.lblSourceKey.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceKey.Location = new System.Drawing.Point(21, 27);
            this.lblSourceKey.Name = "lblSourceKey";
            this.lblSourceKey.Size = new System.Drawing.Size(64, 13);
            this.lblSourceKey.TabIndex = 3;
            this.lblSourceKey.Text = "Source key";
            // 
            // lblTargetKey
            // 
            this.lblTargetKey.AutoSize = true;
            this.lblTargetKey.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetKey.Location = new System.Drawing.Point(24, 53);
            this.lblTargetKey.Name = "lblTargetKey";
            this.lblTargetKey.Size = new System.Drawing.Size(62, 13);
            this.lblTargetKey.TabIndex = 4;
            this.lblTargetKey.Text = "Target key";
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceDirectory.Location = new System.Drawing.Point(10, 26);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(93, 13);
            this.lblSourceDirectory.TabIndex = 5;
            this.lblSourceDirectory.Text = "Source Directory";
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetDirectory.Location = new System.Drawing.Point(13, 52);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.Size = new System.Drawing.Size(91, 13);
            this.lblTargetDirectory.TabIndex = 6;
            this.lblTargetDirectory.Text = "Target Directory";
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(133, 23);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(298, 20);
            this.txtSourceDirectory.TabIndex = 1;
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(133, 49);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(298, 20);
            this.txtTargetDirectory.TabIndex = 3;
            // 
            // gbxDirectory
            // 
            this.gbxDirectory.Controls.Add(this.btnTargetDirectory);
            this.gbxDirectory.Controls.Add(this.btnSourceDirectory);
            this.gbxDirectory.Controls.Add(this.txtTargetDirectory);
            this.gbxDirectory.Controls.Add(this.lblSourceDirectory);
            this.gbxDirectory.Controls.Add(this.txtSourceDirectory);
            this.gbxDirectory.Controls.Add(this.lblTargetDirectory);
            this.gbxDirectory.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDirectory.Location = new System.Drawing.Point(63, 83);
            this.gbxDirectory.Name = "gbxDirectory";
            this.gbxDirectory.Size = new System.Drawing.Size(479, 100);
            this.gbxDirectory.TabIndex = 10;
            this.gbxDirectory.TabStop = false;
            this.gbxDirectory.Text = "Directory";
            // 
            // btnTargetDirectory
            // 
            this.btnTargetDirectory.Location = new System.Drawing.Point(437, 49);
            this.btnTargetDirectory.Name = "btnTargetDirectory";
            this.btnTargetDirectory.Size = new System.Drawing.Size(25, 20);
            this.btnTargetDirectory.TabIndex = 4;
            this.btnTargetDirectory.Text = "...";
            this.btnTargetDirectory.UseVisualStyleBackColor = true;
            this.btnTargetDirectory.Click += new System.EventHandler(this.BtnTargetDirectory_Click);
            // 
            // btnSourceDirectory
            // 
            this.btnSourceDirectory.Location = new System.Drawing.Point(437, 23);
            this.btnSourceDirectory.Name = "btnSourceDirectory";
            this.btnSourceDirectory.Size = new System.Drawing.Size(25, 20);
            this.btnSourceDirectory.TabIndex = 2;
            this.btnSourceDirectory.Text = "...";
            this.btnSourceDirectory.UseVisualStyleBackColor = true;
            this.btnSourceDirectory.Click += new System.EventHandler(this.BtnSourceDirectory_Click);
            // 
            // gbxKey
            // 
            this.gbxKey.Controls.Add(this.txtTargetKey);
            this.gbxKey.Controls.Add(this.txtSourceKey);
            this.gbxKey.Controls.Add(this.lblTargetKey);
            this.gbxKey.Controls.Add(this.lblSourceKey);
            this.gbxKey.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKey.Location = new System.Drawing.Point(63, 189);
            this.gbxKey.Name = "gbxKey";
            this.gbxKey.Size = new System.Drawing.Size(479, 100);
            this.gbxKey.TabIndex = 11;
            this.gbxKey.TabStop = false;
            this.gbxKey.Text = "Key";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(235, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 32);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "OurTemplify";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(136, 481);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 39);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFile});
            this.statusStrip.Location = new System.Drawing.Point(0, 536);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(608, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblFile
            // 
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(32, 17);
            this.lblFile.Text = "Listo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeparator);
            this.groupBox1.Controls.Add(this.lblSeparator);
            this.groupBox1.Controls.Add(this.txtTokenExtensionExclusions);
            this.groupBox1.Controls.Add(this.lblTokenExtensionExclusions);
            this.groupBox1.Controls.Add(this.txtGlobalExtensionExclusions);
            this.groupBox1.Controls.Add(this.lblGlobalExtensionExclusions);
            this.groupBox1.Controls.Add(this.txtFileExclusions);
            this.groupBox1.Controls.Add(this.txtFolderExclusions);
            this.groupBox1.Controls.Add(this.lblFileExclusions);
            this.groupBox1.Controls.Add(this.lblFolderExclusions);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 170);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exclusions";
            // 
            // txtFileExclusions
            // 
            this.txtFileExclusions.Location = new System.Drawing.Point(133, 50);
            this.txtFileExclusions.Name = "txtFileExclusions";
            this.txtFileExclusions.Size = new System.Drawing.Size(329, 22);
            this.txtFileExclusions.TabIndex = 6;
            this.txtFileExclusions.Text = "desktop.ini;thumbs.db";
            // 
            // txtFolderExclusions
            // 
            this.txtFolderExclusions.Location = new System.Drawing.Point(133, 24);
            this.txtFolderExclusions.Name = "txtFolderExclusions";
            this.txtFolderExclusions.Size = new System.Drawing.Size(329, 22);
            this.txtFolderExclusions.TabIndex = 5;
            this.txtFolderExclusions.Text = "bin;obj;debug;release;.git;.svn";
            // 
            // lblFileExclusions
            // 
            this.lblFileExclusions.AutoSize = true;
            this.lblFileExclusions.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileExclusions.Location = new System.Drawing.Point(24, 53);
            this.lblFileExclusions.Name = "lblFileExclusions";
            this.lblFileExclusions.Size = new System.Drawing.Size(30, 13);
            this.lblFileExclusions.TabIndex = 4;
            this.lblFileExclusions.Text = "Files";
            // 
            // lblFolderExclusions
            // 
            this.lblFolderExclusions.AutoSize = true;
            this.lblFolderExclusions.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolderExclusions.Location = new System.Drawing.Point(21, 27);
            this.lblFolderExclusions.Name = "lblFolderExclusions";
            this.lblFolderExclusions.Size = new System.Drawing.Size(62, 13);
            this.lblFolderExclusions.TabIndex = 3;
            this.lblFolderExclusions.Text = "Directories";
            // 
            // txtGlobalExtensionExclusions
            // 
            this.txtGlobalExtensionExclusions.Location = new System.Drawing.Point(133, 78);
            this.txtGlobalExtensionExclusions.Name = "txtGlobalExtensionExclusions";
            this.txtGlobalExtensionExclusions.Size = new System.Drawing.Size(329, 22);
            this.txtGlobalExtensionExclusions.TabIndex = 8;
            this.txtGlobalExtensionExclusions.Text = ".cache;.mst;.msm;.gitignore;.idx;.pack;.user;.resharper;.suo;.vsscc";
            // 
            // lblGlobalExtensionExclusions
            // 
            this.lblGlobalExtensionExclusions.AutoSize = true;
            this.lblGlobalExtensionExclusions.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlobalExtensionExclusions.Location = new System.Drawing.Point(24, 81);
            this.lblGlobalExtensionExclusions.Name = "lblGlobalExtensionExclusions";
            this.lblGlobalExtensionExclusions.Size = new System.Drawing.Size(99, 13);
            this.lblGlobalExtensionExclusions.TabIndex = 7;
            this.lblGlobalExtensionExclusions.Text = "Global Exclusions";
            // 
            // txtTokenExtensionExclusions
            // 
            this.txtTokenExtensionExclusions.Location = new System.Drawing.Point(133, 106);
            this.txtTokenExtensionExclusions.Name = "txtTokenExtensionExclusions";
            this.txtTokenExtensionExclusions.Size = new System.Drawing.Size(329, 22);
            this.txtTokenExtensionExclusions.TabIndex = 10;
            this.txtTokenExtensionExclusions.Text = ".cab;.dll;.doc;.docx;.exe;.gif;.ico;.jpg;.nupkg;.pdf;.png;.snk;.xls;.xlsx;.zip;.r" +
    "ar;.eot;.ttf;.woff;.woff2;.svg";
            // 
            // lblTokenExtensionExclusions
            // 
            this.lblTokenExtensionExclusions.AutoSize = true;
            this.lblTokenExtensionExclusions.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenExtensionExclusions.Location = new System.Drawing.Point(24, 109);
            this.lblTokenExtensionExclusions.Name = "lblTokenExtensionExclusions";
            this.lblTokenExtensionExclusions.Size = new System.Drawing.Size(97, 13);
            this.lblTokenExtensionExclusions.TabIndex = 9;
            this.lblTokenExtensionExclusions.Text = "Token Exclusions";
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(133, 134);
            this.txtSeparator.MaxLength = 1;
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(329, 22);
            this.txtSeparator.TabIndex = 12;
            this.txtSeparator.Text = ";";
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparator.Location = new System.Drawing.Point(24, 137);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(57, 13);
            this.lblSeparator.TabIndex = 11;
            this.lblSeparator.Text = "Separator";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbxKey);
            this.Controls.Add(this.gbxDirectory);
            this.Controls.Add(this.btnTemplify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Templify";
            this.gbxDirectory.ResumeLayout(false);
            this.gbxDirectory.PerformLayout();
            this.gbxKey.ResumeLayout(false);
            this.gbxKey.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemplify;
        private System.Windows.Forms.TextBox txtTargetKey;
        private System.Windows.Forms.TextBox txtSourceKey;
        private System.Windows.Forms.Label lblSourceKey;
        private System.Windows.Forms.Label lblTargetKey;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.Label lblTargetDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbdSourceDirectory;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.GroupBox gbxDirectory;
        private System.Windows.Forms.Button btnTargetDirectory;
        private System.Windows.Forms.Button btnSourceDirectory;
        private System.Windows.Forms.GroupBox gbxKey;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel lblFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGlobalExtensionExclusions;
        private System.Windows.Forms.Label lblGlobalExtensionExclusions;
        private System.Windows.Forms.TextBox txtFileExclusions;
        private System.Windows.Forms.TextBox txtFolderExclusions;
        private System.Windows.Forms.Label lblFileExclusions;
        private System.Windows.Forms.Label lblFolderExclusions;
        private System.Windows.Forms.TextBox txtTokenExtensionExclusions;
        private System.Windows.Forms.Label lblTokenExtensionExclusions;
        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.Label lblSeparator;
    }
}