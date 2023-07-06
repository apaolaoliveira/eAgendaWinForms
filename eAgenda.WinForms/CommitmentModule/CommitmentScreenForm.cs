using eAgenda.Domain.CommitmentModule;
using eAgenda.Domain.ContactModule;

namespace eAgenda.WinForms.CommitmentModule
{
    public partial class CategoryScreenForm : Form
    {
        public CategoryScreenForm(List<Contact> contacts)
        {
            InitializeComponent();
            this.ConfigDialog();

            ConfigContacts(contacts);

            rdbInPerson.Checked = true;
            txtDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void ConfigContacts(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                cmbContacts.Items.Add(contact);
            }
        }

        public Commitment GetCommitment()
        {
            int id = Convert.ToInt32(txtId.Text);
            string subject = txtSubject.Text;

            DateTime date = txtDate.Value;

            TimeSpan startTime = txtStartTime.Value.TimeOfDay;
            TimeSpan endTime = txtEndTime.Value.TimeOfDay;

            CommitmentLocationTypeEnum type = rdbOnline.Checked ? CommitmentLocationTypeEnum.Online : CommitmentLocationTypeEnum.InPerson;
            string local = rdbOnline.Checked ? txtOnline.Text : txtInPerson.Text;

            Contact contact = (Contact)cmbContacts.SelectedItem;

            Commitment commitment = new Commitment(id, contact, subject, date, startTime, endTime, type, local);

            if (id > 0)
                commitment.id = id;

            return commitment;
        }

        public void ConfigScreen(Commitment commitmentSelected)
        {
            txtId.Text = commitmentSelected.id.ToString();
            txtSubject.Text = commitmentSelected.subject;
            txtDate.Value = commitmentSelected.date;
            txtStartTime.Value = DateTime.Now.Date.Add(commitmentSelected.startTime);
            txtEndTime.Value = DateTime.Now.Date.Add(commitmentSelected.endTime);

            if (commitmentSelected.contact != null)
            {
                chkSelectContact.Checked = true;
                cmbContacts.SelectedItem = commitmentSelected.contact;
            }

            if (commitmentSelected.locationType == CommitmentLocationTypeEnum.InPerson)
            {
                rdbInPerson.Checked = true;
                txtInPerson.Text = commitmentSelected.inPerson;
            }
            else
            {
                rdbOnline.Checked = true;
                txtOnline.Text = commitmentSelected.online;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Commitment commitment = GetCommitment();

            string[] errors = commitment.Errors();

            if (errors.Length > 0)
            {
                MainScreenForm.Instance.UpdateFooter(errors[0]);
                DialogResult = DialogResult.None;
            }
        }

        private void rdbInPerson_CheckedChanged(object sender, EventArgs e)
        {
            txtInPerson.Enabled = true;
            txtOnline.Enabled = false;
            txtOnline.Text = "";
        }

        private void rdbOnline_CheckedChanged(object sender, EventArgs e)
        {
            txtOnline.Enabled = true;
            txtInPerson.Enabled = false;
            txtInPerson.Text = "";
        }

        private void chkSelectContact_CheckedChanged(object sender, EventArgs e)
        {
            cmbContacts.Enabled = !cmbContacts.Enabled;
            cmbContacts.SelectedIndex = -1;
        }
    }
}
