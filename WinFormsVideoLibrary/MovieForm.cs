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

            EntityInfoService entityInfoService = new EntityInfoService();
            var movieDto = entityInfoService.LoadEntityInfoAsync<Movie, MovieEntityDto>(movieId);

            if (movieDto != null)
            {
                entityId = movieDto.Id;
                nameTextBox.Text = movieDto.Name;
                genreTextBox.Text = movieDto.GenreName;
                producerTextBox.Text = movieDto.ProducerName;
                descriptionTextBox.Text = movieDto.Description;
                deleteButton.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entityId == null)
                _movie = new Movie();
            else
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

            if (newProducer != null && newGenre != null && nameTextBox.Text != null)
            {
                if (entityId == null)
                {
                    UoW.MovieRepository.CreateEntity(_movie);
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
                UoW.MovieRepository.Delete(entityId.GetValueOrDefault());
                UoW.Save();
                MessageBox.Show("Успешно удалено.", "Удаление");
                this.Close();
            }
        }
    }
}
