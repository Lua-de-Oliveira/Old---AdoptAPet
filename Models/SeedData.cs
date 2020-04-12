using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace AdoptAPet.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Animals.Any())
            {
                context.Animals.AddRange(
                    new Animal { Name = "Tody", Gender = "Macho", DateArrival = "11-04-2018" },
                    new Animal { Name = "Lilly", Gender = "Fêmea", DateArrival = "17-05-2019" },
                    new Animal { Name = "Boby", Gender = "Macho", DateArrival = "11-11-2010" }
                );
                context.SaveChanges();
            }
        }
    }
}
