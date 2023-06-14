namespace eAgenda.WinForms.Shared
{
    public static class GridExtensions
    {
        public static void ConfigGridColor(this DataGridView grid)
        {
            Font font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle lines = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(250, 250, 250),
                Font = font,
                ForeColor = Color.FromArgb(15, 15, 15),
                SelectionBackColor = Color.FromArgb(45, 45, 45),
                SelectionForeColor = Color.FromArgb(250, 250, 250)
            };

            grid.RowsDefaultCellStyle = lines;
        }

        public static void ConfigGridReadOnly(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.MultiSelect = false;
            grid.ReadOnly = true;            

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;
        }
    }
}
