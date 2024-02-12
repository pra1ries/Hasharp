namespace Hasharp
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // sha256button
            // 
            this.sha256button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sha256button.Location = new System.Drawing.Point(394, 121);
            this.sha256button.Name = "sha256button";
            this.sha256button.Size = new System.Drawing.Size(135, 78);
            this.sha256button.TabIndex = 0;
            this.sha256button.Text = "SHA256";
            this.sha256button.UseVisualStyleBackColor = true;
            // 
            // sha1Button
            // 
            this.sha1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sha1Button.Location = new System.Drawing.Point(394, 205);
            this.sha1Button.Name = "sha1Button";
            this.sha1Button.Size = new System.Drawing.Size(135, 78);
            this.sha1Button.TabIndex = 1;
            this.sha1Button.Text = "SHA1";
            this.sha1Button.UseVisualStyleBackColor = true;
            // 
            // md5Button
            // 
            this.md5Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.md5Button.Location = new System.Drawing.Point(394, 289);
            this.md5Button.Name = "md5Button";
            this.md5Button.Size = new System.Drawing.Size(135, 78);
            this.md5Button.TabIndex = 2;
            this.md5Button.Text = "MD5";
            this.md5Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 536);
            this.Controls.Add(this.md5Button);
            this.Controls.Add(this.sha1Button);
            this.Controls.Add(this.sha256button);
            this.Name = "Form1";
            this.Text = "Hasharp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sha256button;
        private System.Windows.Forms.Button sha1Button;
        private System.Windows.Forms.Button md5Button;
    }
}

