using eAgenda.Domain.CommitmentModule;
using eAgenda.Domain.ContactModule;
using eAgenda.Domain.TaskModule;
using eAgenda.Domain.ExpenseModule;

using eAgenda.WinForms.CommitmentModule;
using eAgenda.WinForms.ContactModule;
using eAgenda.WinForms.TaskModule;
using eAgenda.WinForms.ExpenseModule;
using eAgenda.Domain.CategoryModule;
using eAgenda.WinForms.CategoryModule;

// Memory
using eAgenda.Infra.Data.Memory.CommitmentModule;
using eAgenda.Infra.Data.Memory.ContactMoldule;
using eAgenda.Infra.Data.Memory.TaskModule;
using eAgenda.Infra.Data.Memory.ExpenseModule;
using eAgenda.Infra.Data.Memory.CategoryModule;

// Binary Serialization
using eAgenda.Infra.Data.BinarySerialization.TaskModule;
using eAgenda.Infra.Data.BinarySerialization.ContactModule;
using eAgenda.Infra.Data.BinarySerialization.CommitmentModule;
using eAgenda.Infra.Data.BinarySerialization.CategoryModule;
using eAgenda.Infra.Data.BinarySerialization.ExpenseModule;

namespace eAgenda.WinForms
{
    public partial class MainScreenForm : Form
    {
        private ControllerBase _controller;

        private IContactRepository _contactRepository = new ContactRepositoryBinarySerialization(new List<Contact>());
        private ICommitmentRepository _commitmentRepository = new CommitmentRepositoryBinarySerialization(new List<Commitment>());
        private ITaskRepository _taskRepository = new TaskRepositoryBinarySerialization(new List<Domain.TaskModule.Task>());//TaskRepositoryMemory(new List<Domain.TaskModule.Task>());
        private IExpenseRepository _expenseRepository = new ExpenseRepositoryBinarySerialization(new List<Expense>());
        private ICategoryRepository _categoryRepository = new CategoryRepositoryBinarySerialization(new List<Category>());

        private static MainScreenForm _mainScreenForm;

        public MainScreenForm()
        {
            InitializeComponent();
            _mainScreenForm = this;
        }

        public static MainScreenForm Instance
        {
            get
            {
                //This is Singleton, from Design Patterns, retricts the instantiation of a class to a single object, making it global.
                //It ensures that just one instance exist throughout the program. 
                if (_mainScreenForm == null)
                    _mainScreenForm = new MainScreenForm();

                return _mainScreenForm;
            }
        }

        // Controls Modules --------------------------------------------------------

        private void contactMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new ContactController(_contactRepository);
            ConfigMainScreen(_controller);
        }

        private void commitmentMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new CommitmentController(_commitmentRepository, _contactRepository);
            ConfigMainScreen(_controller);
        }

        private void taskMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new TaskController(_taskRepository);
            ConfigMainScreen(_controller);
        }

        private void expensesMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new ExpenseController(_expenseRepository, _categoryRepository);
            ConfigMainScreen(_controller);
        }

        private void categoryMenuItem_Click(object sender, EventArgs e)
        {
            _controller = new CategoryController(_categoryRepository, _expenseRepository);
            ConfigMainScreen(_controller);
        }

        // Controls Facilities -----------------------------------------------------             

        private void ConfigMainScreen(ControllerBase controlerBase)
        {
            toolStrip.Enabled = true;
            lblRecordType.Text = controlerBase.GetRegisterType();

            ConfigToolStrip(controlerBase);
            configList(controlerBase);
        }

        private void ConfigToolStrip(ControllerBase controler)
        {
            toolStrip.Enabled = true;
            ConfigToolTips(controler);
            ConfigEnable(controler);
        }

        private void configList(ControllerBase controlerBase)
        {
            UserControl list = controlerBase.GetList();

            list.Dock = DockStyle.Fill;
            pnlRecords.Controls.Clear();

            pnlRecords.Controls.Add(list);
        }

        private void ConfigToolTips(ControllerBase controler)
        {
            btnAdd.ToolTipText = controler.ToolTipAdd;
            btnUpdate.ToolTipText = controler.ToolTipUpdate;
            btnDelete.ToolTipText = controler.ToolTipDelete;
            btnFilter.ToolTipText = controler.ToolTipFilter;
            btnAddItem.ToolTipText = controler.ToolTipAddItem;
            btnCheckItem.ToolTipText = controler.ToolTipCheckItem;
            btnList.ToolTipText = controler.ToolTipList;
        }

        private void ConfigEnable(ControllerBase controller)
        {
            btnAdd.Enabled = controller.AddEnable;
            btnUpdate.Enabled = controller.UpdateEnable;
            btnDelete.Enabled = controller.DeleteEnable;
            btnFilter.Enabled = controller.FilterEnable;
            btnAddItem.Enabled = controller.AddItemEnable;
            btnCheckItem.Enabled = controller.CheckItemEnable;
            btnList.Enabled = controller.ListEnable;
            separatorFilter.Visible = controller.SeparatorFilterVisible;
            lblFilter.Visible = controller.lblFilterVisible;
        }

        public void UpdateFooter(string message)
        {
            lblFooter.Text = message;
        }

        public void UpdateLblFilter(string message)
        {
            lblFilter.Text = message;
        }

        public string GetFilterText()
        {
            return lblFilter.Text;
        }

        // CRUD --------------------------------------------------------------------   

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.Add();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _controller.Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _controller.Delete();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _controller.Filter();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _controller.AddItem();
        }

        private void btnCheckItem_Click(object sender, EventArgs e)
        {
            _controller.CheckItem();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            _controller.List();
        }
    }
}