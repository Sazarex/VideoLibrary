using Domain;
using UnitOfWorkNamespace;
using WinFormsVideoLibrary.Dto;
using WinFormsVideoLibrary.Services;

namespace WinFormsVideoLibrary
{
    public partial class MovieForm : Form
    {
        private UnitOfWork UoW = Program.UnitOfWork;
        private Movie _movie = null;
        private int? entityId = null;
        public MovieForm()
        {
            InitializeComponent();

        }


        public MovieForm(int movieId)
        {
            InitializeComponent();

            //Movie movie = UoW.MovieRepository.GetEntity(movieId);
            EntityInfoService entityInfoService = new EntityInfoService();
            var movieDto = entityInfoService.LoadEntityInfoAsync<Movie, MovieEntityDto>(movieId);

            if (movieDto != null)
            {
                //_movie = movieDto;
                entityId = movieDto.Id;
                nameTextBox.Text = movieDto.Name;
                genreTextBox.Text = movieDto.GenreName;
                producerTextBox.Text = movieDto.ProducerName;
                descriptionTextBox.Text = movieDto.Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entityId == null)
                return;

            _movie = UoW.MovieRepository.GetEntity(entityId.GetValueOrDefault());

            if (nameTextBox.Text == null)
                MessageBox.Show("Пустое значение наименования", "Ошибка в сохранении");
            else
                _movie.Name = nameTextBox.Text;

            Genre newGenre = UoW.GenreRepository.GetByCondition(g => g.Name == genreTextBox.Text).FirstOrDefault();
            if (newGenre == null)
                MessageBox.Show("Такого жанра не существует", "Ошибка в сохранении");
            else
                _movie.Genre = newGenre;

            Producer newProducer = UoW.ProducerRepository.GetByCondition(g => g.Name == producerTextBox.Text).FirstOrDefault();
            if (newProducer == null)
                MessageBox.Show("Такого режиссера не существует", "Ошибка в сохранении");
            else
                _movie.Producer = newProducer;
            _movie.Description = descriptionTextBox.Text;

            UoW.Save();
            MessageBox.Show("Успешно сохранено.", "Cохранение");

        }
    }
}
