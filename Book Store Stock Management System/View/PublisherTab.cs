using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Store_Stock_Management_System.Controller;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class PublisherTab : UserControl
    {
        public PublisherTab()
        {
            InitializeComponent();
            LoadPublishers();
        }

        private void LoadPublishers()
        {
            List<Publisher> publishers = PublisherDB.GetPublishers();
            PopulateList(publishers);
        }

        private void PopulateList(List<Publisher> publishers)
        {
            listViewPublishers.Items.Clear();

            var items = publishers.Select(publisher => new ListViewItem(publisher.Name)
            {
                SubItems = { publisher.Address, publisher.Phone, publisher.ContactPerson }
            }).ToArray();

            listViewPublishers.Items.AddRange(items);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (PublisherForm publisherForm = new PublisherForm())
            {
                if (publisherForm.ShowDialog() == DialogResult.OK)
                {
                    Publisher newPublisher = publisherForm.PublisherDetail;
                    PublisherDB.AddPublisher(newPublisher);
                    LoadPublishers();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewPublishers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a publisher to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewPublishers.SelectedItems[0];
            string name = selectedItem.SubItems[0].Text;
            string address = selectedItem.SubItems[1].Text;
            string phone = selectedItem.SubItems[2].Text;

            List<Publisher> publishers = PublisherDB.GetPublishers();
            Publisher selectedPublisher = publishers.FirstOrDefault(p => p.Name == name && p.Address == address && p.Phone == phone);

            if (selectedPublisher == null)
            {
                MessageBox.Show("Publisher not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (PublisherForm publisherForm = new PublisherForm(selectedPublisher))
            {
                if (publisherForm.ShowDialog() == DialogResult.OK)
                {
                    selectedPublisher.Name = publisherForm.PublisherDetail.Name;
                    selectedPublisher.Address = publisherForm.PublisherDetail.Address;
                    selectedPublisher.Phone = publisherForm.PublisherDetail.Phone;
                    selectedPublisher.ContactPerson = publisherForm.PublisherDetail.ContactPerson;
                    PublisherDB.UpdatePublisher(selectedPublisher);
                    LoadPublishers();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            List<Publisher> publishers = PublisherDB.SearchPublishers(searchText);
            PopulateList(publishers);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewPublishers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a publisher to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = listViewPublishers.SelectedItems[0];
            string name = selectedItem.SubItems[0].Text;
            string address = selectedItem.SubItems[1].Text;
            string phone = selectedItem.SubItems[2].Text;

            List<Publisher> publishers = PublisherDB.GetPublishers();
            Publisher selectedPublisher = publishers.FirstOrDefault(p => p.Name == name && p.Address == address && p.Phone == phone);

            if (selectedPublisher == null)
            {
                MessageBox.Show("Publisher not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete " + selectedPublisher.Name + "?",
                                               "Confirm",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                PublisherDB.DeletePublisher(selectedPublisher.PublisherId, out string errorMessage);
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadPublishers();
            }
        }

        private void PublisherTab_Load(object sender, EventArgs e)
        {
            LoadPublishers();
        }
    }
}