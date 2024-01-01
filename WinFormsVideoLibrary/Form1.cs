using Domain;
using Domain.BaseTypes;
using UnitOfWorkNamespace;

namespace WinFormsVideoLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var movieForm = new MoviesForm();
            movieForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UnitOfWork UoW = Program.UnitOfWork;

            var genre1 = new Genre() { Name = "Драма" };
            var genre2 = new Genre() { Name = "Триллер" };
            var genre3 = new Genre() { Name = "Фантастика" };
            var genre4 = new Genre() { Name = "Мелодрама" };
            var genre5 = new Genre() { Name = "Детектив" };
            var genre6 = new Genre() { Name = "Ужас" };
            var genre7 = new Genre() { Name = "Комедия" };
            var genre8 = new Genre() { Name = "Мистика" };
            var genre9 = new Genre() { Name = "Приключения" };

            UoW.GenreRepository.CreateEntity(genre1);
            UoW.GenreRepository.CreateEntity(genre2);
            UoW.GenreRepository.CreateEntity(genre3);
            UoW.GenreRepository.CreateEntity(genre4);
            UoW.GenreRepository.CreateEntity(genre5);
            UoW.GenreRepository.CreateEntity(genre6);
            UoW.GenreRepository.CreateEntity(genre7);
            UoW.GenreRepository.CreateEntity(genre8);
            UoW.GenreRepository.CreateEntity(genre9);

            var prod1 = new Producer() { Name = "Иван Пупкин"};
            var prod2 = new Producer() { Name = "Карина Валеро"};
            var prod3 = new Producer() { Name = "Жан Фатон"};

            UoW.ProducerRepository.CreateEntity(prod1);
            UoW.ProducerRepository.CreateEntity(prod2);
            UoW.ProducerRepository.CreateEntity(prod3);

            UoW.MovieRepository.CreateEntity(new Movie() { Name = "Пришельцы против Гоблинов", Genre = genre1, Description = "Lorem ipsum jfjf fjfjf oeoe", Producer = prod1 });
            UoW.MovieRepository.CreateEntity(new Movie() { Name = "Гоблинский фильм", Genre = genre1, Description = "Lorem ipsum jfjf fjfjf oeoe", Producer = prod1 });
            UoW.MovieRepository.CreateEntity(new Movie() { Name = "Рандом", Genre = genre3, Description = "Lorem ipsumjf fjfjf oeoe", Producer = prod3 });

            UoW.UserRepository.CreateEntity(new User() { Name = "Артур Заборович", Age = 26 });
            UoW.UserRepository.CreateEntity(new User() { Name = "Картон Аль Махиб", Age = 12 });
            UoW.UserRepository.CreateEntity(new User() { Name = "Кирилл Трактирович", Age = 32 });
            UoW.UserRepository.CreateEntity(new User() { Name = "Фортун Рихтер", Age = 19 });
            UoW.UserRepository.CreateEntity(new User() { Name = "Иван Чекан", Age = 19 });

            UoW.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            usersForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var subscriptionControlForm = new SubscriptionControlForm();
            subscriptionControlForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var producersForm = new ProducersForm();
            producersForm.Show();
        }
    }
}