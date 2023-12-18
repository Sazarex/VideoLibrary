using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public class MovieRepository : Repository<Movie>
    {
        public MovieRepository(DbContext context) : base(context)
        {
        }
    }
}
