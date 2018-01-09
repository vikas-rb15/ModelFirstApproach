using Microsoft.EntityFrameworkCore;

namespace Demo1.Entities
{
    public class ActorDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source = (localdb)\ProjectsV13; Initial Catalog = ActorDb; Integrated Security = True;TrustServerCertificate = True;"
                );
        }
    }
}
