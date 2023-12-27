using Domain;
using Microsoft.EntityFrameworkCore;
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
    }
}
