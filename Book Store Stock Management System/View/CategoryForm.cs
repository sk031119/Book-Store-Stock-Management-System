using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class CategoryForm : Form
    {
        public Category categoryDetail;
        private bool isNew = true;
        private ErrorProvider errorProvider = new ErrorProvider();

        public CategoryForm()
        {
            InitializeComponent();
            isNew = true;
        }

        public CategoryForm(Category category)
        {
            InitializeComponent();
            isNew = false;

            categoryDetail = category;
            txtId.Text = category.CategoryId.ToString();
            txtName.Text = category.CategoryName;
            txtId.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!validateFields()) return;

            int id = int.Parse(txtId.Text);
            string name = txtName.Text.Trim();

            categoryDetail = categoryDetail ?? new Category();
            categoryDetail.CategoryId = id;
            categoryDetail.CategoryName = name;

            MessageBox.Show(isNew ? "Successfully added" : "Successfully updated");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool validateFields()
        {
            errorProvider.Clear();

            // ID
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int idVal) || idVal <= 0)
            {
                errorProvider.SetError(txtId, "Enter a valid ID!");
                return false;
            }

            // Name
            string name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(txtName, "Enter a category name!");
                return false;
            }

            // Checking if name is duplicated
            using (var context = new CsdbContext())
            {
                bool exists = context.Categories
                    .Any(c => c.CategoryName.ToLower() == name.ToLower()
                        && (!isNew && categoryDetail != null ? c.CategoryId != categoryDetail.CategoryId : true));

                if (exists)
                {
                    errorProvider.SetError(txtName, "This category name already exists!");
                    return false;
                }
            }

            return true;
        }

        private void clearFields()
        {
            txtId.Clear();
            txtName.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
