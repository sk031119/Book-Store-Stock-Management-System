using Book_Store_Stock_Management_System.Controller;

namespace Book_Store_Stock_Management_System.View
{
    public partial class ChangePassForm : Form
    {
        private readonly int userId;
        private readonly ErrorProvider errorProvider = new ErrorProvider();

        public ChangePassForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            LoadUserData();
        }

        private void LoadUserData()
        {
            var user = UsersDB.GetUsers().FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                textId.Text = user.UserId.ToString();
                textUsername.Text = user.Username;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidatePassword()) return;

            string newPassword = textPassword.Text.Trim();
            UsersDB.ChangePassword(userId, newPassword);

            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textPassword.Clear();
            textConfirmPass.Clear();
        }

        private bool ValidatePassword()
        {
            errorProvider.Clear();
            string password = textPassword.Text;
            string confirm = textConfirmPass.Text;

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider.SetError(textPassword, "Enter new password!");
                return false;
            }

            if (password.Length < 6 ||
                !password.Any(char.IsUpper) ||
                !password.Any(char.IsLower) ||
                !password.Any(char.IsDigit))
            {
                errorProvider.SetError(textPassword, "Password must be at least 6 characters and contain uppercase, lowercase, and digit.");
                return false;
            }

            if (password != confirm)
            {
                errorProvider.SetError(textConfirmPass, "Passwords do not match.");
                return false;
            }

            return true;
        }
    }
}
