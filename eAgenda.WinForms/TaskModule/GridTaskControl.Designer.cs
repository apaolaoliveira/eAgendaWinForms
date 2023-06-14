namespace eAgenda.WinForms.TaskModule
{
    partial class GridTaskControl
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
            gridTasks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
            SuspendLayout();
            // 
            // gridTasks
            // 
            gridTasks.BackgroundColor = Color.FromArgb(15, 15, 15);
            gridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTasks.Dock = DockStyle.Fill;
            gridTasks.Location = new Point(0, 0);
            gridTasks.Name = "gridTasks";
            gridTasks.RowHeadersWidth = 51;
            gridTasks.RowTemplate.Height = 29;
            gridTasks.Size = new Size(616, 337);
            gridTasks.TabIndex = 0;
            // 
            // GridTaskControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(gridTasks);
            ForeColor = Color.FromArgb(250, 250, 250);
            Name = "GridTaskControl";
            Size = new Size(616, 337);
            ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridTasks;
    }
}
