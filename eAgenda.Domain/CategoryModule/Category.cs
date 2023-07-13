using eAgenda.Domain.ExpenseModule;

namespace eAgenda.Domain.CategoryModule
{
    [Serializable]
    public class Category : EntityBase<Category>
    {
        public string title;
        public decimal finalPrice;
        public List<Expense> expenses = new List<Expense>();

        public Category() { }

        public Category(int id, string title)
        {
            this.id = id;
            this.title = title;
            expenses = new List<Expense>();
        }

        public override void UpdateInfos(Category updateRecord)
        {
            title = updateRecord.title;
        }

        public decimal CalculateFinalPrice(List<Expense> expenses)
        {
            finalPrice = 0;

            foreach (Expense expense in expenses)
            {
                finalPrice += expense.price;
            }

            return finalPrice;
        }

        public override string ToString()
        {
            return title;
        }

        public override string[] Errors()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrEmpty(title))
                errors.Add("\"Title\" is a required field.");

            return errors.ToArray();
        }
    }
}
