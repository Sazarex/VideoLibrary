using DataBase;
using Microsoft.EntityFrameworkCore;
using Repo;
using UnitOfWorkNamespace;

namespace VideoLibraryConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UnitOfWork UoW = new UnitOfWork();

            UoW.GenreRepository.CreateEntity(new Domain.Genre() { Name = "Fjffjjf" });
            UoW.GenreRepository.CreateEntity(new Domain.Genre() { Name = "111232" });
            UoW.GenreRepository.CreateEntity(new Domain.Genre() { Name = "FJFJF_)__FERFRRE" });
            UoW.Save();
            var allGenres = UoW.GenreRepository.GetAll();
            //GenreRepository genreRep = new GenreRepository(db);
            //genreRep.CreateEntity(new Domain.Genre() { Name = "Fjffjjf" });
            //genreRep.CreateEntity(new Domain.Genre() { Name = "111232" });
            //genreRep.CreateEntity(new Domain.Genre() { Name = "FJFJF_)__FERFRRE" });
            //genreRep.Save();
            //var entities = genreRep.GetAll();
            //foreach (var item in entities)
            //{
            //    Console.WriteLine(item.Name);
            //}
            Console.WriteLine("Db context is working!");

        }
    }
}