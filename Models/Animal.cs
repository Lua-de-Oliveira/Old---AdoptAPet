using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoptAPet.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string DateArrival { get; set; }

        public Category Category { get; set; }
        public Shelter Shelter { get; set; }
    }
}
