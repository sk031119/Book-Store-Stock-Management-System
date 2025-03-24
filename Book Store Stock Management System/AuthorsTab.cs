using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<Author> authors = AuthorDB.GetAuthor();
            PopulateList(authors);
        }

        private void PopulateList(List<Author> authors)
        {
            listViewAuthors.Items.Clear();

            var items = authors.Select(author => new ListViewItem(author.FName)
            {
                SubItems = { author.LName }
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
                    List<Author> authors = AuthorDB.GetAuthor();
                    authors.Add(newAuthor);
                    AuthorDB.SaveAuthor(authors);
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
            string fName = selectedItem.SubItems[0].Text;
            string lName = selectedItem.SubItems[1].Text;
            List<Author> authors = AuthorDB.GetAuthor();
            Author selectedAuthor = authors.FirstOrDefault(a => a.FName == fName && a.LName == lName);

            if (selectedAuthor == null)
            {
                MessageBox.Show("Author not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AuthorForm authorForm = new AuthorForm(selectedAuthor))
            {
                if (authorForm.ShowDialog() == DialogResult.OK)
                {
                    selectedAuthor.FName = authorForm.AuthorDetail.FName;
                    selectedAuthor.LName = authorForm.AuthorDetail.LName;
                    AuthorDB.SaveAuthor(authors);
                    LoadAuthors();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            List<Author> authors = AuthorDB.GetAuthor();
            var filteredAuthors = authors.Where(author => author.FName.Contains(name, StringComparison.OrdinalIgnoreCase) || author.LName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            PopulateList(filteredAuthors);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewAuthors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose an author to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewAuthors.SelectedItems[0];
            string fName = selectedItem.SubItems[0].Text;
            string lName = selectedItem.SubItems[1].Text;
            List<Author> authors = AuthorDB.GetAuthor();
            Author selectedAuthor = authors.FirstOrDefault(a => a.FName == fName && a.LName == lName);

            if (selectedAuthor == null)
            {
                MessageBox.Show("Author not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete " + selectedAuthor.FName + " " + selectedAuthor.LName + " ?",
                                               "Confirm",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                authors.Remove(selectedAuthor);
                AuthorDB.SaveAuthor(authors);
                LoadAuthors();
            }
        }

        private void AuthorsTab_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }
    }
}
