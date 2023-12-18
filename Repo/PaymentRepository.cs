using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public class PaymentRepository : Repository<Payment>
    {
        public PaymentRepository(DbContext context) : base(context)
        {
        }
    }
}
