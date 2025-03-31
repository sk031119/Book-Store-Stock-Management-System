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
            List<PublisherOld> publishers = PublisherDB.GetPublishers();
            PopulateList(publishers);
        }

        private void PopulateList(List<PublisherOld> publishers)
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
                    PublisherOld newPublisher = publisherForm.PublisherDetail;
                    List<PublisherOld> publishers = PublisherDB.GetPublishers();
                    publishers.Add(newPublisher);
                    PublisherDB.SavePublishers(publishers);
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

            List<PublisherOld> publishers = PublisherDB.GetPublishers();
            PublisherOld selectedPublisher = publishers.FirstOrDefault(p => p.Name == name && p.Address == address && p.Phone == phone);

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
                    PublisherDB.SavePublishers(publishers);
                    LoadPublishers();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            List<PublisherOld> publishers = PublisherDB.GetPublishers();
            var filteredPublishers = publishers.Where(publisher =>
                publisher.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                publisher.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                publisher.Phone.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                publisher.ContactPerson.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            PopulateList(filteredPublishers);
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

            List<PublisherOld> publishers = PublisherDB.GetPublishers();
            PublisherOld selectedPublisher = publishers.FirstOrDefault(p => p.Name == name && p.Address == address && p.Phone == phone);

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
                publishers.Remove(selectedPublisher);
                PublisherDB.SavePublishers(publishers);
                LoadPublishers();
            }
        }

        private void PublisherTab_Load(object sender, EventArgs e)
        {
            LoadPublishers();
        }
    }
}