using Domain.BaseTypes;
using Domain.Interfaces;

namespace Domain
{
    public class Producer : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
