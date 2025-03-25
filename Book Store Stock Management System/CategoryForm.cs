using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Store_Stock_Management_System
{
    public partial class CategoryForm : Form
    {


        public Categories categoryDetail;
        Boolean isNew = true;

        private ErrorProvider errorProvider = new ErrorProvider();
        public CategoryForm()
        {
            InitializeComponent();
        }
        public CategoryForm(Categories category)
        {
            InitializeComponent();

            this.isNew = false;
        
            categoryDetail = category;
            txtId.Text = category.CategoryId.ToString();
            txtName.Text = category.CategoryName;          
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validating inputs
                if (validateFields())
                {
                    // Adding to list
                    this.categoryDetail = new Categories
                    {
                        CategoryId = int.Parse(txtId.Text),
                        CategoryName = txtName.Text,                      
                    };
                    MessageBox.Show(isNew ? "Successfully added" : "Successfully updated");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private Boolean validateFields()
        {
            // Clear previous error messages
            errorProvider.Clear(); 

            // Count
            int idVal = 0;
            if (string.IsNullOrEmpty(txtId.Text))
            {
                errorProvider.SetError(txtId, "Enter the ID!");
                return false;
            }
            else if (!int.TryParse(txtId.Text, out idVal) || idVal <= 0)
            {
                errorProvider.SetError(txtId, "ID should be more than 0!");
                return false;
            }

            // Title
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider.SetError(txtName, "Enter the name!");
                return false;
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