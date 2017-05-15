namespace LendingLibrary
{
    partial class AddEntryPopup
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameText = new System.Windows.Forms.TextBox();
            this.itemLendeeLabel = new System.Windows.Forms.Label();
            this.itemLendeeText = new System.Windows.Forms.TextBox();
            this.itemDateLabel = new System.Windows.Forms.Label();
            this.itemDatePicker = new System.Windows.Forms.DateTimePicker();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemDescriptionText = new System.Windows.Forms.TextBox();
            this.itemAverageCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(160, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(25, 220);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(100, 23);
            this.addEntryButton.TabIndex = 1;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(15, 17);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.itemNameLabel.TabIndex = 2;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // itemNameText
            // 
            this.itemNameText.Location = new System.Drawing.Point(100, 15);
            this.itemNameText.MaxLength = 50;
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(160, 20);
            this.itemNameText.TabIndex = 3;
            // 
            // itemLendeeLabel
            // 
            this.itemLendeeLabel.AutoSize = true;
            this.itemLendeeLabel.Location = new System.Drawing.Point(15, 52);
            this.itemLendeeLabel.Name = "itemLendeeLabel";
            this.itemLendeeLabel.Size = new System.Drawing.Size(46, 13);
            this.itemLendeeLabel.TabIndex = 4;
            this.itemLendeeLabel.Text = "Lendee:";
            // 
            // itemLendeeText
            // 
            this.itemLendeeText.Location = new System.Drawing.Point(100, 50);
            this.itemLendeeText.MaxLength = 50;
            this.itemLendeeText.Name = "itemLendeeText";
            this.itemLendeeText.Size = new System.Drawing.Size(160, 20);
            this.itemLendeeText.TabIndex = 5;
            // 
            // itemDateLabel
            // 
            this.itemDateLabel.AutoSize = true;
            this.itemDateLabel.Location = new System.Drawing.Point(15, 87);
            this.itemDateLabel.Name = "itemDateLabel";
            this.itemDateLabel.Size = new System.Drawing.Size(72, 13);
            this.itemDateLabel.TabIndex = 6;
            this.itemDateLabel.Text = "Date Loaned:";
            // 
            // itemDatePicker
            // 
            this.itemDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.itemDatePicker.Location = new System.Drawing.Point(100, 85);
            this.itemDatePicker.Name = "itemDatePicker";
            this.itemDatePicker.Size = new System.Drawing.Size(160, 20);
            this.itemDatePicker.TabIndex = 7;
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(15, 122);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(86, 13);
            this.itemDescriptionLabel.TabIndex = 8;
            this.itemDescriptionLabel.Text = "Item Description:";
            // 
            // itemDescriptionText
            // 
            this.itemDescriptionText.Location = new System.Drawing.Point(100, 120);
            this.itemDescriptionText.MaxLength = 255;
            this.itemDescriptionText.Name = "itemDescriptionText";
            this.itemDescriptionText.Size = new System.Drawing.Size(160, 20);
            this.itemDescriptionText.TabIndex = 9;
            // 
            // itemAverageCheckbox
            // 
            this.itemAverageCheckbox.AutoSize = true;
            this.itemAverageCheckbox.Checked = true;
            this.itemAverageCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itemAverageCheckbox.Location = new System.Drawing.Point(100, 155);
            this.itemAverageCheckbox.Name = "itemAverageCheckbox";
            this.itemAverageCheckbox.Size = new System.Drawing.Size(121, 17);
            this.itemAverageCheckbox.TabIndex = 11;
            this.itemAverageCheckbox.Text = "Include in Average?";
            this.itemAverageCheckbox.UseVisualStyleBackColor = true;
            // 
            // AddEntryPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.itemAverageCheckbox);
            this.Controls.Add(this.itemDescriptionText);
            this.Controls.Add(this.itemDescriptionLabel);
            this.Controls.Add(this.itemDatePicker);
            this.Controls.Add(this.itemDateLabel);
            this.Controls.Add(this.itemLendeeText);
            this.Controls.Add(this.itemLendeeLabel);
            this.Controls.Add(this.itemNameText);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddEntryPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemNameText;
        private System.Windows.Forms.Label itemLendeeLabel;
        private System.Windows.Forms.TextBox itemLendeeText;
        private System.Windows.Forms.Label itemDateLabel;
        private System.Windows.Forms.DateTimePicker itemDatePicker;
        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.TextBox itemDescriptionText;
        private System.Windows.Forms.CheckBox itemAverageCheckbox;
    }
}