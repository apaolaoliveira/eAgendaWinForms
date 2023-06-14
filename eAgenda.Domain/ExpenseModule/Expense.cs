namespace eAgenda.Domain.ExpenseModule
{
    [Serializable]
    public class Expense : EntityBase<Expense>
    {
        public string description;
        public DateTime date;
        public decimal price;
        public ExpensePaymentMethodEnum paymentMethod;

        public List<Category> selectedCategory;

        public Expense() { }

        public Expense(string description, DateTime date, decimal value, ExpensePaymentMethodEnum paymentMethod)
        {
            this.description = description;
            this.date = date;
            this.price = value;
            this.paymentMethod = paymentMethod;
            this.selectedCategory = new List<Category>();
        }

        public override void UpdateInfos(Expense updateRecord)
        {
            description = updateRecord.description;
            date = updateRecord.date;
            price = updateRecord.price;
            paymentMethod = updateRecord.paymentMethod;
            selectedCategory = updateRecord.selectedCategory;
        }

        public override string[] Errors()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(description))           
                errors.Add("\"Description\" is a required field.");           

            if (date == DateTime.MinValue)            
                errors.Add("\"Date\" is a required field.");            

            if (price <= 0)            
                errors.Add("\"Price\" must be bigger than 0.");            

            if (paymentMethod == ExpensePaymentMethodEnum.None)            
                errors.Add("\"Payment Method\" is a required field.");            

            return errors.ToArray();
        }
    }
}
