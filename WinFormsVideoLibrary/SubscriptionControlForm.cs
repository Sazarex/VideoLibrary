using Domain;
using UnitOfWorkNamespace;

namespace WinFormsVideoLibrary
{
    public partial class SubscriptionControlForm : Form
    {
        private UnitOfWork UoW = Program.UnitOfWork;
        private User user = null;
        private DateTime nowDate = DateTime.Now;

        public SubscriptionControlForm()
        {
            InitializeComponent();

        }

        private void validUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userTextBox.Text))
            {
                MessageBox.Show("Пустое поле с Ф.И.О. пользователя.", "Ошибка поиска пользователя");
                return;
            }

            var userFromDb = UoW.UserRepository.GetByCondition(u => u.Name.ToLower() == userTextBox.Text.ToLower()).FirstOrDefault();

            if (ValidateUser(userFromDb))
                user = userFromDb;
            else
                user = null;
        }

        private bool ValidateUser(User user)
        {
            if (user == null)
            {
                MessageBox.Show("Такого пользователя не существует.", "Ошибка поиска пользователя");
                isValidUser.ForeColor = Color.Red;
                isValidUser.Text = "Пользователь не выбран";
                return false;
            }
            else
            {
                isValidUser.ForeColor = Color.Green;
                isValidUser.Text = "Пользователь выбран";
                return true;
            }

        }

        private void createMonthlySubscription_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Пользователь на выбран или такого пользователя не существует.", "Ошибка оформления подписки");
                return;
            }

            //var subscriptionCreateDate = GenerateSubscriptionCreateDate(user);
            //var subscriptionEndDate = subscriptionCreateDate.AddMonths(1);

            //Subscription subscription = new Subscription()
            //{
            //    CreationDate = subscriptionCreateDate,
            //    EndDate = subscriptionEndDate
            //};

            //subscription.Payment = new Payment();
            //user.Subscription = subscription;

            GenerateSubscription(1, nowDate);

            MessageBox.Show("Подписка была успешно оформлена на месяц.", "Оформление подписки");
        }

        private DateTime GenerateSubscriptionCreateDate(User user, DateTime startDate)
        {
            if (user.Subscription != null)
            {
                var lastEndDate = user.Subscription.EndDate < startDate ? startDate : user.Subscription.EndDate;
                return lastEndDate.GetValueOrDefault();
            }
            else
                return nowDate;
        }

        private void GenerateSubscription(int months, DateTime startDate)
        {
            var subscriptionCreateDate = GenerateSubscriptionCreateDate(user, startDate);
            var subscriptionEndDate = subscriptionCreateDate.AddMonths(months);

            Subscription subscription = new Subscription()
            {
                Name = "Подписка: " + user.Name + " от " + subscriptionCreateDate + ", до " + subscriptionEndDate,
                CreationDate = subscriptionCreateDate,
                EndDate = subscriptionEndDate
            };

            subscription.Payment = new Payment()
            {
                CreationDate = nowDate
            };

            user.Subscription = subscription;

            UoW.Save();
        }

    }
}
