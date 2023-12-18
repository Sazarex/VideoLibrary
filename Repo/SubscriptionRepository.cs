using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public class SubscriptionRepository : Repository<Subscription>
    {
        public SubscriptionRepository(DbContext context) : base(context)
        {
        }
    }
}
