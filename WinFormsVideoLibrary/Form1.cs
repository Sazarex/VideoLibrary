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
            //UnitOfWork UoW = Program.UnitOfWork;

            //var genre1 = new Genre() { Name = "Драмма" };
            //var genre2 = new Genre() { Name = "Триллер" };
            //var genre3 = new Genre() { Name = "Фантастика" };

            //UoW.GenreRepository.CreateEntity(genre1);
            //UoW.GenreRepository.CreateEntity(genre2);
            //UoW.GenreRepository.CreateEntity(genre3);

            //var prod1 = new Producer() { Name = "Иван Пупкин", EntityState = EntityState.Active };
            //var prod2 = new Producer() { Name = "Карина Валеро", EntityState = EntityState.Active };
            //var prod3 = new Producer() { Name = "Жан Фатон", EntityState = EntityState.Active };

            //UoW.ProducerRepository.CreateEntity(prod1);
            //UoW.ProducerRepository.CreateEntity(prod2);
            //UoW.ProducerRepository.CreateEntity(prod3);

            //UoW.MovieRepository.CreateEntity(new Movie() { Name = "Пришельцы против Гоблинов", Genre = genre1, Description = "Lorem ipsum jfjf fjfjf oeoe", Producer = prod1 });
            //UoW.MovieRepository.CreateEntity(new Movie() { Name = "Гоблинский фильм", Genre = genre1, Description = "Lorem ipsum jfjf fjfjf oeoe", Producer = prod1 });
            //UoW.MovieRepository.CreateEntity(new Movie() { Name = "Рандом", Genre = genre3, Description = "Lorem ipsumjf fjfjf oeoe", Producer = prod3 });

            //UoW.Save();
        }
    }
}