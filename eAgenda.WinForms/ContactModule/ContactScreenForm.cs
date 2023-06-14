using eAgenda.Domain.ContactModule;

namespace eAgenda.WinForms.ContactModule
{
    public partial class ContactScreenForm : Form
    {
        private Contact _contact;

        public ContactScreenForm()
        {
            InitializeComponent();
            this.ConfigDialog();
        }

        public Contact GetContact()
        {
            int id = Convert.ToInt32(txtId.Text);

            string name = txtName.Text;

            string phone = txtPhone.Text;

            string email = txtEmail.Text;

            string company = txtCompany.Text;

            string position = txtPosition.Text;

            Contact contact = new Contact(name, email, phone, company, position);

            if (id > 0)
                contact.id = id;

            return contact;
        }

        public void ConfigScreen(Contact contact)
        {
            txtId.Text = contact.id.ToString();

            txtName.Text = contact.Name;

            txtPhone.Text = contact.phone;

            txtEmail.Text = contact.email;

            txtCompany.Text = contact.company;

            txtPosition.Text = contact.position;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Contact contact = GetContact();

            string[] errors = contact.Errors();

            if (errors.Length > 0)
            {
                MainScreenForm.Instance.UpdateFooter(errors[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
