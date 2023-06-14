using eAgenda.Domain.CommitmentModule;

namespace eAgenda.WinForms.CommitmentModule
{
    public partial class GridCommitmentControl : UserControl
    {
        public GridCommitmentControl()
        {
            InitializeComponent();
            ConfigColumns();

            gridCommitments.ConfigGridColor();
            gridCommitments.ConfigGridReadOnly();
        }

        private void ConfigColumns()
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "ID"                    
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "subject",
                    HeaderText = "SUBJECT"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "date",
                    HeaderText = "DATE"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "startTime",
                    HeaderText = "START TIME"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "contact.Name",
                    HeaderText = "CONTACT"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "locationType",
                    HeaderText = "LOCAL"
                }
            };

            gridCommitments.Columns.AddRange(columns);
        }

        public void UpdateList(List<Commitment> commitments)
        {
            gridCommitments.Rows.Clear();

            foreach (Commitment commitment in commitments)
            {
                gridCommitments.Rows.Add(commitment.id, commitment.subject, commitment.date, commitment.startTime, commitment.contact.Name, commitment.locationType);
            }
        }

        public int GetSelectedId()
        {
            if (gridCommitments.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(gridCommitments.SelectedRows[0].Cells["id"].Value);

            return id;
        }
    }
}
