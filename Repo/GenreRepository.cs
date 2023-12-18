using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public class GenreRepository : Repository<Genre>
    {
        public GenreRepository(DbContext context) : base(context)
        {
        }
    }
}
