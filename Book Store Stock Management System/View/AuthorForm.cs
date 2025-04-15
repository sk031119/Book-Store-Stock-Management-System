using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class AuthorForm : Form
    {
        public Author AuthorDetail;
        private bool isNew;
        private ErrorProvider errorProvider = new ErrorProvider();

        public AuthorForm()
        {
            InitializeComponent();
            isNew = true;
        }

        public AuthorForm(Author author) : this()
        {
            AuthorDetail = author;
            txtFName.Text = author.FirstName;
            txtLName.Text = author.LastName;
            isNew = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (isNew)
                {
                    AuthorDetail = new Author();
                }

                AuthorDetail.FirstName = txtFName.Text;
                AuthorDetail.LastName = txtLName.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateFields()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                errorProvider.SetError(txtFName, "Please enter the first name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                errorProvider.SetError(txtLName, "Please enter the last name.");
                return false;
            }

            return true;
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            // 初始化時需要執行的代碼
        }
    }
}
