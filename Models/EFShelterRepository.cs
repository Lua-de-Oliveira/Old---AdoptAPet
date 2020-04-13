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
        async public void AddShelter(Shelter newShelter)
        {
            context.Shelters.Add(newShelter);
            await context.SaveChangesAsync();
        }

        async public void EditShelter(Shelter shelter)
        {
            if (shelter.ShelterID == 0)
            {
                context.Shelters.Add(shelter);
            }
            else
            {
                Shelter dbEntry = context.Shelters
                .FirstOrDefault(s => s.ShelterID == shelter.ShelterID);
                if (dbEntry != null)
                {
                    dbEntry.Name = shelter.Name;
                    dbEntry.Street = shelter.Street;
                    dbEntry.City = shelter.City;
                    dbEntry.Cep = shelter.Cep;
                    dbEntry.Number = shelter.Number;
                    dbEntry.State = shelter.State;
                    dbEntry.Phone = shelter.Phone;
                    dbEntry.CpfOrCnpj = shelter.CpfOrCnpj;
                    dbEntry.SocialMedia = shelter.SocialMedia;
                }
            }
            await context.SaveChangesAsync();

        }

        public Shelter DeleteShelter(int shelterID)
        {
            Shelter dbEntry = context.Shelters
            .FirstOrDefault(s => s.ShelterID == shelterID);
            if (dbEntry != null)
            {
                context.Shelters.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
