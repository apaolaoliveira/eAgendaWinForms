using eAgenda.Domain.ExpenseModule;

namespace eAgenda.WinForms.ExpenseModule
{
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository _categoryRepository;
        private IExpenseRepository _expenseRepository;
        private GridCategoryControl _categoryGrid;
        private CategoryListControl _categoryListControl;

        public CategoryController(ICategoryRepository repository, IExpenseRepository expenseRepository)
        {
            _categoryRepository = repository;
            _expenseRepository = expenseRepository;
        }
         
        public override string ToolTipAdd => "Add new Category";

        public override string ToolTipUpdate => "Edit Category";

        public override string ToolTipDelete => "Delete Category";

        public override string ToolTipList => "Expenses' categories";

        public override bool ListEnable => true;

        public override void Add()
        {            
            CategoryScreenForm categoryScreen = new CategoryScreenForm();
            categoryScreen.Text = "Add a new category";
            DialogResult selectedOption = categoryScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Category newCategory = categoryScreen.GetCategory();
                _categoryRepository.Add(newCategory);
            }

            UploadCategory();
        }

        public override void Update()
        {
            Category selectedCategory = GetSelectedCategory();

            if (selectedCategory == null)
            {
                MessageBox.Show("First, select a category!", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CategoryScreenForm CategoryScreen = new CategoryScreenForm();
            CategoryScreen.Text = "Update selected category";
            CategoryScreen.ConfigScreen(selectedCategory);

            DialogResult selectedOption = CategoryScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Category updateCategory = CategoryScreen.GetCategory();

                _categoryRepository.Update(updateCategory.id, updateCategory);
            }

            UploadCategory();
        }

        public override void Delete()
        {
            Category selectedCategory = GetSelectedCategory();

            if (selectedCategory == null)
            {
                MessageBox.Show("First, select a Category!", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult selectedOption =
                MessageBox.Show($"Are you sure about deleting \"{selectedCategory.title}\" from your list?",
                                "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (selectedOption == DialogResult.Yes)
            {
                _categoryRepository.Delete(selectedCategory);
            }            

            UploadCategory();
        }

        public override void List()
        {
            Category selectedCategory = GetSelectedCategory();

            if (selectedCategory == null)
            {
                MessageBox.Show("First, select a Category!", "View expenses' categories", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<Expense> expenses = _expenseRepository.GetByCategories(selectedCategory);

            if(expenses.Count == 0)
            {
                MessageBox.Show("There's no expenses for this category!", "View expenses' categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CategoryListScreenForm categoryListScreen = new CategoryListScreenForm();
            categoryListScreen.Text = "View expenses' categories";
            
            if (_categoryListControl == null)
                _categoryListControl = new CategoryListControl();

            categoryListScreen.SetCategoryName(selectedCategory.title);

            decimal finalPrice = selectedCategory.CalculateFinalPrice(expenses);
            categoryListScreen.UploadRecords(expenses, finalPrice);

            categoryListScreen.ShowDialog();
        }

        public override UserControl GetList()
        {
            _categoryGrid = new GridCategoryControl();

            UploadCategory();

            return _categoryGrid;
        }        

        private void UploadCategory()
        {
            List<Category> category = _categoryRepository.GetAll();

            _categoryGrid.UpdateList(category);
        }

        private Category GetSelectedCategory()
        {
            int id = _categoryGrid.GetSelectedId();

            return _categoryRepository.SelectId(id);
        }

        public override string GetRegisterType()
        {
            return "Categories' Records";
        }
    }
}
