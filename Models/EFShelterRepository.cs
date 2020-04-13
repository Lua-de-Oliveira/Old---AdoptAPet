using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoptAPet.Models
{
    public class EFShelterRepository : IShelterRepository
    {
        private ApplicationDbContext context;

        public EFShelterRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

         public IQueryable<Shelter> Shelters => context.Shelters;
    }
}
