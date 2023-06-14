using eAgenda.Domain.CommitmentModule;

namespace eAgenda.WinForms.CommitmentModule
{
    public partial class CommitmentFilterScreenForm : Form
    {
        public CommitmentFilterScreenForm()
        {
            InitializeComponent();
        }

        public CommitmentStatusEnum GetStatus()
        {
            if (rdbFuture.Checked)
                return CommitmentStatusEnum.Future;

            else if (rdbPast.Checked)
                return CommitmentStatusEnum.Past;

            else
                return CommitmentStatusEnum.All;
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
