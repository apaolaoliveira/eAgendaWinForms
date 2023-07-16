using eAgenda.Domain.CommitmentModule;

namespace eAgenda.Infra.Data.FileSerialization.CommitmentModule
{
    public class CommitmentRepositoryFileSerialization : RepositoryFileSerializationBase<Commitment>, ICommitmentRepository
    {
        public CommitmentRepositoryFileSerialization()
        {
            EntityName = "Commitment";
        }

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
