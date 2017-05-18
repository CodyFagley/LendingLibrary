namespace LendingLibrary
{
    partial class ProgMenu
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
            this.addEntryButton = new System.Windows.Forms.Button();
            this.queryLendeeButton = new System.Windows.Forms.Button();
            this.queryEntriesButton = new System.Windows.Forms.Button();
            this.lendeeQueryText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(20, 20);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(120, 23);
            this.addEntryButton.TabIndex = 0;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // queryLendeeButton
            // 
            this.queryLendeeButton.Location = new System.Drawing.Point(159, 106);
            this.queryLendeeButton.Name = "queryLendeeButton";
            this.queryLendeeButton.Size = new System.Drawing.Size(120, 23);
            this.queryLendeeButton.TabIndex = 1;
            this.queryLendeeButton.Text = "Query Lendee";
            this.queryLendeeButton.UseVisualStyleBackColor = true;
            this.queryLendeeButton.Click += new System.EventHandler(this.queryLendeeButton_Click);
            // 
            // queryEntriesButton
            // 
            this.queryEntriesButton.Location = new System.Drawing.Point(20, 106);
            this.queryEntriesButton.Name = "queryEntriesButton";
            this.queryEntriesButton.Size = new System.Drawing.Size(120, 23);
            this.queryEntriesButton.TabIndex = 2;
            this.queryEntriesButton.Text = "Query Entries";
            this.queryEntriesButton.UseVisualStyleBackColor = true;
            this.queryEntriesButton.Click += new System.EventHandler(this.queryEntriesButton_Click);
            // 
            // lendeeQueryText
            // 
            this.lendeeQueryText.Location = new System.Drawing.Point(159, 63);
            this.lendeeQueryText.Name = "lendeeQueryText";
            this.lendeeQueryText.Size = new System.Drawing.Size(120, 20);
            this.lendeeQueryText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Get Entries from Lendee";
            // 
            // ProgMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lendeeQueryText);
            this.Controls.Add(this.queryEntriesButton);
            this.Controls.Add(this.queryLendeeButton);
            this.Controls.Add(this.addEntryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProgMenu";
            this.Text = "Lending Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Button queryLendeeButton;
        private System.Windows.Forms.Button queryEntriesButton;
        private System.Windows.Forms.TextBox lendeeQueryText;
        private System.Windows.Forms.Label label1;
    }
}