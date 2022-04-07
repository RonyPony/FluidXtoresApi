using Microsoft.EntityFrameworkCore;

namespace fluidXtoresApi.Models
{
    public class fluidContext:DbContext
    {
        public fluidContext(DbContextOptions<fluidContext>options):base(options)
        {

        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Category> Category { get; set; } = null!;
    }
}
