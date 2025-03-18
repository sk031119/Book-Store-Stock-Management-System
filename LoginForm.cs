using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Store_Stock_Management_System
{
    public partial class LoginForm : Form
    {
        private string? loggedInUserName;
        private List<KeyValuePair<string, string>> userCredentials;

        public LoginForm()
        {
            InitializeComponent();
            userCredentials = new List<KeyValuePair<string, string>>()
                        {
                            new KeyValuePair<string, string>("admin", "pwd"),
                            new KeyValuePair<string, string>("user", "password")
                        };
            UpdateLoginStatus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = maskedTxtPassword.Text;

            foreach (var credential in userCredentials)
            {
                if (credential.Key == username && credential.Value == password)
                {
                    loggedInUserName = username;
                    //MessageBox.Show("Login successful!");
                    UpdateLoginStatus();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedInUserName = null;
            MessageBox.Show("Logged out successfully!");
            UpdateLoginStatus();
        }

        private void UpdateLoginStatus()
        {
            if (loggedInUserName != null)
            {
                loginStatusLabel.Text = "Logged in as " + loggedInUserName;
                UserRole role = getUserRole();
                Dashboard dashboard = new Dashboard(loggedInUserName, role);
                this.Hide();
                dashboard.Show();
            }
            else
            {
                loginStatusLabel.Text = "Logged out";
            }
        }

        private UserRole getUserRole()
        {
            if (loggedInUserName == "admin")
                return UserRole.Admin;
            else if (loggedInUserName == "user")
                return UserRole.User;
            else
                return UserRole.Guest;
        }
    }
}
