using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


            // Removing tabs based on role
            if (userRole == UserRole.User)
            {
                tabControl.TabPages.Remove(tabReports);
                tabControl.TabPages.Remove(tabEmployees);
            }
            else if (userRole == UserRole.Guest)
            {
                tabControl.TabPages.Remove(tabAuthors);
                tabControl.TabPages.Remove(tabPublishers);
                tabControl.TabPages.Remove(tabCategory);
                tabControl.TabPages.Remove(tabReports);
                tabControl.TabPages.Remove(tabEmployees);
            }
        }
    }
}
