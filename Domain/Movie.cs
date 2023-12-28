using Domain.BaseTypes;
using Domain.Interfaces;

namespace Domain
{
    public class Movie : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Genre Genre { get;set; }
        public virtual Producer Producer { get; set; }


        public int? GenreId { get; set; }
        public int? ProducerId { get; set; }

    }
}