using Domain;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkNamespace;
using WinFormsVideoLibrary.Dto;
using WinFormsVideoLibrary.Services;

namespace WinFormsVideoLibrary
{
    public partial class ProducersForm : Form
    {
        private UnitOfWork UoW = Program.UnitOfWork;
        LoadDataGridService<Producer, ProducerDto> loadDataGridService = new LoadDataGridService<Producer, ProducerDto>();
        public ProducersForm()
        {
            InitializeComponent();
            loadDataGridService.LoadDataGridAsync(producersDataGrid, UoW.ProducerRepository.GetAll().ToList());

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var query = UoW.ProducerRepository.GetAll();

            if (!string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                query = query.Where(m => m.Name.Contains(nameTextBox.Text));
            }

            loadDataGridService.LoadDataGridAsync(producersDataGrid, query.ToList());

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            loadDataGridService.LoadDataGridAsync(producersDataGrid, UoW.ProducerRepository.GetAll().ToList());
        }

        private void producersDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var cellValue = producersDataGrid.Rows[e.RowIndex].Cells[1].Value;

            if (cellValue is int producerId && producerId != 0)
            {
                ProducerForm producerForm = new ProducerForm(producerId);
                producerForm.Show();
            }
        }

        private void createMovie_Click(object sender, EventArgs e)
        {
            ProducerForm producerForm = new ProducerForm();
            producerForm.Show();
        }
    }
}
