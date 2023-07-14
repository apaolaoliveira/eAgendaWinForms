using eAgenda.Domain.CommitmentModule;

namespace eAgenda.Infra.Data.BinarySerialization.CommitmentModule
{
    public class CommitmentRepositoryBinarySerialization : RepositoryBinarySerializationBase<Commitment>, ICommitmentRepository
    {
        public CommitmentRepositoryBinarySerialization(List<Commitment> recordsList) : base(recordsList)
        {
            EntityName = "commitment";

            UploadEntityFromFile();
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
