namespace eAgenda.Domain.ExpenseModule
{
    [Serializable]
    public class Category : EntityBase<Category>
    {
        public string title;
        public List<Expense> relateExpenses;

        public Category() { }

        public Category(string title)
        {
            this.title = title;
            this.relateExpenses = new List<Expense>();
        }

        public Category(int id, string title)
        {
            this.id = id;
            this.title = title;
            this.relateExpenses = new List<Expense>();
        }

        public override void UpdateInfos(Category updateRecord)
        {
            title = updateRecord.title;
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
