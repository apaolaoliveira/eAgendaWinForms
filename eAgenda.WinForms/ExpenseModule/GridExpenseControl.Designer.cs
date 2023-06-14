namespace eAgenda.WinForms.ExpenseModule
{
    partial class GridExpenseControl
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
            gridExpenses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridExpenses).BeginInit();
            SuspendLayout();
            // 
            // gridExpenses
            // 
            gridExpenses.BackgroundColor = Color.FromArgb(15, 15, 15);
            gridExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridExpenses.Dock = DockStyle.Fill;
            gridExpenses.Location = new Point(0, 0);
            gridExpenses.Name = "gridExpenses";
            gridExpenses.RowHeadersWidth = 51;
            gridExpenses.RowTemplate.Height = 29;
            gridExpenses.Size = new Size(796, 488);
            gridExpenses.TabIndex = 0;
            // 
            // GridExpenseControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(gridExpenses);
            Name = "GridExpenseControl";
            Size = new Size(796, 488);
            ((System.ComponentModel.ISupportInitialize)gridExpenses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridExpenses;
    }
}
