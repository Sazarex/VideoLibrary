using Domain;
using UnitOfWorkNamespace;
using WinFormsVideoLibrary.Dto;
using WinFormsVideoLibrary.Services;

namespace WinFormsVideoLibrary
{
    public partial class UserForm : Form
    {
        private UnitOfWork UoW = Program.UnitOfWork;
        private User _user = null;
        private int? entityId = null;
        public UserForm()
        {
            InitializeComponent();

            label9.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            subscriptionEndDateLabel.Visible = false;
            subscriptionStartDateLabel.Visible = false;
            subscriptionState.Visible = false;

        }

        public UserForm(int userId)
        {
            InitializeComponent();

            EntityInfoService entityInfoService = new EntityInfoService();
            var userDto = entityInfoService.LoadEntityInfoAsync<User, UserDto>(userId);

            if (userDto != null)
            {
                entityId = userDto.Id;
                nameTextBox.Text = userDto.Name;
                numericUpDown1.Value = userDto.Age;
                subscriptionStartDateLabel.Text = userDto.SubscriptionCreationDate.ToString();
                subscriptionEndDateLabel.Text = userDto.SubscriptionEndDate.ToString();
                deleteButton.Visible = true;
                subscriptionState.Text = userDto.SubscriptionStatus;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entityId == null)
                _user = new User();
            else
                _user = UoW.UserRepository.GetEntity(entityId.GetValueOrDefault());

            if (nameTextBox.Text == null)
                MessageBox.Show("Пустое значение Ф.И.О.", "Ошибка в сохранении");
            else
                _user.Name = nameTextBox.Text;

            if (numericUpDown1.Value <= 0)
                MessageBox.Show("Пустое значение возраста", "Ошибка в сохранении");
            else
                _user.Age = Convert.ToInt32(numericUpDown1.Value);



            if (numericUpDown1.Value > 0 && nameTextBox.Text != null)
            {
                if (entityId == null)
                {
                    UoW.UserRepository.CreateEntity(_user);
                    UoW.Save();
                }
                else
                    UoW.Save();

                MessageBox.Show("Успешно сохранено.", "Cохранение");

                this.Close();
            }
            else
                MessageBox.Show("Ошибка валидации.", "Ошибка сохранения");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (entityId != null)
            {
                UoW.UserRepository.Delete(entityId.GetValueOrDefault());
                UoW.Save();
                MessageBox.Show("Успешно удалено.", "Удаление");
                this.Close();
            }
        }
    }
}
