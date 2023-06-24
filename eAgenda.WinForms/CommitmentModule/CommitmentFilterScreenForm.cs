using eAgenda.Domain.CommitmentModule;

namespace eAgenda.WinForms.CommitmentModule
{
    public partial class CommitmentFilterScreenForm : Form
    {
        public CommitmentFilterScreenForm()
        {
            InitializeComponent();
            this.ConfigDialog();
        }

        public CommitmentStatusEnum GetStatus()
        {
            if (rdbFuture.Checked)
            {
                MainScreenForm.Instance.UpdateLblFilter("Filtering Future Commitments");
                return CommitmentStatusEnum.Future;
            }

            else if (rdbPast.Checked)
            {
                MainScreenForm.Instance.UpdateLblFilter("Filtering Past Commitments");
                return CommitmentStatusEnum.Past;
            }

            else
            {
                MainScreenForm.Instance.UpdateLblFilter("Filtering All Commitments");
                return CommitmentStatusEnum.All;
            }
        }

        public DateTime GetStartDate()
        {
            return txtStartDate.Value;
        }

        public DateTime GetEndDate()
        {
            return txtEndDate.Value;
        }

        private void rdbFuturos_CheckedChanged(object sender, EventArgs e)
        {
            txtStartDate.Enabled = !txtStartDate.Enabled;
            txtEndDate.Enabled = !txtEndDate.Enabled;
        }
    }
}
