namespace SocialExtractor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Label socialNetworkLabel;
        private System.Windows.Forms.ComboBox socialNetworkComboBox;
        private System.Windows.Forms.Label phoneCodeLabel;
        private System.Windows.Forms.ComboBox phoneCodeComboBox;
        private System.Windows.Forms.Label contactMethodLabel;
        private System.Windows.Forms.ComboBox contactMethodComboBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.FlowLayoutPanel resultsPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.keywordLabel = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.socialNetworkLabel = new System.Windows.Forms.Label();
            this.socialNetworkComboBox = new System.Windows.Forms.ComboBox();
            this.phoneCodeLabel = new System.Windows.Forms.Label();
            this.phoneCodeComboBox = new System.Windows.Forms.ComboBox();
            this.contactMethodLabel = new System.Windows.Forms.Label();
            this.contactMethodComboBox = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.resultsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(12, 15);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(90, 13);
            this.keywordLabel.TabIndex = 0;
            this.keywordLabel.Text = "Product/Keyword";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(180, 12);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(300, 20);
            this.keywordTextBox.TabIndex = 1;
            // 
            // socialNetworkLabel
            // 
            this.socialNetworkLabel.AutoSize = true;
            this.socialNetworkLabel.Location = new System.Drawing.Point(12, 55);
            this.socialNetworkLabel.Name = "socialNetworkLabel";
            this.socialNetworkLabel.Size = new System.Drawing.Size(79, 13);
            this.socialNetworkLabel.TabIndex = 2;
            this.socialNetworkLabel.Text = "Social Network";
            // 
            // socialNetworkComboBox
            // 
            this.socialNetworkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.socialNetworkComboBox.FormattingEnabled = true;
            this.socialNetworkComboBox.Items.AddRange(new object[] {
            "Facebook",
            "Twitter",
            "Instagram"});
            this.socialNetworkComboBox.Location = new System.Drawing.Point(180, 52);
            this.socialNetworkComboBox.Name = "socialNetworkComboBox";
            this.socialNetworkComboBox.Size = new System.Drawing.Size(300, 21);
            this.socialNetworkComboBox.TabIndex = 3;
            // 
            // phoneCodeLabel
            // 
            this.phoneCodeLabel.AutoSize = true;
            this.phoneCodeLabel.Location = new System.Drawing.Point(12, 95);
            this.phoneCodeLabel.Name = "phoneCodeLabel";
            this.phoneCodeLabel.Size = new System.Drawing.Size(105, 13);
            this.phoneCodeLabel.TabIndex = 4;
            this.phoneCodeLabel.Text = "Phone Country Code";
            // 
            // phoneCodeComboBox
            // 
            this.phoneCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phoneCodeComboBox.FormattingEnabled = true;
            this.phoneCodeComboBox.Items.AddRange(new object[] {
            "+1",
            "+44",
            "+94"});
            this.phoneCodeComboBox.Location = new System.Drawing.Point(180, 92);
            this.phoneCodeComboBox.Name = "phoneCodeComboBox";
            this.phoneCodeComboBox.Size = new System.Drawing.Size(300, 21);
            this.phoneCodeComboBox.TabIndex = 5;
            // 
            // contactMethodLabel
            // 
            this.contactMethodLabel.AutoSize = true;
            this.contactMethodLabel.Location = new System.Drawing.Point(12, 135);
            this.contactMethodLabel.Name = "contactMethodLabel";
            this.contactMethodLabel.Size = new System.Drawing.Size(83, 13);
            this.contactMethodLabel.TabIndex = 6;
            this.contactMethodLabel.Text = "Contact Method";
            // 
            // contactMethodComboBox
            // 
            this.contactMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactMethodComboBox.FormattingEnabled = true;
            this.contactMethodComboBox.Items.AddRange(new object[] {
            "WhatsApp",
            "Email"});
            this.contactMethodComboBox.Location = new System.Drawing.Point(180, 132);
            this.contactMethodComboBox.Name = "contactMethodComboBox";
            this.contactMethodComboBox.Size = new System.Drawing.Size(300, 21);
            this.contactMethodComboBox.TabIndex = 7;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(180, 172);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(94, 29);
            this.findButton.TabIndex = 8;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(12, 207);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTextBox.Size = new System.Drawing.Size(468, 200);
            this.resultsTextBox.TabIndex = 9;
            this.resultsTextBox.Visible = false;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(380, 413);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(100, 29);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // resultsPanel
            // 
            this.resultsPanel.AutoScroll = true;
            this.resultsPanel.Location = new System.Drawing.Point(12, 207);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(468, 200);
            this.resultsPanel.TabIndex = 11;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(492, 454);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.contactMethodComboBox);
            this.Controls.Add(this.contactMethodLabel);
            this.Controls.Add(this.phoneCodeComboBox);
            this.Controls.Add(this.phoneCodeLabel);
            this.Controls.Add(this.socialNetworkComboBox);
            this.Controls.Add(this.socialNetworkLabel);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.keywordLabel);
            this.Name = "Form1";
            this.Text = "Social Data Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
