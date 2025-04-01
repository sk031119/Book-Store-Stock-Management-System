using Book_Store_Stock_Management_System.Controller;
using Book_Store_Stock_Management_System.Models;

namespace Book_Store_Stock_Management_System
{
    public partial class UserForm : Form
    {
        public User userDetail;
        private bool isNew = true;
        private ErrorProvider errorProvider = new ErrorProvider();
    }
}
