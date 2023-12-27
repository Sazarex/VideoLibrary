using WinFormsVideoLibrary.Services.Interfaces;

namespace WinFormsVideoLibrary.Services
{
    public class LoadDataGridService<Type,Dto> : ILoadDataGrid<Type>
    {
        public async void LoadDataGridAsync(DataGridView dataGrid, IEnumerable<Type> data)
        {
            var list = new List<Dto>();

            foreach (var item in data)
                list.Add(Program.Mapper.Map<Dto>(item));

            var result = await Task.Run(() => LoadByBindingSource(list));
            dataGrid.DataSource = result;
        }

        public async void LoadDataGridAsync(DataGridView dataGrid, Type data)
        {
            var result = await Task.Run(() =>LoadByBindingSource(Program.Mapper.Map<Dto>(data)));
            dataGrid.DataSource = result;

        }

        private BindingSource LoadByBindingSource(object data)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = data;
            return binding;
        }
    }
}
