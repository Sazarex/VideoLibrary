using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public class ProducerRepository : Repository<Producer>
    {
        public ProducerRepository(DbContext context) : base(context)
        {
        }
    }
}
