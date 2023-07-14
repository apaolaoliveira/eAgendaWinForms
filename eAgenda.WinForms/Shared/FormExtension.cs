namespace eAgenda.WinForms.Shared
{
    public static class FormExtension
    {
        public static void ConfigDialog(this Form form)
        {
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            foreach (Control control in form.Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += (sender, e) =>
                    {
                        button.BackColor = Color.FromArgb(45, 45, 45);
                        button.ForeColor = Color.Snow;
                    };

                    button.MouseLeave += (sender, e) =>
                    {
                        button.BackColor = Color.Snow;
                        button.ForeColor = Color.Black;
                    };
                }
            }
        }
    }
}
