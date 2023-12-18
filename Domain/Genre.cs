using Domain.Interfaces;

namespace Domain
{
    public class Genre : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Movie> Movies { get; set; }
    }
}
