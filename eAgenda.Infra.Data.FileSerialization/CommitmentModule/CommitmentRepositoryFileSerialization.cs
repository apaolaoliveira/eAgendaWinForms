using eAgenda.Domain.CommitmentModule;

namespace eAgenda.Infra.Data.FileSerialization.CommitmentModule
{
    public class CommitmentRepositoryFileSerialization : RepositoryFileSerializationBase<Commitment>, ICommitmentRepository
    {
        public CommitmentRepositoryFileSerialization(DataContext dataContext) : base(dataContext)
        {
        }

        public List<Commitment> SelectFutureCommitment(DateTime startDate, DateTime endDate)
        {
            return GetRecord()
                    .Where(x => x.date > startDate)
                    .Where(x => x.date < endDate)
                   .ToList();
        }

        public List<Commitment> SelectPastCommitment(DateTime now)
        {
            return GetRecord()
                    .Where(x => x.date.Date < now.Date)
                    .ToList();
        }

        protected override List<Commitment> GetRecord()
        {
            return dataContext.commitments;
        }
    }
}
