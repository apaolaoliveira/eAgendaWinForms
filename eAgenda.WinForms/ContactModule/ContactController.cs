using eAgenda.Domain.ContactModule;

namespace eAgenda.WinForms.ContactModule
{
    public class ContactController : ControllerBase
    {
        private IContactRepository _contactRepository;
        private GridContactControl _contactGrid;

        public ContactController(IContactRepository repository)
        {
            _contactRepository = repository;
        }
        public override string ToolTipAdd => "Add new Contact";

        public override string ToolTipUpdate => "Edit Contact";

        public override string ToolTipDelete => "Delete Contact";

        private Contact GetSelectedContact()
        {
            int id = _contactGrid.GetSelectedId();

            return _contactRepository.SelectId(id);
        }

        public override void Add()
        {
            ContactScreenForm contactScreenForm = new ContactScreenForm();
            DialogResult selectedOption = contactScreenForm.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Contact newContact = contactScreenForm.GetContact();
                _contactRepository.Add(newContact);

                MessageBox.Show("Informations suscessfuly recorded!");
            }
            
            UploadContacts();
        }

        public override void Update()
        {
            Contact contact = GetSelectedContact();

            if (contact == null)
            {
                MessageBox.Show("First select a contact!", "Update Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ContactScreenForm contactScreenForm = new ContactScreenForm();
            contactScreenForm.ConfigScreen(contact);

            DialogResult selectedOption = contactScreenForm.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Contact updateContact = contactScreenForm.GetContact();
                _contactRepository.Update(updateContact.id, updateContact);
                MessageBox.Show("Informations suscessfuly updated!");
            }
            
            UploadContacts();
        }

        public override void Delete()
        {
            Contact contact = GetSelectedContact();

            if (contact == null)
            {
                MessageBox.Show("First select a contact!", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult selectedOption =
                MessageBox.Show($"Are you sure about deleting \"{contact.Name}\" from your list?",
                                "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedOption == DialogResult.Yes)
            {
                _contactRepository.Delete(contact);
                MessageBox.Show("Contact suscessfuly deleted!");
            }
           
            UploadContacts();
        }

        private void UploadContacts()
        {
            List<Contact> contacts = _contactRepository.GetAll();
            _contactGrid.UpdateList(contacts);
        }

        public override UserControl GetList()
        {
            if (_contactGrid == null)
                _contactGrid = new GridContactControl();

            UploadContacts();
            return _contactGrid;
        }

        public override string GetRegisterType()
        {
            return "Contacts' Records";
        }
    }
}
