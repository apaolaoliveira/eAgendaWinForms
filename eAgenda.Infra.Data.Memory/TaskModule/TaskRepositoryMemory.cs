using eAgenda.Domain.TaskModule;

namespace eAgenda.Infra.Data.Memory.TaskModule
{
    public class TaskRepositoryMemory : RepositoryMemoryBase<Domain.TaskModule.Task>, ITaskRepository
    {
        public TaskRepositoryMemory(List<Domain.TaskModule.Task> tasks) : base(tasks) { }

        public List<Domain.TaskModule.Task> SelectByPriorities()
        {
            return recordsList
                .OrderByDescending(x => x.priority)
                .ToList();
        }

        public List<Domain.TaskModule.Task> SelectDone()
        {
            return recordsList
               .Where(x => x.percentCompleted == 100)
               .OrderByDescending(x => x.priority)
               .ToList();
        }

        public List<Domain.TaskModule.Task> SelectPending()
        {
            return recordsList
               .Where(x => x.percentCompleted < 100)
               .OrderByDescending(x => x.priority)
               .ToList();
        }
    }
}
