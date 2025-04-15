using Book_Store_Stock_Management_System.View;

namespace Book_Store_Stock_Management_System
{
    public partial class Dashboard : Form
    {
        private string loggedInUser;
        private UserRole userRole;

        public Dashboard(String username, UserRole role)
        {
            InitializeComponent();

            // Set user detail
            loggedInUser = username;
            userRole = role;

            // Config based on role
            lblWelcome.Text = "Welcome, " + username + "!";
            configureTabs();
        }
        private void configureTabs()
        {
            // Adding controls to tabs
            BookTab booksTab = new BookTab();
            booksTab.Dock = DockStyle.Fill;
            tabBooks.Controls.Add(booksTab);

            AuthorsTab authorsTab = new AuthorsTab();
            authorsTab.Dock = DockStyle.Fill;
            tabAuthors.Controls.Add(authorsTab);

            PublisherTab publishersTab = new PublisherTab();
            publishersTab.Dock = DockStyle.Fill;
            tabPublishers.Controls.Add(publishersTab);

            CategoriesTab categoriesTab = new CategoriesTab();
            categoriesTab.Dock = DockStyle.Fill;
            tabCategory.Controls.Add(categoriesTab);

            UsersTab usersTab = new UsersTab();
            usersTab.Dock = DockStyle.Fill;
            tabUsers.Controls.Add(usersTab);

            // Removing tabs based on role
            if (userRole == UserRole.EMPLOYEE)
            {
                tabControl.TabPages.Remove(tabUsers);
            }
            else if (userRole == UserRole.GUEST)
            {
                tabControl.TabPages.Remove(tabAuthors);
                tabControl.TabPages.Remove(tabPublishers);
                tabControl.TabPages.Remove(tabCategory);
                tabControl.TabPages.Remove(tabUsers);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure to logout? ",
                                               "Confirm",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
