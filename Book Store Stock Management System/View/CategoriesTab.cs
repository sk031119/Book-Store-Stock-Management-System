using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Store_Stock_Management_System.Controller;

namespace Book_Store_Stock_Management_System
{
    public partial class CategoriesTab : UserControl
    {
        List<CategoriesOld> categoryList = new List<CategoriesOld>();
        public CategoriesTab()
        {
            InitializeComponent();
            categoryList = CategoriesDB.GetCategories();

            // Populate list
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
                    CategoriesOld newCategory = categoryForm.categoryDetail;
                    categoryList.Add(newCategory);
                    CategoriesDB.SaveCategories(categoryList);
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

            ListViewItem selectedItem = listViewCategory.SelectedItems[0];
            int categoryId = int.Parse(selectedItem.SubItems[0].Text);
            CategoriesOld selectedCategory = categoryList.FirstOrDefault(b => b.CategoryId == categoryId);

            if (selectedCategory == null)
            {
                MessageBox.Show("Category not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (CategoryForm categoryForm = new CategoryForm(selectedCategory))
            {
                if (categoryForm.ShowDialog() == DialogResult.OK)
                {
                    selectedCategory.CategoryId = categoryForm.categoryDetail.CategoryId;
                    selectedCategory.CategoryName = categoryForm.categoryDetail.CategoryName;
                    CategoriesDB.SaveCategories(categoryList);
                    populateList();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            var filteredCategory = categoryList.Where(category => category.CategoryName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            filterList(filteredCategory);
        }

        public void filterList(List<CategoriesOld> categories)
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

            ListViewItem selectedItem = listViewCategory.SelectedItems[0];
            int categoryId = int.Parse(selectedItem.SubItems[0].Text);
            CategoriesOld selectedCategory = categoryList.FirstOrDefault(b => b.CategoryId == categoryId);

            if (selectedCategory == null)
            {
                MessageBox.Show("Category not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete " + selectedCategory.CategoryName + " ?",
                                               "Confirm",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                categoryList.Remove(selectedCategory);
                CategoriesDB.SaveCategories(categoryList);
                populateList();
            }
        }
    }
}
