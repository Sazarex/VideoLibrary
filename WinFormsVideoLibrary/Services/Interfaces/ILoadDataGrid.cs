namespace WinFormsVideoLibrary.Services.Interfaces
{
    public interface ILoadDataGrid<T>
    {
        public void LoadDataGridAsync(DataGridView dataGrid, IEnumerable<T> data);

        public void LoadDataGridAsync(DataGridView dataGrid, T data);

    }
}
