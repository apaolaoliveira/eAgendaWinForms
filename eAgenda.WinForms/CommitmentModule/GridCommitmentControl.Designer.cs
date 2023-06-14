namespace eAgenda.WinForms.CommitmentModule
{
    partial class GridCommitmentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridCommitments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCommitments).BeginInit();
            SuspendLayout();
            // 
            // gridCommitments
            // 
            gridCommitments.BackgroundColor = Color.FromArgb(15, 15, 15);
            gridCommitments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCommitments.Dock = DockStyle.Fill;
            gridCommitments.Location = new Point(0, 0);
            gridCommitments.Name = "gridCommitments";
            gridCommitments.RowHeadersWidth = 51;
            gridCommitments.RowTemplate.Height = 29;
            gridCommitments.Size = new Size(740, 416);
            gridCommitments.TabIndex = 0;
            // 
            // GridCommitmentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridCommitments);
            Name = "GridCommitmentControl";
            Size = new Size(740, 416);
            ((System.ComponentModel.ISupportInitialize)gridCommitments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCommitments;
    }
}
