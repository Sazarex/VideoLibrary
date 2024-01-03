using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Genre>().HasData(GetGenres());
            builder.Entity<Producer>().HasData(GetProducers());
            builder.Entity<Movie>().HasData(GetMovies());
            builder.Entity<User>().HasData(GetUsers());
        }

        public static IEnumerable<Genre> GetGenres()
        {
            return new List<Genre>() { new Genre() {Id = 9, Name = "Драма" },
                new Genre() {Id = 1, Name = "Триллер" },
                new Genre() {Id = 2, Name = "Фантастика" },
                new Genre() {Id = 3, Name = "Мелодрама" },
                new Genre() {Id = 4, Name = "Детектив" },
                new Genre() {Id = 5, Name = "Ужас" },
                new Genre() {Id = 6, Name = "Комедия" },
                new Genre() {Id = 7, Name = "Мистика" },
                new Genre() {Id = 8, Name = "Приключения" }};
        }

        public static IEnumerable<Producer> GetProducers()
        {
            return new List<Producer>() {
            new Producer() {Id = 1, Name = "Иван Пупкин" },
            new Producer() {Id = 2, Name = "Карина Валеро" },
            new Producer() {Id = 3, Name = "Жан Фатон" }
            };
        }

        public static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>() {
                new Movie() {
                    Id = 1,
                    Name = "Пришельцы против Гоблинов",
                    GenreId = 1,
                    Description = "Lorem ipsum jfjf fjfjf oeoe",
                    ProducerId = 1 },
                new Movie() {
                    Id = 2,
                    Name = "Гоблинский фильм",
                    GenreId = 1,
                    Description = "Lorem ipsum jfjf fjfjf oeoe",
                    ProducerId = 1 },
                new Movie() {
                    Id = 3,
                    Name = "Рандом",
                    GenreId = 3,
                    Description = "Lorem ipsumjf fjfjf oeoe 1122",
                    ProducerId = 3
                 }
            };
        }

        public static IEnumerable<User> GetUsers()
        {
            return new List<User>()
            {
                new User() { Id = 1, Name = "Артур Заборович", Age = 26 },
                new User() { Id = 2, Name = "Картон Аль Махиб", Age = 12 },
                new User() { Id = 3, Name = "Кирилл Трактирович", Age = 32 },
                new User() { Id = 4, Name = "Фортун Рихтер", Age = 19 },
                new User() { Id = 5, Name = "Иван Чекан", Age = 19 }
            };
        }
    }
}