using Microsoft.EntityFrameworkCore;

namespace mvcMySQL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Region> Region { get; set; }
    }
}