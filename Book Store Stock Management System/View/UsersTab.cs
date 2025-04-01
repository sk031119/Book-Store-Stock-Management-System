using System.Data;
using Book_Store_Stock_Management_System.Controller;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System.View
{
    public partial class UsersTab : UserControl
    {
        private List<User> userList = new List<User>();

        public UsersTab()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            userList = UsersDB.GetUsers();
            PopulateList();
        }

        private void PopulateList()
        {
            listVwBooks.Items.Clear();

            foreach (var user in userList)
            {
                var item = new ListViewItem(user.UserId.ToString());
                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.Role);
                listVwBooks.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (UserForm form = new UserForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UsersDB.AddUser(form.userDetail);
                    LoadUsers();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listVwBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            int userId = int.Parse(listVwBooks.SelectedItems[0].SubItems[0].Text);
            User selected = userList.First(u => u.UserId == userId);

            using (UserForm form = new UserForm(selected))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UsersDB.UpdateUser(form.userDetail);
                    LoadUsers();
                }
            }
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            if (listVwBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to change password.");
                return;
            }

            int userId = int.Parse(listVwBooks.SelectedItems[0].SubItems[0].Text);
            using (ChangePassForm form = new ChangePassForm(userId))
            {
                form.ShowDialog();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listVwBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userId = int.Parse(listVwBooks.SelectedItems[0].SubItems[0].Text);
            string username = listVwBooks.SelectedItems[0].SubItems[1].Text;

            DialogResult result = MessageBox.Show($"Are you sure to delete {username}?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UsersDB.DeleteUser(userId);
                LoadUsers();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var filtered = userList.Where(u => u.Username.ToLower().Contains(keyword)).ToList();

            listVwBooks.Items.Clear();
            foreach (var user in filtered)
            {
                var item = new ListViewItem(user.UserId.ToString());
                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.Role);
                listVwBooks.Items.Add(item);
            }
        }
    }
}
