using Book_Store_Stock_Management_System.Controller;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class LoginForm : Form
    {
        private User? loggedInUser;

        public LoginForm()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = maskedTxtPassword.Text.Trim();

            var user = UsersDB.GetUsers()
                              .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                loggedInUser = user;
                UpdateLoginStatus();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateLoginStatus()
        {
            if (loggedInUser != null)
            {
                Dashboard dashboard = new Dashboard(loggedInUser.Username, GetUserRole(loggedInUser.Role));
                this.Hide();
                dashboard.Show();
            }
        }

        private UserRole GetUserRole(string dbRole)
        {
            return dbRole.ToUpper() switch
            {
                "ADMIN" => UserRole.ADMIN,
                "EMPLOYEE" => UserRole.EMPLOYEE,
                _ => UserRole.GUEST
            };
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
