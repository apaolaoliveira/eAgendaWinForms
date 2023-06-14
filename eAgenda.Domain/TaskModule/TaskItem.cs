namespace eAgenda.Domain.TaskModule
{
    [Serializable]
    public class TaskItem
    {
        public string title;
        public bool done;

        public TaskItem() { }
        public TaskItem(string title)
        {
            this.title = title;
        }

        public override string ToString()
        {
            return title;
        }

        public void Check()
        {
            done = true;
        }

        public void Uncheck()
        {
            done = false;
        }

        public bool Equals(object? obj)
        {
            return obj is TaskItem task &&
                          title == task.title &&
                          done == task.done;
        }
    }
}
