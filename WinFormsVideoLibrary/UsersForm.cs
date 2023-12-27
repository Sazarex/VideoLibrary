using Domain;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using UnitOfWorkNamespace;
using WinFormsVideoLibrary.Dto;
using WinFormsVideoLibrary.Services;

namespace WinFormsVideoLibrary
{
    public partial class UsersForm : Form
    {
        private UnitOfWork UoW = Program.UnitOfWork;
        LoadDataGridService<User, UsersListDto> loadDataGridService = new LoadDataGridService<User, UsersListDto>();

        public UsersForm()
        {
            InitializeComponent();

            loadDataGridService.LoadDataGridAsync(usersDataGrid, UoW.UserRepository.GetAll().Include(m => m.Subscription).ToList());
        }

        private void search_Click(object sender, EventArgs e)
        {
            var query = UoW.UserRepository.GetAll();


            if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                query = query.Where(m => m.Name.Contains(nameTextBox.Text));
            }

            var now = DateTime.Now;
            if (isActive.Checked)
            {
                query = query.Include(u => u.Subscription).Where(m => m.Subscription != null &&
                (m.Subscription.CreationDate < now && m.Subscription.EndDate > now));
            }

            if (isNotActive.Checked)
            {
                query = query.Include(u => u.Subscription).Where(m => !(m.Subscription != null &&
                (m.Subscription.CreationDate < now && m.Subscription.EndDate > now)));
            }


            loadDataGridService.LoadDataGridAsync(usersDataGrid, query.ToList());
        }

        private bool IsActiveSubscription(User user)
        {
            DateTime now = DateTime.Now;
            return user.Subscription != null &&
                (user.Subscription.CreationDate < now && user.Subscription.EndDate > now);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadDataGridService.LoadDataGridAsync(usersDataGrid, UoW.UserRepository.GetAll().Include(m => m.Subscription).ToList());
        }

        private void isActive_CheckedChanged(object sender, EventArgs e)
        {
            if (isActive.Checked && isNotActive.Checked)
                isNotActive.Checked = false;
        }

        private void isNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (isActive.Checked && isNotActive.Checked)
                isActive.Checked = false;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void usersDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var cellValue = usersDataGrid.Rows[e.RowIndex].Cells[3].Value;

            if (cellValue is int userId && userId != 0)
            {
                UserForm userForm = new UserForm(userId);
                userForm.Show();
            }
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }
    }
}
