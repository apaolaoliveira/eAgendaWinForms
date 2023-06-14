namespace eAgenda.Domain.TaskModule
{
    public interface ITaskRepository
    {
        void Add(Task newTask);
        void Update(int id, Task updateTask);
        void Delete(Task task);
        Task SelectId(int id);
        List<Task> SelectByPriorities();
        List<Task> SelectPending();
        List<Task> SelectDone();
    }
}
