using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoptAPet.Models
{
    public class FakeAnimalRepository : IAnimalRepository
    {
        public IQueryable<Animal> Animals => new List<Animal>
        {
            new Animal {Name = "Tody", Gender = "Macho", DateArrival = "11-04-2018"},
            new Animal {Name = "Lilly", Gender = "Fêmea", DateArrival = "17-05-2019"},
            new Animal {Name = "Boby", Gender = "Macho", DateArrival = "11-11-2010"}
        }.AsQueryable<Animal>();
    }
}
