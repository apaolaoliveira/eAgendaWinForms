using eAgenda.Domain.ContactModule;

namespace eAgenda.Domain.CommitmentModule
{
    [Serializable]
    public class Commitment : EntityBase<Commitment>
    {        
        public Contact contact;
        public string subject;

        public DateTime date;
        public TimeSpan startTime;
        public TimeSpan endTime;

        public CommitmentLocationTypeEnum locationType;
        public string online;
        public string inPerson;        

        public Commitment() { }

        public Commitment(int id, Contact contact, string subject, DateTime date,
                            TimeSpan startTime, TimeSpan endTime, CommitmentLocationTypeEnum locationType, string local)
        {
            this.id = id;
            this.contact = contact;
            this.subject = subject;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.locationType = locationType;

            if (locationType == CommitmentLocationTypeEnum.Online)
                online = local;
            else
                inPerson = local;
        }

        public Commitment(Contact contact, string subject, DateTime date,
                            TimeSpan startTime, TimeSpan endTime, CommitmentLocationTypeEnum locationType, string local)
        {
            this.contact = contact;
            this.subject = subject;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.locationType = locationType;

            if (locationType == CommitmentLocationTypeEnum.Online)
                online = local;
            else
                inPerson = local;
        }

        public override string ToString()
        {
            return $"Id: {id}, Subject: {subject}, Location: {locationType}, Today: {date} ";
        }

        public override void UpdateInfos(Commitment updateCommitment)
        {
            contact = updateCommitment.contact;
            subject = updateCommitment.subject;
            date = updateCommitment.date;
            startTime = updateCommitment.startTime;
            endTime = updateCommitment.endTime;
            locationType = updateCommitment.locationType;

            if (locationType == CommitmentLocationTypeEnum.Online)
                online = updateCommitment.online;
            else
                inPerson = updateCommitment.inPerson;
        }

        public override string[] Errors()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(subject))
                erros.Add("\"Subject\" is a required field.");

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Commitment commitment &&
                          id == commitment.id &&
                          subject == commitment.subject &&
                          date == commitment.date &&
                          startTime.Equals(commitment.startTime) &&
                          endTime.Equals(commitment.endTime) &&
                          EqualityComparer<Contact>.Default.Equals(contact, commitment.contact) &&
                          inPerson == commitment.inPerson &&
                          online == commitment.online &&
                          locationType == commitment.locationType;
        }
    }
}
