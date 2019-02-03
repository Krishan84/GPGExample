namespace GPGExample
{
    partial class Homepage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FileToEncryptSelect = new System.Windows.Forms.Button();
            this.SelectPath = new System.Windows.Forms.Button();
            this.SelectPublicKey = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.inputfilepath = new System.Windows.Forms.TextBox();
            this.publickeypath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectFileToDecrypt = new System.Windows.Forms.Button();
            this.InputFilePathValue = new System.Windows.Forms.TextBox();
            this.privatekeypath = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.KeySelectionButton = new System.Windows.Forms.Button();
            this.outputfilepathValue = new System.Windows.Forms.TextBox();
            this.OutputfilePathselection = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OutputFilePath);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.publickeypath);
            this.tabPage1.Controls.Add(this.inputfilepath);
            this.tabPage1.Controls.Add(this.Encrypt);
            this.tabPage1.Controls.Add(this.SelectPublicKey);
            this.tabPage1.Controls.Add(this.SelectPath);
            this.tabPage1.Controls.Add(this.FileToEncryptSelect);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Decrypt);
            this.tabPage2.Controls.Add(this.OutputfilePathselection);
            this.tabPage2.Controls.Add(this.outputfilepathValue);
            this.tabPage2.Controls.Add(this.KeySelectionButton);
            this.tabPage2.Controls.Add(this.password);
            this.tabPage2.Controls.Add(this.privatekeypath);
            this.tabPage2.Controls.Add(this.InputFilePathValue);
            this.tabPage2.Controls.Add(this.SelectFileToDecrypt);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Public Key";
            // 
            // FileToEncryptSelect
            // 
            this.FileToEncryptSelect.Location = new System.Drawing.Point(415, 40);
            this.FileToEncryptSelect.Name = "FileToEncryptSelect";
            this.FileToEncryptSelect.Size = new System.Drawing.Size(117, 23);
            this.FileToEncryptSelect.TabIndex = 4;
            this.FileToEncryptSelect.Text = "Select File";
            this.FileToEncryptSelect.UseVisualStyleBackColor = true;
            this.FileToEncryptSelect.Click += new System.EventHandler(this.FileToEncryptSelect_Click);
            // 
            // SelectPath
            // 
            this.SelectPath.Location = new System.Drawing.Point(415, 162);
            this.SelectPath.Name = "SelectPath";
            this.SelectPath.Size = new System.Drawing.Size(117, 23);
            this.SelectPath.TabIndex = 5;
            this.SelectPath.Text = "Output File Path";
            this.SelectPath.UseVisualStyleBackColor = true;
            this.SelectPath.Click += new System.EventHandler(this.SelectPath_Click);
            // 
            // SelectPublicKey
            // 
            this.SelectPublicKey.Location = new System.Drawing.Point(415, 94);
            this.SelectPublicKey.Name = "SelectPublicKey";
            this.SelectPublicKey.Size = new System.Drawing.Size(117, 23);
            this.SelectPublicKey.TabIndex = 6;
            this.SelectPublicKey.Text = "Select Key";
            this.SelectPublicKey.UseVisualStyleBackColor = true;
            this.SelectPublicKey.Click += new System.EventHandler(this.SelectPublicKey_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(230, 280);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(128, 43);
            this.Encrypt.TabIndex = 7;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // inputfilepath
            // 
            this.inputfilepath.Location = new System.Drawing.Point(139, 40);
            this.inputfilepath.Name = "inputfilepath";
            this.inputfilepath.Size = new System.Drawing.Size(253, 20);
            this.inputfilepath.TabIndex = 8;
            // 
            // publickeypath
            // 
            this.publickeypath.Location = new System.Drawing.Point(139, 94);
            this.publickeypath.Name = "publickeypath";
            this.publickeypath.Size = new System.Drawing.Size(253, 20);
            this.publickeypath.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output";
            // 
            // OutputFilePath
            // 
            this.OutputFilePath.Location = new System.Drawing.Point(139, 162);
            this.OutputFilePath.Name = "OutputFilePath";
            this.OutputFilePath.Size = new System.Drawing.Size(253, 20);
            this.OutputFilePath.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Private Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Output";
            // 
            // SelectFileToDecrypt
            // 
            this.SelectFileToDecrypt.Location = new System.Drawing.Point(449, 44);
            this.SelectFileToDecrypt.Name = "SelectFileToDecrypt";
            this.SelectFileToDecrypt.Size = new System.Drawing.Size(75, 23);
            this.SelectFileToDecrypt.TabIndex = 4;
            this.SelectFileToDecrypt.Text = "Select File";
            this.SelectFileToDecrypt.UseVisualStyleBackColor = true;
            this.SelectFileToDecrypt.Click += new System.EventHandler(this.SelectFileToDecrypt_Click);
            // 
            // InputFilePathValue
            // 
            this.InputFilePathValue.Location = new System.Drawing.Point(139, 46);
            this.InputFilePathValue.Name = "InputFilePathValue";
            this.InputFilePathValue.Size = new System.Drawing.Size(260, 20);
            this.InputFilePathValue.TabIndex = 5;
            // 
            // privatekeypath
            // 
            this.privatekeypath.Location = new System.Drawing.Point(139, 159);
            this.privatekeypath.Name = "privatekeypath";
            this.privatekeypath.Size = new System.Drawing.Size(260, 20);
            this.privatekeypath.TabIndex = 6;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(139, 106);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(260, 20);
            this.password.TabIndex = 7;
            // 
            // KeySelectionButton
            // 
            this.KeySelectionButton.Location = new System.Drawing.Point(449, 159);
            this.KeySelectionButton.Name = "KeySelectionButton";
            this.KeySelectionButton.Size = new System.Drawing.Size(75, 23);
            this.KeySelectionButton.TabIndex = 8;
            this.KeySelectionButton.Text = "Select Key";
            this.KeySelectionButton.UseVisualStyleBackColor = true;
            this.KeySelectionButton.Click += new System.EventHandler(this.KeySelectionButton_Click);
            // 
            // outputfilepathValue
            // 
            this.outputfilepathValue.Location = new System.Drawing.Point(139, 221);
            this.outputfilepathValue.Name = "outputfilepathValue";
            this.outputfilepathValue.Size = new System.Drawing.Size(260, 20);
            this.outputfilepathValue.TabIndex = 9;
            // 
            // OutputfilePathselection
            // 
            this.OutputfilePathselection.Location = new System.Drawing.Point(437, 221);
            this.OutputfilePathselection.Name = "OutputfilePathselection";
            this.OutputfilePathselection.Size = new System.Drawing.Size(98, 23);
            this.OutputfilePathselection.TabIndex = 10;
            this.OutputfilePathselection.Text = "Output File path";
            this.OutputfilePathselection.UseVisualStyleBackColor = true;
            this.OutputfilePathselection.Click += new System.EventHandler(this.OutputfilePathselection_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(235, 308);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(113, 35);
            this.Decrypt.TabIndex = 11;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 430);
            this.Controls.Add(this.tabControl1);
            this.Name = "Homepage";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox OutputFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox publickeypath;
        private System.Windows.Forms.TextBox inputfilepath;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button SelectPublicKey;
        private System.Windows.Forms.Button SelectPath;
        private System.Windows.Forms.Button FileToEncryptSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button OutputfilePathselection;
        private System.Windows.Forms.TextBox outputfilepathValue;
        private System.Windows.Forms.Button KeySelectionButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox privatekeypath;
        private System.Windows.Forms.TextBox InputFilePathValue;
        private System.Windows.Forms.Button SelectFileToDecrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

