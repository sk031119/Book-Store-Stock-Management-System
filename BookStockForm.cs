namespace Book_Store_Stock_Management_System
{
    public partial class BookStockForm : Form
    {
        private string? loggedInUserName;
        private List<KeyValuePair<string, string>> userCredentials;

        public BookStockForm()
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
                    MessageBox.Show("Login successful!");
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
            }
            else
            {
                loginStatusLabel.Text = "Logged out";
            }
        }
    }
}
