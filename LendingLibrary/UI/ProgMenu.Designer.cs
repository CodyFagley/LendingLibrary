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
            this.queryPersonButton = new System.Windows.Forms.Button();
            this.queryEntriesButton = new System.Windows.Forms.Button();
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
            // queryPersonButton
            // 
            this.queryPersonButton.Location = new System.Drawing.Point(20, 63);
            this.queryPersonButton.Name = "queryPersonButton";
            this.queryPersonButton.Size = new System.Drawing.Size(120, 23);
            this.queryPersonButton.TabIndex = 1;
            this.queryPersonButton.Text = "Query Lendee";
            this.queryPersonButton.UseVisualStyleBackColor = true;
            // 
            // queryEntriesButton
            // 
            this.queryEntriesButton.Location = new System.Drawing.Point(20, 106);
            this.queryEntriesButton.Name = "queryEntriesButton";
            this.queryEntriesButton.Size = new System.Drawing.Size(120, 23);
            this.queryEntriesButton.TabIndex = 2;
            this.queryEntriesButton.Text = "Query Entries";
            this.queryEntriesButton.UseVisualStyleBackColor = true;
            // 
            // ProgMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 172);
            this.Controls.Add(this.queryEntriesButton);
            this.Controls.Add(this.queryPersonButton);
            this.Controls.Add(this.addEntryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProgMenu";
            this.Text = "Lending Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Button queryPersonButton;
        private System.Windows.Forms.Button queryEntriesButton;
    }
}