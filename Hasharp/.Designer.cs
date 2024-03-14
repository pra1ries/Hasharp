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
            this.pathLabel = new System.Windows.Forms.Label();
            this.hashText = new System.Windows.Forms.TextBox();
            this.hashInputLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.algSelectionBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // algSelectionBox
            // 
            this.algSelectionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.algSelectionBox.FormattingEnabled = true;
            this.algSelectionBox.Items.AddRange(new object[] {
            "MD5",
            "SHA256",
            "SHA1"});
            this.algSelectionBox.Location = new System.Drawing.Point(126, 211);
            this.algSelectionBox.Name = "algSelectionBox";
            this.algSelectionBox.Size = new System.Drawing.Size(208, 28);
            this.algSelectionBox.TabIndex = 10;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(507, 204);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(153, 40);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "Start Cracking!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Hasharp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(875, 558);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.algSelectionBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.hashInputLabel);
            this.Controls.Add(this.hashText);
            this.Controls.Add(this.pathLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(897, 514);
            this.Name = "Hasharp";
            this.Text = "Hasharp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox hashText;
        private System.Windows.Forms.Label hashInputLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox algSelectionBox;
        private System.Windows.Forms.Button startButton;
    }
}

