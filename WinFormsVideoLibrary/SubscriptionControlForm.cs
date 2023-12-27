using Domain;
using UnitOfWorkNamespace;

namespace WinFormsVideoLibrary
{
    public partial class SubscriptionControlForm : Form
    {
        private readonly DateTime minDateTimePickerDate = new DateTime(2000, 1, 1);

        private UnitOfWork UoW = Program.UnitOfWork;
        private User user;
        private DateTime nowDate = DateTime.Now;

        public SubscriptionControlForm()
        {
            InitializeComponent();
            ResetFormValues();
        }

        private void validUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userTextBox.Text))
            {
                MessageBox.Show("Пустое поле с Ф.И.О. пользователя.", "Ошибка поиска пользователя");
                return;
            }

            var userFromDb = UoW.UserRepository.GetEntityByCondition(u => u.Name.ToLower() == userTextBox.Text.ToLower(), u => u.Subscription);

            if (ValidateUser(userFromDb))
                user = userFromDb;
            else
                user = null;
        }

        private bool ValidateUser(User user)
        {
            nowDate = DateTime.Now;

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

                createSubscription.Enabled = true;
                createMonthlySubscription.Enabled = true;
                //startDateTimePicker.Enabled = true;
                monthCounter.Enabled = true;


                if (user.Subscription != null)
                {
                    subscriptionStartDateLabel.Text = user.Subscription?.CreationDate.GetValueOrDefault().ToString();
                    subscriptionEndDateLabel.Text = user.Subscription?.EndDate.GetValueOrDefault().ToString();

                    ChangeSubscriptionInfo(IsHaveActualSubscription(user));
                }
                else
                {
                    subscriptionStartDateLabel.Text = null;
                    subscriptionEndDateLabel.Text = null;
                    ChangeSubscriptionInfo(false);
                }

                startDateTimePicker.Value = GenerateSubscriptionEndDate(user, nowDate);
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

            var newStartDate = IsHaveActualSubscription(user) ? user.Subscription.CreationDate.GetValueOrDefault() : nowDate;
            GenerateSubscription(1, newStartDate);
        }

        private DateTime GenerateSubscriptionCreateDate(User user, DateTime startDate)
        {
            if (IsHaveActualSubscription(user))
            {
                var lastEndDate = user.Subscription.CreationDate;
                return lastEndDate.GetValueOrDefault();
            }

            return startDate;
        }

        private DateTime GenerateSubscriptionEndDate(User user, DateTime startDate)
        {
            if (user.Subscription != null)
            {
                var lastEndDate = user.Subscription.EndDate < startDate ? startDate : user.Subscription.EndDate;
                return lastEndDate.GetValueOrDefault();
            }
            else
                return startDate;
        }

        private void GenerateSubscription(int months, DateTime startDate)
        {
            var subscriptionCreateDate = GenerateSubscriptionCreateDate(user, startDate);

            DateTime dateToCalculateEndDate;
            if (IsHaveActualSubscription(user))
                dateToCalculateEndDate = user.Subscription.EndDate.GetValueOrDefault();
            else
                dateToCalculateEndDate = subscriptionCreateDate;

            var subscriptionEndDate = GenerateSubscriptionEndDate(user, dateToCalculateEndDate).AddMonths(months);

            Subscription newSubscription = new Subscription()
            {
                Name = "Подписка: " + user.Name + " от " + subscriptionCreateDate + ", до " + subscriptionEndDate,
                CreationDate = subscriptionCreateDate,
                EndDate = subscriptionEndDate
            };

            newSubscription.Payment = new Payment()
            {
                CreationDate = nowDate
            };

            if (user.Subscription != null)
            {
                int oldSubscriptionId = user.Subscription.Id;
                UoW.SubscriptionRepository.Delete(oldSubscriptionId);
            }

            user.Subscription = newSubscription;

            UoW.Save();

            ResetFormValues();
            MessageBox.Show("Подписка была успешно оформлена на " + months + " месяц(ев).", "Оформление подписки");

        }

        private void ResetFormValues()
        {
            user = null;
            userTextBox.Text = "";
            isValidUser.Text = "";

            createSubscription.Enabled = false;
            createMonthlySubscription.Enabled = false;
            startDateTimePicker.Enabled = false;
            monthCounter.Enabled = false;

            subscriptionStartDateLabel.Text = null;
            subscriptionEndDateLabel.Text = null;
            startDateTimePicker.Value = user != null ? GenerateSubscriptionEndDate(user, nowDate): nowDate;

            subscriptionState.Text = null;

            cancelSubscription.Enabled = false;
        }

        private void createSubscription_Click(object sender, EventArgs e)
        {
            if (monthCounter.Value <= 0)
            {
                MessageBox.Show("Количество оплачиваемых месяцев не выбрано.", "Ошибка оформления подписки");
                return;
            }

            int monthCount = Convert.ToInt32(monthCounter.Value);
            DateTime startSubscription = startDateTimePicker.Value;
            GenerateSubscription(monthCount, startSubscription);
        }

        private void cancelSubscription_Click(object sender, EventArgs e)
        {
            if (user == null)
                return;

            if (IsHaveActualSubscription(user))
            {
                int subscriptionIdToDelete = user.Subscription.Id;
                UoW.SubscriptionRepository.Delete(subscriptionIdToDelete);
                UoW.Save();


                subscriptionStartDateLabel.Text = null;
                subscriptionEndDateLabel.Text = null;

                startDateTimePicker.Value = nowDate;

                ChangeSubscriptionInfo(false);
                MessageBox.Show("Подписка у пользователя " + user.Name + " отменена.", "Отмена подписки.");
            }

        }



        private bool IsHaveActualSubscription(User user)
        {
            if (user.Subscription == null)
                return false;

            return user.Subscription.CreationDate.GetValueOrDefault() < nowDate && user.Subscription.EndDate.GetValueOrDefault() > nowDate;
        }

        private void ChangeSubscriptionInfo(bool isActualSubscription)
        {
            var isActiveText = "Активна";
            var isNotActiveText = "Неактивна";

            subscriptionState.Text = isActualSubscription ? isActiveText : isNotActiveText;
            cancelSubscription.Enabled = isActualSubscription;
        }

    }
}
