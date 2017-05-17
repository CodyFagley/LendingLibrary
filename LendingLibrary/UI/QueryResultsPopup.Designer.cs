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
            ((System.ComponentModel.ISupportInitialize)(this.queryDataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // queryDataViewer
            // 
            this.queryDataViewer.AllowUserToAddRows = false;
            this.queryDataViewer.AllowUserToDeleteRows = false;
            this.queryDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDataViewer.Location = new System.Drawing.Point(0, 0);
            this.queryDataViewer.Name = "queryDataViewer";
            this.queryDataViewer.ReadOnly = true;
            this.queryDataViewer.Size = new System.Drawing.Size(784, 362);
            this.queryDataViewer.TabIndex = 0;
            // 
            // QueryResultsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
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
    }
}