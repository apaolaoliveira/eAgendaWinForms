namespace eAgenda.WinForms.MainScreen
{
    public enum SerializationOptionEnum
    {
        Json,
        Binary,
        Xml
    }

    public partial class SerializationOptionsForm : Form
    {
        private SerializationOptionEnum _selectedOption;

        public SerializationOptionsForm()
        {
            InitializeComponent();
            this.ConfigDialog();
            rbJson.Checked = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (rbJson.Checked)
                _selectedOption = SerializationOptionEnum.Json;
            else if (rbBin.Checked)
                _selectedOption = SerializationOptionEnum.Binary;
            else if (rbXml.Checked)
                _selectedOption = SerializationOptionEnum.Xml;
        }
    }
}
