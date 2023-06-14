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
        }

        public override string ToolTipAdd => "Add new Commitment";

        public override string ToolTipUpdate => "Edit Commitment";

        public override string ToolTipDelete => "Delete Commitment";

        public override string ToolTipFilter => "Commitments\' Filter";

        public override bool FilterEnable => true;

        public override void Add()
        {
            List<Contact> contacts = _contactRepository.GetAll();
            CategoryScreenForm commitmentScreen = new CategoryScreenForm(contacts);

            DialogResult selectedOption = commitmentScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Commitment newCommitment = commitmentScreen.GetCommitment();
                _commitmentRepository.Add(newCommitment);

                MessageBox.Show("Informations suscessfuly recorded!");
            }

            UploadCommitments();
        }
        public override void Update()
        {
            Commitment selectedCommitment = GetSelectedCommitment();

            if (selectedCommitment == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                   "Edição de Commitments",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);

                return;
            }

            List<Contact> contacts = _contactRepository.GetAll();
            CategoryScreenForm commitmentScreen = new CategoryScreenForm(contacts);

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
                MessageBox.Show("First select a commitment!", "Delete Commitment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult selectedOption =
                MessageBox.Show($"Are you sure about deleting \"{selectedCommitment.subject}\" from your list?",
                                "Delete Commitment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedOption == DialogResult.Yes)
            {
                _commitmentRepository.Delete(selectedCommitment);

            }

            UploadCommitments();
        }

        public override void Filter()
        {
            CommitmentFilterScreenForm filterScreen = new CommitmentFilterScreenForm();
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

                MainScreenForm.Instance.UpdateFooter($"Viewing {commitment.Count} Commitments");
            }
        }

        private void UploadCommitments(List<Commitment> Commitments)
        {
            _commitmentGrid.UpdateList(Commitments);
        }

        private Commitment GetSelectedCommitment()
        {
            int id = _commitmentGrid.GetSelectedId();

            return _commitmentRepository.SelectId(id);
        }

        private void UploadCommitments()
        {
            List<Commitment> commitments = _commitmentRepository.GetAll();

            _commitmentGrid.UpdateList(commitments);
        }

        public override UserControl GetList()
        {
            if (_commitmentGrid == null)
            {
                _commitmentGrid = new GridCommitmentControl();
            }

            UploadCommitments();

            return _commitmentGrid;
        }

        public override string GetRegisterType()
        {
            return "Commitments' Records";
        }
    }
}
