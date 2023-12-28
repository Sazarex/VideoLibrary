using Domain.BaseTypes;
using Domain.Interfaces;

namespace Domain
{
    public class Payment : IEntity, IDateInfo
    {
        public int Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual Subscription Subscription { get; set; }
        public int? SubscriptionId { get; set; }

    }
}
