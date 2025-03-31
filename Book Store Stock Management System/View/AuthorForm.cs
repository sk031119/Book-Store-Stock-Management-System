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
    public partial class AuthorForm : Form
    {
        public AuthorOld AuthorDetail;
        private bool isNew;

        public AuthorForm()
        {
            InitializeComponent();
            isNew = true;
        }

        public AuthorForm(AuthorOld author) : this()
        {
            AuthorDetail = author;
            txtFName.Text = author.FName;
            txtLName.Text = author.LName;
            isNew = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (isNew)
                {
                    AuthorDetail = new AuthorOld();
                }

                AuthorDetail.FName = txtFName.Text;
                AuthorDetail.LName = txtLName.Text;

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
            if (string.IsNullOrWhiteSpace(txtFName.Text))
            {
                MessageBox.Show("Please enter the first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Please enter the last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
