namespace eAgenda.WinForms.ExpenseModule
{
    partial class GridCategoryControl
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
            gridCategories = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCategories).BeginInit();
            SuspendLayout();
            // 
            // gridCategories
            // 
            gridCategories.BackgroundColor = Color.FromArgb(15, 15, 15);
            gridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategories.Dock = DockStyle.Fill;
            gridCategories.Location = new Point(0, 0);
            gridCategories.Name = "gridCategories";
            gridCategories.RowHeadersWidth = 51;
            gridCategories.RowTemplate.Height = 29;
            gridCategories.Size = new Size(872, 474);
            gridCategories.TabIndex = 0;
            // 
            // GridCategoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridCategories);
            Name = "GridCategoryControl";
            Size = new Size(872, 474);
            ((System.ComponentModel.ISupportInitialize)gridCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCategories;
    }
}
