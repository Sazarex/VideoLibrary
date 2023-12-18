using Domain.BaseTypes;
using Domain.Interfaces;

namespace Domain
{
    public class Subscription: INamedEntity, IDateInfo, IEntityState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public EntityState EntityState { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; }


        public int UserId { get; set; }
        public int PaymentId { get; set; }
    }
}
