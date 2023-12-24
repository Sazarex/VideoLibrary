using Domain;
using Microsoft.VisualBasic.Devices;
using UnitOfWorkNamespace;

namespace WinFormsVideoLibrary
{
    public partial class MovieForm : Form
    {
        private UnitOfWork UoW = Program.UnitOfWork;
        private Movie _movie = null;

        public MovieForm()
        {
            InitializeComponent();

        }


        public MovieForm(int movieId)
        {
            InitializeComponent();

            Movie movie = UoW.MovieRepository.GetEntity(movieId);

            if (movie != null)
            {
                _movie = movie;
                nameTextBox.Text = movie.Name;
                genreTextBox.Text = movie.Genre.Name;
                producerTextBox.Text = movie.Producer.Name;
                descriptionTextBox.Text = movie.Description;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _movie.Name = nameTextBox.Text;

            Genre newGenre = UoW.GenreRepository.GetByCondition(g => g.Name == genreTextBox.Text).FirstOrDefault();
            if (newGenre == null)
                MessageBox.Show("Такого жанра не существует","Ошибка в сохранении");
            else
                _movie.Genre = newGenre;

            Producer newProducer = UoW.ProducerRepository.GetByCondition(g => g.Name == producerTextBox.Text).FirstOrDefault();
            if (newProducer == null)
                MessageBox.Show("Такого режиссера не существует","Ошибка в сохранении");
            else
                _movie.Producer = newProducer;
            _movie.Description = descriptionTextBox.Text;
            UoW.Save();

        }
    }
}
