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
                    Name = "endTime",
                    HeaderText = "END TIME"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "contactName",
                    HeaderText = "CONTACT"                                       
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "local",
                    HeaderText = "LOCAL"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "locationType",
                    HeaderText = "TYPE"
                }
            };

            gridCommitments.Columns.AddRange(columns);
        }

        public void UpdateList(List<Commitment> commitments)
        {
            gridCommitments.Rows.Clear();

            foreach (Commitment c in commitments)
            {
                gridCommitments.Rows.Add(c.id, c.subject, c.date.ToString("dd/MM/yyyy"), c.startTime, c.endTime, c.contact?.Name, c.online + c.inPerson, c.locationType);
            }

            MainScreenForm.Instance.UpdateFooter($"Viewing {commitments.Count} commitments");
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
