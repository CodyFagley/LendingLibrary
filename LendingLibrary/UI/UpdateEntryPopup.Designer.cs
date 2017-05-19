namespace LendingLibrary.UI
{
    partial class UpdateEntryPopup
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
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameText = new System.Windows.Forms.TextBox();
            this.itemLendeeLabel = new System.Windows.Forms.Label();
            this.itemLendeeText = new System.Windows.Forms.TextBox();
            this.dateLendLabel = new System.Windows.Forms.Label();
            this.dateLendPicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnLabel = new System.Windows.Forms.Label();
            this.dateReturnPicker = new System.Windows.Forms.DateTimePicker();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemDescriptionText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(15, 17);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // itemNameText
            // 
            this.itemNameText.Location = new System.Drawing.Point(100, 15);
            this.itemNameText.Name = "itemNameText";
            this.itemNameText.Size = new System.Drawing.Size(160, 20);
            this.itemNameText.TabIndex = 1;
            // 
            // itemLendeeLabel
            // 
            this.itemLendeeLabel.AutoSize = true;
            this.itemLendeeLabel.Location = new System.Drawing.Point(15, 52);
            this.itemLendeeLabel.Name = "itemLendeeLabel";
            this.itemLendeeLabel.Size = new System.Drawing.Size(69, 13);
            this.itemLendeeLabel.TabIndex = 2;
            this.itemLendeeLabel.Text = "Item Lendee:";
            // 
            // itemLendeeText
            // 
            this.itemLendeeText.Location = new System.Drawing.Point(100, 50);
            this.itemLendeeText.Name = "itemLendeeText";
            this.itemLendeeText.Size = new System.Drawing.Size(160, 20);
            this.itemLendeeText.TabIndex = 3;
            // 
            // dateLendLabel
            // 
            this.dateLendLabel.AutoSize = true;
            this.dateLendLabel.Location = new System.Drawing.Point(15, 87);
            this.dateLendLabel.Name = "dateLendLabel";
            this.dateLendLabel.Size = new System.Drawing.Size(72, 13);
            this.dateLendLabel.TabIndex = 4;
            this.dateLendLabel.Text = "Date Lended:";
            // 
            // dateLendPicker
            // 
            this.dateLendPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLendPicker.Location = new System.Drawing.Point(100, 85);
            this.dateLendPicker.Name = "dateLendPicker";
            this.dateLendPicker.Size = new System.Drawing.Size(160, 20);
            this.dateLendPicker.TabIndex = 5;
            // 
            // dateReturnLabel
            // 
            this.dateReturnLabel.AutoSize = true;
            this.dateReturnLabel.Location = new System.Drawing.Point(15, 122);
            this.dateReturnLabel.Name = "dateReturnLabel";
            this.dateReturnLabel.Size = new System.Drawing.Size(80, 13);
            this.dateReturnLabel.TabIndex = 6;
            this.dateReturnLabel.Text = "Date Returned:";
            // 
            // dateReturnPicker
            // 
            this.dateReturnPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReturnPicker.Location = new System.Drawing.Point(100, 120);
            this.dateReturnPicker.Name = "dateReturnPicker";
            this.dateReturnPicker.Size = new System.Drawing.Size(160, 20);
            this.dateReturnPicker.TabIndex = 7;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(25, 220);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(105, 23);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update Entry";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(160, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(15, 157);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(86, 13);
            this.itemDescriptionLabel.TabIndex = 10;
            this.itemDescriptionLabel.Text = "Item Description:";
            // 
            // itemDescriptionText
            // 
            this.itemDescriptionText.Location = new System.Drawing.Point(100, 155);
            this.itemDescriptionText.Name = "itemDescriptionText";
            this.itemDescriptionText.Size = new System.Drawing.Size(160, 20);
            this.itemDescriptionText.TabIndex = 11;
            // 
            // updateEntryPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.itemDescriptionText);
            this.Controls.Add(this.itemDescriptionLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dateReturnPicker);
            this.Controls.Add(this.dateReturnLabel);
            this.Controls.Add(this.dateLendPicker);
            this.Controls.Add(this.dateLendLabel);
            this.Controls.Add(this.itemLendeeText);
            this.Controls.Add(this.itemLendeeLabel);
            this.Controls.Add(this.itemNameText);
            this.Controls.Add(this.itemNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "updateEntryPopup";
            this.Text = "Update Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemNameText;
        private System.Windows.Forms.Label itemLendeeLabel;
        private System.Windows.Forms.TextBox itemLendeeText;
        private System.Windows.Forms.Label dateLendLabel;
        private System.Windows.Forms.DateTimePicker dateLendPicker;
        private System.Windows.Forms.Label dateReturnLabel;
        private System.Windows.Forms.DateTimePicker dateReturnPicker;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.TextBox itemDescriptionText;
    }
}