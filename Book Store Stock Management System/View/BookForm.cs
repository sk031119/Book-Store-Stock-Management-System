using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class BookForm : Form
    {
        public Book bookDetail;
        private bool isNew = true;
        private ErrorProvider errorProvider = new ErrorProvider();

        // Dropdown data from DB
        private List<Author> authors;
        private List<Category> categories;
        private List<Publisher> publishers;
        private readonly string[] status = { "In-stock", "Low-stock", "Out-of-stock" };

        public BookForm()
        {
            InitializeComponent();
            isNew = true;
            LoadComboData();
        }

        public BookForm(Book book)
        {
            InitializeComponent();
            isNew = false;
            bookDetail = book;
            txtISBN.Enabled = false;

            // Populate combo
            LoadComboData();

            // Detail info
            txtTitle.Text = book.Title;
            txtISBN.Text = book.Isbn.ToString();
            txtPrice.Value = book.RetailPrice;
            txtCount.Value = book.StockCount;
            comboAuthor.SelectedValue = book.AuthorId;
            comboCategory.SelectedValue = book.CategoryId;
            comboPublisher.SelectedValue = book.PublisherId;
            comboStatus.SelectedItem = book.StockStatus;
        }

        private void LoadComboData()
        {
            using (var context = new CsdbContext())
            {
                authors = context.Authors.ToList();
                categories = context.Categories.ToList();
                publishers = context.Publishers.ToList();
            }

            comboAuthor.DataSource = authors;
            comboAuthor.DisplayMember = "FullName";
            comboAuthor.ValueMember = "AuthorId";

            comboCategory.DataSource = categories;
            comboCategory.DisplayMember = "CategoryName";
            comboCategory.ValueMember = "CategoryId";

            comboPublisher.DataSource = publishers;
            comboPublisher.DisplayMember = "Name";
            comboPublisher.ValueMember = "PublisherId";

            comboStatus.Items.AddRange(status);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!validateFields()) return;

            long isbn = long.Parse(txtISBN.Text);

            bookDetail = bookDetail ?? new Book();
            bookDetail.Isbn = isbn;
            bookDetail.Title = txtTitle.Text;
            bookDetail.RetailPrice = txtPrice.Value;
            bookDetail.StockCount = (int)txtCount.Value;
            bookDetail.StockStatus = comboStatus.SelectedItem.ToString();
            bookDetail.AuthorId = (int)comboAuthor.SelectedValue;
            bookDetail.CategoryId = (int)comboCategory.SelectedValue;
            bookDetail.PublisherId = (int)comboPublisher.SelectedValue;

            MessageBox.Show(isNew ? "Successfully added" : "Successfully updated");
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool validateFields()
        {
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider.SetError(txtTitle, "Enter the title!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtISBN.Text) || !long.TryParse(txtISBN.Text, out _))
            {
                errorProvider.SetError(txtISBN, "Enter a valid ISBN!");
                return false;
            }

            if (txtPrice.Value <= 0)
            {
                errorProvider.SetError(txtPrice, "Price must be greater than 0!");
                return false;
            }

            if (txtCount.Value < 0)
            {
                errorProvider.SetError(txtCount, "Stock count cannot be negative!");
                return false;
            }

            if (comboAuthor.SelectedIndex < 0 || comboCategory.SelectedIndex < 0 || comboPublisher.SelectedIndex < 0 || comboStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select all dropdown values!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtISBN.Clear();
            txtPrice.Value = 0;
            txtCount.Value = 0;
            comboAuthor.SelectedIndex = -1;
            comboCategory.SelectedIndex = -1;
            comboPublisher.SelectedIndex = -1;
            comboStatus.SelectedIndex = -1;
        }

        private void BookForm_Load(object sender, EventArgs e) { }
    }
}
