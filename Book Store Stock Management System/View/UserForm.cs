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

            labelPass.Visible = true;
            textPassword.Visible = true;
            labelConfirmPass.Visible = true;
            textConfirmPass.Visible = true;
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

            // don't show password on edit
            textPassword.Visible = false;
            labelPass.Visible = false;
            labelConfirmPass.Visible = false;
            textConfirmPass.Visible = false;
        }

        private void populateRoles()
        {
            comboRole.DataSource = Enum.GetNames(typeof(UserRole));
            comboRole.SelectedIndex = -1;
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

            // Password format validation
            if (isNew)
            {
                string password = textPassword.Text;
                string confirm = textConfirmPass.Text;

                if (string.IsNullOrWhiteSpace(password))
                {
                    errorProvider.SetError(textPassword, "Enter password!");
                    return false;
                }

                if (password.Length < 6 ||
                    !password.Any(char.IsUpper) ||
                    !password.Any(char.IsLower) ||
                    !password.Any(char.IsDigit))
                {
                    errorProvider.SetError(textPassword, "Password must be at least 6 characters and contain upper, lower, and a number.");
                    return false;
                }

                if (password != confirm)
                {
                    errorProvider.SetError(textConfirmPass, "Passwords do not match!");
                    return false;
                }
            }

            return true;
        }
    }
}
