using eAgenda.Domain.TaskModule;

namespace eAgenda.Infra.Data.FileSerialization.TaskModule
{
    public class TaskRepositoryFileSerialization : RepositoryFileSerializationBase<Domain.TaskModule.Task>, ITaskRepository
    {
        public TaskRepositoryFileSerialization(DataContext dataContext) : base(dataContext)
        {
        }

        public List<Domain.TaskModule.Task> SelectByPriorities()
        {
            return GetAll()
                    .OrderBy(x => x.priority)
                    .ToList();
        }

        public List<Domain.TaskModule.Task> SelectPending()
        {
            return GetAll()
                    .Where(x => x.percentCompleted < 100)
                    .ToList();
        }

        public List<Domain.TaskModule.Task> SelectDone()
        {
            return GetAll()
                    .Where(x => x.percentCompleted == 100)
                    .ToList();
        }

        protected override List<Domain.TaskModule.Task> GetRecord()
        {
            return dataContext.tasks;
        }
    }
}
