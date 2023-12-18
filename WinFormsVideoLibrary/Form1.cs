using DataBase;
using Microsoft.EntityFrameworkCore;
using Repo;

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
            DbContext db = new DataBaseContext();
            GenreRepository genreRep = new GenreRepository(db);
            genreRep.CreateEntity(new Domain.Genre() { Name = "Fjffjjf 111 gogo dofokdo" });
            genreRep.CreateEntity(new Domain.Genre() { Name = "11123do3031112" });
            genreRep.CreateEntity(new Domain.Genre() { Name = "dofiofi34Do Do r433111 Dolkl,fok." });
            genreRep.Save();
            //genreRep.Dispose();
        }
    }
}