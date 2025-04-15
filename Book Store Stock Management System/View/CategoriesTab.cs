using Book_Store_Stock_Management_System.Controller;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class CategoriesTab : UserControl
    {
        List<Category> categoryList = new List<Category>();

        public CategoriesTab()
        {
            InitializeComponent();
            categoryList = CategoriesDB.GetCategories();
            populateList();
        }

        public void populateList()
        {
            listViewCategory.Items.Clear();

            var items = categoryList.Select(category => new ListViewItem(category.CategoryId.ToString())
            {
                SubItems = { category.CategoryName }
            }).ToArray();

            listViewCategory.Items.AddRange(items);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (CategoryForm categoryForm = new CategoryForm())
            {
                if (categoryForm.ShowDialog() == DialogResult.OK)
                {
                    Category newCategory = categoryForm.categoryDetail;
                    CategoriesDB.AddCategory(newCategory);
                    categoryList = CategoriesDB.GetCategories();
                    populateList();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewCategory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose category to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = int.Parse(listViewCategory.SelectedItems[0].SubItems[0].Text);
            Category selectedCategory = categoryList.FirstOrDefault(c => c.CategoryId == categoryId);

            if (selectedCategory == null)
            {
                MessageBox.Show("Category not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (CategoryForm categoryForm = new CategoryForm(selectedCategory))
            {
                if (categoryForm.ShowDialog() == DialogResult.OK)
                {
                    Category updated = categoryForm.categoryDetail;
                    CategoriesDB.UpdateCategory(updated);
                    categoryList = CategoriesDB.GetCategories();
                    populateList();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            var filtered = categoryList
                .Where(c => c.CategoryName.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();

            filterList(filtered);
        }

        public void filterList(List<Category> categories)
        {
            listViewCategory.Items.Clear();

            var items = categories.Select(category => new ListViewItem(category.CategoryId.ToString())
            {
                SubItems = { category.CategoryName }
            }).ToArray();

            listViewCategory.Items.AddRange(items);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewCategory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose category to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoryId = int.Parse(listViewCategory.SelectedItems[0].SubItems[0].Text);
            Category selectedCategory = categoryList.FirstOrDefault(c => c.CategoryId == categoryId);

            if (selectedCategory == null)
            {
                MessageBox.Show("Category not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete " + selectedCategory.CategoryName + "?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string errorMessage;
                bool success = CategoriesDB.DeleteCategory(categoryId, out errorMessage);

                if (success)
                {
                    categoryList = CategoriesDB.GetCategories();
                    populateList();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
