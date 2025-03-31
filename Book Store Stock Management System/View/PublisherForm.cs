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
    public partial class PublisherForm : Form
    {
        public PublisherOld PublisherDetail;
        private bool isNew;
        private ErrorProvider errorProvider = new ErrorProvider();

        public PublisherForm()
        {
            InitializeComponent();
            isNew = true;
        }

        public PublisherForm(PublisherOld publisher) : this()
        {
            PublisherDetail = publisher;
            txtName.Text = publisher.Name;
            txtAddress.Text = publisher.Address;
            txtPhone.Text = publisher.Phone;
            txtContactPerson.Text = publisher.ContactPerson;
            isNew = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (isNew)
                {
                    PublisherDetail = new PublisherOld();
                }

                PublisherDetail.Name = txtName.Text;
                PublisherDetail.Address = txtAddress.Text;
                PublisherDetail.Phone = txtPhone.Text;
                PublisherDetail.ContactPerson = txtContactPerson.Text;

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

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Please enter the publisher name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, "Please enter the address.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Please enter the phone number.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContactPerson.Text))
            {
                errorProvider.SetError(txtContactPerson, "Please enter the contact person.");
                return false;
            }

            return true;
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            // 可以添加初始化代碼
        }
    }
}
