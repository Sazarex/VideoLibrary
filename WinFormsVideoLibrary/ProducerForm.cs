using Domain;
using System.Linq.Expressions;
using UnitOfWorkNamespace;
using WinFormsVideoLibrary.Dto;
using WinFormsVideoLibrary.Services;

namespace WinFormsVideoLibrary
{
    public partial class ProducerForm : Form
    {
        private UnitOfWork UoW = Program.UnitOfWork;
        private Producer _producer = null;
        private int? entityId = null;
        public ProducerForm()
        {
            InitializeComponent();
        }

        public ProducerForm(int userId)
        {
            InitializeComponent();

            EntityInfoService entityInfoService = new EntityInfoService();
            var producerDto = entityInfoService.LoadEntityInfoAsync<Producer, ProducerDto>(userId);

            if (producerDto != null)
            {
                entityId = producerDto.Id;
                deleteButton.Visible = true;
                nameTextBox.Text = producerDto.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (entityId == null)
                _producer = new Producer();
            else
                _producer = UoW.ProducerRepository.GetEntity(entityId.GetValueOrDefault());

            if (nameTextBox.Text == null)
                MessageBox.Show("Пустое значение Ф.И.О.", "Ошибка в сохранении");
            else
                _producer.Name = nameTextBox.Text;


            if (nameTextBox.Text != null)
            {
                if (entityId == null)
                {
                    UoW.ProducerRepository.CreateEntity(_producer);
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
                var isHasMovies = UoW.MovieRepository.GetEntityByCondition(m => m.ProducerId == entityId, m => m.Producer) != null;
                if (isHasMovies)
                    MessageBox.Show("У режиссера есть фильмы. Удалите сначала его фильмы, а когда не будет фильмов - режиссера.", "Ошибка удаления");
                else
                {
                    UoW.ProducerRepository.Delete(entityId.GetValueOrDefault());
                    UoW.Save();
                    MessageBox.Show("Успешно удалено.", "Удаление");
                    this.Close();
                }
            }
        }
    }
}
