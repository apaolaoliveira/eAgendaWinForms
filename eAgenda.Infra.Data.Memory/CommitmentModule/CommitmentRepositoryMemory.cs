using eAgenda.Domain.CommitmentModule;

namespace eAgenda.Infra.Data.Memory.CommitmentModule
{
    public class CommitmentRepositoryMemory : RepositoryMemoryBase<Commitment>, ICommitmentRepository
    {
        public CommitmentRepositoryMemory(List<Commitment> recordsList) : base(recordsList) { }

        public List<Commitment> SelectFutureCommitment(DateTime startDate, DateTime endDate)
        {
            return recordsList
                .Where(x => x.date > startDate)
                .Where(x => x.date < endDate)
                .ToList();
        }

        public List<Commitment> SelectPastCommitment(DateTime now)
        {
            return recordsList.Where(x => x.date.Date < now.Date).ToList();
        }
    }
}
