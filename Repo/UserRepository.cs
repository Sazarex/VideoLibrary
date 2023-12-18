using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
