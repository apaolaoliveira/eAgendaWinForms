using System.Text.RegularExpressions;

namespace eAgenda.Domain.ContactModule
{
    [Serializable]
    public class Contact : EntityBase<Contact>
    {
        public string Name { get; set; }

        public string email;
        public string phone;
        public string company;
        public string position;

        public Contact() { }

        public Contact(string Name, string email, string phone, string company, string position)
        {
            this.Name = Name;
            this.email = email;
            this.phone = phone;
            this.company = company;
            this.position = position;
        }

        public Contact(int id, string Name, string email, string phone, string company, string position)
        {
            this.id = id;
            this.Name = Name;
            this.email = email;
            this.phone = phone;
            this.company = company;
            this.position = position;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public override void UpdateInfos(Contact entity)
        {
            Name = entity.Name;
            email = entity.email;
            phone = entity.phone;
            company = entity.company;
            position = entity.position;
        }

        public override string[] Errors()
        {
            List<string> errors = new List<string>();

            string phoneDigitsOnly = Regex.Replace(phone, "[^0-9]", ""); //replace non-numeric characters with white spaces

            if (string.IsNullOrEmpty(Name))
                errors.Add("\"Name\" is a require field.");

            if (string.IsNullOrEmpty(phoneDigitsOnly))
                errors.Add("\"Phone\" is a require field.");

            if (phoneDigitsOnly.Length != 11)
                errors.Add("\"Phone\" must be filled with 11 digits.");

            if (string.IsNullOrEmpty(email))
                errors.Add("\"Email\" is a require field.");

            if (!email.Contains("@") || !email.Contains(".com"))
                errors.Add($"Email invalidy.");

            return errors.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Contact contact &&
                   id == contact.id &&
                   Name == contact.Name &&
                   phone == contact.phone &&
                   email == contact.email &&
                   position == contact.position &&
                   company == contact.company;
        }
    }
}
