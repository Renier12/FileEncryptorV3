namespace FileEncryptorV3
{
    partial class FormFileEncryptor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileEncryptor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxEncryptionKey = new System.Windows.Forms.TextBox();
            this.labelEncryptionKey = new System.Windows.Forms.Label();
            this.comboBoxFileName = new System.Windows.Forms.ComboBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.groupBoxRequirements = new System.Windows.Forms.GroupBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.buttonHidePassword = new System.Windows.Forms.Button();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.buttonCreateNewFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.progressBarBatch = new System.Windows.Forms.ProgressBar();
            this.progressBarWorking = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.groupBoxRequirements.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.batchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem});
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.batchToolStripMenuItem.Text = "Batch";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.encryptToolStripMenuItem.Text = "Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.decryptToolStripMenuItem.Text = "Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // textBoxEncryptionKey
            // 
            this.textBoxEncryptionKey.Location = new System.Drawing.Point(90, 13);
            this.textBoxEncryptionKey.Name = "textBoxEncryptionKey";
            this.textBoxEncryptionKey.PasswordChar = 'X';
            this.textBoxEncryptionKey.Size = new System.Drawing.Size(247, 20);
            this.textBoxEncryptionKey.TabIndex = 1;
            // 
            // labelEncryptionKey
            // 
            this.labelEncryptionKey.AutoSize = true;
            this.labelEncryptionKey.Location = new System.Drawing.Point(6, 16);
            this.labelEncryptionKey.Name = "labelEncryptionKey";
            this.labelEncryptionKey.Size = new System.Drawing.Size(78, 13);
            this.labelEncryptionKey.TabIndex = 2;
            this.labelEncryptionKey.Text = "Encryption Key";
            // 
            // comboBoxFileName
            // 
            this.comboBoxFileName.FormattingEnabled = true;
            this.comboBoxFileName.Location = new System.Drawing.Point(90, 43);
            this.comboBoxFileName.Name = "comboBoxFileName";
            this.comboBoxFileName.Size = new System.Drawing.Size(275, 21);
            this.comboBoxFileName.TabIndex = 3;
            this.comboBoxFileName.DropDown += new System.EventHandler(this.comboBoxFileName_DropDown);
            this.comboBoxFileName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileName_SelectedIndexChanged);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(6, 46);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(54, 13);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.Text = "File Name";
            // 
            // groupBoxRequirements
            // 
            this.groupBoxRequirements.Controls.Add(this.buttonShowPassword);
            this.groupBoxRequirements.Controls.Add(this.buttonHidePassword);
            this.groupBoxRequirements.Controls.Add(this.labelEncryptionKey);
            this.groupBoxRequirements.Controls.Add(this.labelFileName);
            this.groupBoxRequirements.Controls.Add(this.textBoxEncryptionKey);
            this.groupBoxRequirements.Controls.Add(this.comboBoxFileName);
            this.groupBoxRequirements.Location = new System.Drawing.Point(12, 27);
            this.groupBoxRequirements.Name = "groupBoxRequirements";
            this.groupBoxRequirements.Size = new System.Drawing.Size(375, 76);
            this.groupBoxRequirements.TabIndex = 5;
            this.groupBoxRequirements.TabStop = false;
            this.groupBoxRequirements.Text = "Requirements";
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Location = new System.Drawing.Point(343, 13);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(22, 22);
            this.buttonShowPassword.TabIndex = 6;
            this.buttonShowPassword.Text = "O";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // buttonHidePassword
            // 
            this.buttonHidePassword.Enabled = false;
            this.buttonHidePassword.Location = new System.Drawing.Point(343, 13);
            this.buttonHidePassword.Name = "buttonHidePassword";
            this.buttonHidePassword.Size = new System.Drawing.Size(22, 22);
            this.buttonHidePassword.TabIndex = 5;
            this.buttonHidePassword.Text = "X";
            this.buttonHidePassword.UseVisualStyleBackColor = true;
            this.buttonHidePassword.Visible = false;
            this.buttonHidePassword.Click += new System.EventHandler(this.buttonHidePassword_Click);
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.buttonCreateNewFile);
            this.groupBoxOperations.Controls.Add(this.buttonOpenFile);
            this.groupBoxOperations.Controls.Add(this.buttonDecrypt);
            this.groupBoxOperations.Controls.Add(this.buttonEncrypt);
            this.groupBoxOperations.Location = new System.Drawing.Point(12, 109);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(375, 120);
            this.groupBoxOperations.TabIndex = 6;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
            // 
            // buttonCreateNewFile
            // 
            this.buttonCreateNewFile.Location = new System.Drawing.Point(6, 19);
            this.buttonCreateNewFile.Name = "buttonCreateNewFile";
            this.buttonCreateNewFile.Size = new System.Drawing.Size(175, 39);
            this.buttonCreateNewFile.TabIndex = 8;
            this.buttonCreateNewFile.Text = "Create New File";
            this.buttonCreateNewFile.UseVisualStyleBackColor = true;
            this.buttonCreateNewFile.Click += new System.EventHandler(this.buttonCreateFile);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(187, 19);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(175, 39);
            this.buttonOpenFile.TabIndex = 7;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonPeakOpenFile);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(187, 64);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(175, 49);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(6, 64);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(175, 49);
            this.buttonEncrypt.TabIndex = 7;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // progressBarBatch
            // 
            this.progressBarBatch.Location = new System.Drawing.Point(11, 235);
            this.progressBarBatch.Name = "progressBarBatch";
            this.progressBarBatch.Size = new System.Drawing.Size(376, 23);
            this.progressBarBatch.TabIndex = 8;
            // 
            // progressBarWorking
            // 
            this.progressBarWorking.Location = new System.Drawing.Point(11, 264);
            this.progressBarWorking.MarqueeAnimationSpeed = 500;
            this.progressBarWorking.Name = "progressBarWorking";
            this.progressBarWorking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarWorking.Size = new System.Drawing.Size(376, 23);
            this.progressBarWorking.TabIndex = 9;
            this.progressBarWorking.Visible = false;
            // 
            // FormFileEncryptor
            // 
            this.AcceptButton = this.buttonOpenFile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 295);
            this.Controls.Add(this.progressBarWorking);
            this.Controls.Add(this.progressBarBatch);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.groupBoxRequirements);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 334);
            this.MinimumSize = new System.Drawing.Size(412, 334);
            this.Name = "FormFileEncryptor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Encryptor";
            this.Load += new System.EventHandler(this.FormFileEncryptor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxRequirements.ResumeLayout(false);
            this.groupBoxRequirements.PerformLayout();
            this.groupBoxOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxEncryptionKey;
        private System.Windows.Forms.Label labelEncryptionKey;
        private System.Windows.Forms.ComboBox comboBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.GroupBox groupBoxRequirements;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Button buttonHidePassword;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.Button buttonCreateNewFile;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarBatch;
        private System.Windows.Forms.ProgressBar progressBarWorking;
    }
}

