using System;
using Book_Store_Stock_Management_System.Controller;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class AuthorsTab : UserControl
    {
        public AuthorsTab()
        {
            InitializeComponent();
            LoadAuthors();
        }

        private void LoadAuthors()
        {
            List<Author> authors = AuthorDB.GetAuthors();
            PopulateList(authors);
        }

        private void PopulateList(List<Author> authors)
        {
            listViewAuthors.Items.Clear();

            var items = authors.Select(author => new ListViewItem(author.FirstName)
            {
                SubItems = { author.LastName }
            }).ToArray();

            listViewAuthors.Items.AddRange(items);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (AuthorForm authorForm = new AuthorForm())
            {
                if (authorForm.ShowDialog() == DialogResult.OK)
                {
                    Author newAuthor = authorForm.AuthorDetail;
                    AuthorDB.AddAuthor(newAuthor);
                    LoadAuthors();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewAuthors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose an author to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewAuthors.SelectedItems[0];
            string firstName = selectedItem.SubItems[0].Text;
            string lastName = selectedItem.SubItems[1].Text;

            List<Author> authors = AuthorDB.GetAuthors();
            Author selectedAuthor = authors.FirstOrDefault(a => a.FirstName == firstName && a.LastName == lastName);

            if (selectedAuthor == null)
            {
                MessageBox.Show("Author not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AuthorForm authorForm = new AuthorForm(selectedAuthor))
            {
                if (authorForm.ShowDialog() == DialogResult.OK)
                {
                    selectedAuthor.FirstName = authorForm.AuthorDetail.FirstName;
                    selectedAuthor.LastName = authorForm.AuthorDetail.LastName;
                    AuthorDB.UpdateAuthor(selectedAuthor);
                    LoadAuthors();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            List<Author> authors = AuthorDB.SearchAuthors(name);
            PopulateList(authors);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewAuthors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose an author to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewAuthors.SelectedItems[0];
            string firstName = selectedItem.SubItems[0].Text;
            string lastName = selectedItem.SubItems[1].Text;

            List<Author> authors = AuthorDB.GetAuthors();
            Author selectedAuthor = authors.FirstOrDefault(a => a.FirstName == firstName && a.LastName == lastName);

            if (selectedAuthor == null)
            {
                MessageBox.Show("Author not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete " + selectedAuthor.FirstName + " " + selectedAuthor.LastName + " ?",
                                               "Confirm",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string errorMessage;
                bool success = AuthorDB.DeleteAuthor(selectedAuthor.AuthorId, out errorMessage);

                if (!success)
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadAuthors();
            }
        }

        private void AuthorsTab_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }
    }
}
