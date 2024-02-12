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
            this.sha256button = new System.Windows.Forms.Button();
            this.sha1Button = new System.Windows.Forms.Button();
            this.md5Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sha256button
            // 
            this.sha256button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sha256button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sha256button.Location = new System.Drawing.Point(394, 82);
            this.sha256button.Name = "sha256button";
            this.sha256button.Size = new System.Drawing.Size(91, 78);
            this.sha256button.TabIndex = 0;
            this.sha256button.Text = "SHA256";
            this.sha256button.UseVisualStyleBackColor = true;
            // 
            // sha1Button
            // 
            this.sha1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sha1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sha1Button.Location = new System.Drawing.Point(394, 166);
            this.sha1Button.Name = "sha1Button";
            this.sha1Button.Size = new System.Drawing.Size(91, 78);
            this.sha1Button.TabIndex = 1;
            this.sha1Button.Text = "SHA1";
            this.sha1Button.UseVisualStyleBackColor = true;
            // 
            // md5Button
            // 
            this.md5Button.AllowDrop = true;
            this.md5Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.md5Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.md5Button.Location = new System.Drawing.Point(394, 250);
            this.md5Button.Name = "md5Button";
            this.md5Button.Size = new System.Drawing.Size(91, 78);
            this.md5Button.TabIndex = 2;
            this.md5Button.Text = "MD5";
            this.md5Button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(43, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 246);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(547, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hash Output";
            // 
            // Hasharp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(875, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.md5Button);
            this.Controls.Add(this.sha1Button);
            this.Controls.Add(this.sha256button);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}

