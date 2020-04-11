using System.Collections.Generic;
using System.Linq;

namespace AdoptAPet.Models
{
    public class EFAnimalRepository : IAnimalRepository
    {
        private ApplicationDbContext context;

        public EFAnimalRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Animal> Animals => context.Animals;
    }
}
