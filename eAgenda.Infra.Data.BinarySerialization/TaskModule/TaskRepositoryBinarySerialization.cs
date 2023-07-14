using eAgenda.Domain.TaskModule;
using eAgenda.Infra.Data.BinarySerialization.Shared;

namespace eAgenda.Infra.Data.BinarySerialization.TaskModule
{
    public class TaskRepositoryBinarySerialization : RepositoryBinarySerializationBase<Domain.TaskModule.Task>, ITaskRepository
    {
        public TaskRepositoryBinarySerialization(List<Domain.TaskModule.Task> recordsList) : base(recordsList)
        {
            EntityName = "task";

            UploadEntityFromFile();
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
    }
}
