using eAgenda.Domain.ExpenseModule;

namespace eAgenda.WinForms.ExpenseModule
{
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository _categoryRepository;
        private GridCategoryControl _categoryGrid;

        public CategoryController(ICategoryRepository repository)
        {
            _categoryRepository = repository;
        }
        public override string ToolTipAdd => "Add new Category";

        public override string ToolTipUpdate => "Edit Category";

        public override string ToolTipDelete => "Delete Category";

        public override void Add()
        {            
            CategoryScreenForm categoryScreen = new CategoryScreenForm();
            DialogResult selectedOption = categoryScreen.ShowDialog();

            if (selectedOption == DialogResult.OK)
            {
                Category newCategory = categoryScreen.GetCategory();
                _categoryRepository.Add(newCategory);

                MessageBox.Show("Informations suscessfuly recorded!");
            }

            UploadCategory();
        }

        public override void Update()
        {
            Category selectedCategory = GetSelectedCategory();

            if (selectedCategory == null)
            {
                MessageBox.Show("First select a category!", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            CategoryScreenForm CategoryScreen = new CategoryScreenForm();

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
                MessageBox.Show("First select a Category!", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

            MainScreenForm.Instance.UpdateFooter($"Viewing {category.Count} Categories.");
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
