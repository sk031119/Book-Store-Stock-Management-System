using Book_Store_Stock_Management_System.Controller;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System.View
{
    public partial class UserForm : Form
    {
        public User userDetail;
        private bool isNew = true;
        private ErrorProvider errorProvider = new ErrorProvider();

        public UserForm()
        {
            InitializeComponent();
            isNew = true;
            populateRoles();

            textId.Enabled = false; // identity
            textPassword.Visible = true;
        }

        public UserForm(User user)
        {
            InitializeComponent();
            isNew = false;
            populateRoles();

            userDetail = user;

            textId.Text = user.UserId.ToString();
            textUsername.Text = user.Username;
            comboRole.SelectedItem = user.Role;

            textId.Enabled = false;
            textPassword.Visible = false; // don't show password on edit

            buttonSave.Click += buttonSave_Click;
            buttonClear.Click += buttonClear_Click;
        }

        private void populateRoles()
        {
            comboRole.DataSource = Enum.GetNames(typeof(UserRole));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!validateFields()) return;

            userDetail = userDetail ?? new User();
            userDetail.Username = textUsername.Text.Trim();
            userDetail.Role = comboRole.SelectedItem.ToString();

            if (isNew)
                userDetail.Password = textPassword.Text.Trim();

            MessageBox.Show(isNew ? "User successfully added!" : "User successfully updated.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            comboRole.SelectedIndex = -1;

            if (isNew)
                textPassword.Clear();
        }

        private bool validateFields()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(textUsername.Text))
            {
                errorProvider.SetError(textUsername, "Enter a username!");
                return false;
            }

            if (UsersDB.UsernameExists(textUsername.Text.Trim(), isNew ? null : userDetail?.UserId))
            {
                errorProvider.SetError(textUsername, "This username is already taken.");
                return false;
            }

            if (comboRole.SelectedItem == null)
            {
                errorProvider.SetError(comboRole, "Select a role!");
                return false;
            }

            if (isNew && string.IsNullOrWhiteSpace(textPassword.Text))
            {
                errorProvider.SetError(textPassword, "Enter a password!");
                return false;
            }

            return true;
        }
    }
}
