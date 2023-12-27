using Domain;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkNamespace;
using WinFormsVideoLibrary.Dto;
using WinFormsVideoLibrary.Services;

namespace WinFormsVideoLibrary
{
    public partial class MoviesForm : Form
    {
        private UnitOfWork UoW = Program.UnitOfWork;
        LoadDataGridService<Movie, MovieListDto> loadDataGridService = new LoadDataGridService<Movie, MovieListDto>();

        public MoviesForm()
        {
            InitializeComponent();

            loadDataGridService.LoadDataGridAsync(moviesDataGrid, UoW.MovieRepository.GetAll().Include(m => m.Genre).Include(m => m.Producer).ToList());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var query = UoW.MovieRepository.GetAll();


            if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                query = query.Where(m => m.Name.Contains(nameTextBox.Text));
            }

            if (!string.IsNullOrWhiteSpace(producerTextBox.Text))
            {
                query = query.Where(m => m.Producer.Name.Contains(producerTextBox.Text));
            }

            if (!string.IsNullOrWhiteSpace(genreTextBox.Text))
            {
                query = query.Where(m => m.Genre.Name.Contains(genreTextBox.Text));
            }


            loadDataGridService.LoadDataGridAsync(moviesDataGrid, query.ToList());

        }

        private void moviesDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var cellValue = moviesDataGrid.Rows[e.RowIndex].Cells[4].Value;

            if (cellValue is int movieId && movieId != 0)
            {
                MovieForm movieForm = new MovieForm(movieId);
                movieForm.Show();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            loadDataGridService.LoadDataGridAsync(moviesDataGrid, UoW.MovieRepository.GetAll().Include(m => m.Genre).Include(m => m.Producer).ToList());
        }

        private void createMovie_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
        }
    }
}
