using Domain.BaseTypes;
using Domain.Interfaces;

namespace Domain
{
    public class User : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
