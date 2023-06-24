using eAgenda.Domain.ContactModule;

namespace eAgenda.WinForms.ContactModule
{
    public partial class GridContactControl : UserControl
    {
        public GridContactControl()
        {
            InitializeComponent();
            ConfigColumns();

            gridContacts.ConfigGridColor();
            gridContacts.ConfigGridReadOnly();
        }

        private void ConfigColumns()
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "name",
                    HeaderText = "NAME"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "email",
                    HeaderText = "EMAIL"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "phone",
                    HeaderText = "PHONE"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "company",
                    HeaderText = "COMPANY"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "position",
                    HeaderText = "POSITION"
                }
            };

            gridContacts.Columns.AddRange(columns);
        }

        public void UpdateList(List<Contact> contacts)
        {
            gridContacts.Rows.Clear();

            foreach (Contact contact in contacts)
            {
                gridContacts.Rows.Add(contact.id, contact.Name, contact.email, contact.phone, contact.company, contact.position);
            }

            MainScreenForm.Instance.UpdateFooter($"Viewing {contacts.Count} contacts");
        }

        public int GetSelectedId()
        {
            if (gridContacts.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridContacts.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
