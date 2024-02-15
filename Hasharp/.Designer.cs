namespace Hasharp
{
    partial class Hasharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasharp));
            this.sha256button = new System.Windows.Forms.Button();
            this.sha1Button = new System.Windows.Forms.Button();
            this.md5Button = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.hashText = new System.Windows.Forms.TextBox();
            this.hashInputLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sha256button
            // 
            this.sha256button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sha256button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sha256button.Location = new System.Drawing.Point(122, 202);
            this.sha256button.Name = "sha256button";
            this.sha256button.Size = new System.Drawing.Size(91, 78);
            this.sha256button.TabIndex = 0;
            this.sha256button.Text = "SHA256";
            this.sha256button.UseVisualStyleBackColor = true;
            this.sha256button.Click += new System.EventHandler(this.sha256_click);
            // 
            // sha1Button
            // 
            this.sha1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sha1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sha1Button.Location = new System.Drawing.Point(219, 202);
            this.sha1Button.Name = "sha1Button";
            this.sha1Button.Size = new System.Drawing.Size(91, 78);
            this.sha1Button.TabIndex = 1;
            this.sha1Button.Text = "SHA1";
            this.sha1Button.UseVisualStyleBackColor = true;
            this.sha1Button.Click += new System.EventHandler(this.sha1_click);
            // 
            // md5Button
            // 
            this.md5Button.AllowDrop = true;
            this.md5Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.md5Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.md5Button.Location = new System.Drawing.Point(316, 202);
            this.md5Button.Name = "md5Button";
            this.md5Button.Size = new System.Drawing.Size(91, 78);
            this.md5Button.TabIndex = 2;
            this.md5Button.Text = "MD5";
            this.md5Button.UseVisualStyleBackColor = true;
            this.md5Button.Click += new System.EventHandler(this.md5_click);
            // 
            // pathLabel
            // 
            this.pathLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(122, 117);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(103, 20);
            this.pathLabel.TabIndex = 4;
            this.pathLabel.Text = "Wordlist Path";
            // 
            // hashText
            // 
            this.hashText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hashText.Location = new System.Drawing.Point(409, 143);
            this.hashText.Name = "hashText";
            this.hashText.Size = new System.Drawing.Size(281, 26);
            this.hashText.TabIndex = 5;
            // 
            // hashInputLabel
            // 
            this.hashInputLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hashInputLabel.AutoSize = true;
            this.hashInputLabel.Location = new System.Drawing.Point(405, 120);
            this.hashInputLabel.Name = "hashInputLabel";
            this.hashInputLabel.Size = new System.Drawing.Size(88, 20);
            this.hashInputLabel.TabIndex = 6;
            this.hashInputLabel.Text = "Hash Input";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logTextBox.Location = new System.Drawing.Point(122, 317);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(668, 99);
            this.logTextBox.TabIndex = 7;
            // 
            // logLabel
            // 
            this.logLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(122, 294);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(36, 20);
            this.logLabel.TabIndex = 8;
            this.logLabel.Text = "Log";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(126, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // Hasharp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(875, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.hashInputLabel);
            this.Controls.Add(this.hashText);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.md5Button);
            this.Controls.Add(this.sha1Button);
            this.Controls.Add(this.sha256button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(897, 514);
            this.Name = "Hasharp";
            this.Text = "Hasharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sha256button;
        private System.Windows.Forms.Button sha1Button;
        private System.Windows.Forms.Button md5Button;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox hashText;
        private System.Windows.Forms.Label hashInputLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button button1;
    }
}

