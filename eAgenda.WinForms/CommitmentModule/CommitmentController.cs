using eAgenda.Domain.CommitmentModule;
using eAgenda.Domain.ContactModule;

namespace eAgenda.WinForms.CommitmentModule
{
    public class CommitmentController : ControllerBase
    {
        private ICommitmentRepository _commitmentRepository;
        private IContactRepository _contactRepository;
        private GridCommitmentControl _commitmentGrid;

        public CommitmentController(ICommitmentRepository repository, IContactRepository contactRepository)
        {
            _commitmentRepository = repository;
            _contactRepository = contactRepository;
            MainScreenForm.Instance.UpdateLblFilter("");
        }

        public override string ToolTipAdd => "Add new Commitment";

        public override string ToolTipUpdate => "Edit Commitment";

        public override string ToolTipDelete => "Delete Commitment";

        public override string ToolTipFilter => "Commitments\' Filter";

        public override bool FilterEnable => true;

        public override bool lblFilterVisible => true;

        public override void Add()
        {
            List<Contact> contacts = _contactRepository.GetAll();
            CategoryScreenForm commitmentScreen = new CategoryScreenForm(contacts);
            commitmentScreen.Text = "Add a new commitment";

            DialogResult selectedOption = commitmentScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Commitment newCommitment = commitmentScreen.GetCommitment();
                _commitmentRepository.Add(newCommitment);
            }

            UploadCommitments();
        }
        public override void Update()
        {
            Commitment selectedCommitment = GetSelectedCommitment();

            if (selectedCommitment == null)
            {
                MessageBox.Show($"First, select a commitment!", "Update Commitment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Contact> contacts = _contactRepository.GetAll();
            CategoryScreenForm commitmentScreen = new CategoryScreenForm(contacts);
            commitmentScreen.Text = "Update selected commitment";
            commitmentScreen.ConfigScreen(selectedCommitment);

            DialogResult selectedOption = commitmentScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Commitment compromisso = commitmentScreen.GetCommitment();

                _commitmentRepository.Update(compromisso.id, compromisso);
            }

            UploadCommitments();
        }

        public override void Delete()
        {
            Commitment selectedCommitment = GetSelectedCommitment();

            if (selectedCommitment == null)
            {
                MessageBox.Show("First, select a commitment!", "Delete Commitment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult selectedOption =
                MessageBox.Show($"Are you sure about deleting \"{selectedCommitment.subject}\" from your list?",
                                "Delete Commitment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedOption == DialogResult.Yes)            
                _commitmentRepository.Delete(selectedCommitment);            

            UploadCommitments();
        }

        public override void Filter()
        {
            CommitmentFilterScreenForm filterScreen = new CommitmentFilterScreenForm();
            filterScreen.Text = "Commitment's filter";
            DialogResult selectedOption = filterScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                CommitmentStatusEnum status = filterScreen.GetStatus();
                List<Commitment> commitment = null;

                if (status == CommitmentStatusEnum.All)                
                    commitment = _commitmentRepository.GetAll();                

                else if (status == CommitmentStatusEnum.Past)                
                    commitment = _commitmentRepository.SelectPastCommitment(DateTime.Now);
                
                else if (status == CommitmentStatusEnum.Future)
                {
                    DateTime startDate = filterScreen.GetStartDate();
                    DateTime endDate = filterScreen.GetEndDate();

                    commitment = _commitmentRepository.SelectFutureCommitment(startDate, endDate);
                }

                UploadCommitments(commitment);
            }
        }

        private void UploadCommitments(List<Commitment> Commitments)
        {
            _commitmentGrid.UpdateList(Commitments);
        }

        private void UploadCommitments()
        {
            List<Commitment> commitments = _commitmentRepository.GetAll();

            _commitmentGrid.UpdateList(commitments);
        }

        private Commitment GetSelectedCommitment()
        {
            int id = _commitmentGrid.GetSelectedId();

            return _commitmentRepository.SelectId(id);
        }

        public override UserControl GetList()
        {
            if (_commitmentGrid == null)            
                _commitmentGrid = new GridCommitmentControl();            

            UploadCommitments();

            return _commitmentGrid;
        }

        public override string GetRegisterType()
        {
            return "Commitments' Records";
        }
    }
}
