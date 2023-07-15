using eAgenda.Domain.CommitmentModule;

namespace eAgenda.Infra.Data.XmlSerializations.CommitmentModule
{
    public class CommitmentRepositoryXmlSerialization : RepositoryXmlSerializationBase<Commitment>, ICommitmentRepository
    {
        public CommitmentRepositoryXmlSerialization(List<Commitment> recordsList) : base(recordsList)
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
