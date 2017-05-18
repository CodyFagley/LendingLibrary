namespace LendingLibrary.UI
{
    partial class QueryResultsPopup
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
            this.queryDataViewer = new System.Windows.Forms.DataGridView();
            this.returnEntryButton = new System.Windows.Forms.Button();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // queryDataViewer
            // 
            this.queryDataViewer.AllowUserToAddRows = false;
            this.queryDataViewer.AllowUserToDeleteRows = false;
            this.queryDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataViewer.Dock = System.Windows.Forms.DockStyle.Left;
            this.queryDataViewer.Location = new System.Drawing.Point(0, 0);
            this.queryDataViewer.Name = "queryDataViewer";
            this.queryDataViewer.ReadOnly = true;
            this.queryDataViewer.RowHeadersWidth = 20;
            this.queryDataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queryDataViewer.Size = new System.Drawing.Size(691, 362);
            this.queryDataViewer.TabIndex = 0;
            // 
            // returnEntryButton
            // 
            this.returnEntryButton.Location = new System.Drawing.Point(697, 98);
            this.returnEntryButton.Name = "returnEntryButton";
            this.returnEntryButton.Size = new System.Drawing.Size(75, 23);
            this.returnEntryButton.TabIndex = 1;
            this.returnEntryButton.Text = "Return Entry";
            this.returnEntryButton.UseVisualStyleBackColor = true;
            this.returnEntryButton.Click += new System.EventHandler(this.returnEntryButton_Click);
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Location = new System.Drawing.Point(697, 207);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteEntryButton.TabIndex = 2;
            this.deleteEntryButton.Text = "Delete Entry";
            this.deleteEntryButton.UseVisualStyleBackColor = true;
            // 
            // QueryResultsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.deleteEntryButton);
            this.Controls.Add(this.returnEntryButton);
            this.Controls.Add(this.queryDataViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QueryResultsPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "QueryResultsPopup";
            ((System.ComponentModel.ISupportInitialize)(this.queryDataViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView queryDataViewer;
        private System.Windows.Forms.Button returnEntryButton;
        private System.Windows.Forms.Button deleteEntryButton;
    }
}