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
        }
    }
}
