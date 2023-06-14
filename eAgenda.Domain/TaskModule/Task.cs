namespace eAgenda.Domain.TaskModule
{
    [Serializable]
    public class Task : EntityBase<Task>
    {
        public string title;
        public TaskPriorityEnum priority;
        public DateTime creationDate;
        public decimal percentCompleted;

        public List<TaskItem> items;

        public Task() { }

        public Task(int id, string title, TaskPriorityEnum priority, DateTime creationDate)
        {
            this.id = id;
            this.title = title;
            this.priority = priority;
            this.creationDate = creationDate;
            this.items = new List<TaskItem>();
        }

        public Task(string title, TaskPriorityEnum priority, DateTime creationDate)
        {
            this.title = title;
            this.priority = priority;
            this.creationDate = creationDate;
            this.items = new List<TaskItem>();
        }

        public void CalculatePercentCompleted()
        {
            decimal itemsQuantity = items.Count();

            if (itemsQuantity == 0)
                return;

            decimal doneQuantity = items.Count(i => i.done == true);
            decimal result = (doneQuantity / itemsQuantity) * 100;

            percentCompleted = Math.Round(result, 2);
        }

        public void AddItem(TaskItem item)
        {
            items.Add(item);
        }

        public void CheckItem(TaskItem item)
        {
            TaskItem selectedItem = items.FirstOrDefault(i => i.Equals(item));
            selectedItem.Check();

            CalculatePercentCompleted();
        }

        public void UncheckItem(TaskItem item)
        {
            TaskItem selectedItem = items.FirstOrDefault(i => i.Equals(item));
            selectedItem.Uncheck();

            CalculatePercentCompleted();
        }

        public override string ToString()
        {
            return $"Id: {id}, Title: {title}, Prioriry: {priority}, Percent Completed: {percentCompleted}";
        }

        public override void UpdateInfos(Task updateRecord)
        {
            id = updateRecord.id;
            title = updateRecord.title;
            priority = updateRecord.priority;
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
