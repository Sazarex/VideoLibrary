using Domain.Interfaces;
using UnitOfWorkNamespace;
using WinFormsVideoLibrary.Specifications;

namespace WinFormsVideoLibrary
{
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            UnitOfWork UoW = new UnitOfWork();
            //var allGenres = UoW.GenreRepository.GetAll().ToList();
            BindingSource binding = new BindingSource();
            //binding.DataSource = allGenres;
            moviesDataGrid.DataSource = binding;
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                var nameSpec = new NameSpecification(nameTextBox.Text);
                binding.DataSource = UoW.GenreRepository.GetByCondition(m => nameSpec.IsSatisfiedBy(m)).ToList();
                moviesDataGrid.DataSource = binding;

            }

        }
    }
}
