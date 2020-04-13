using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace AdoptAPet.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
    }
}
