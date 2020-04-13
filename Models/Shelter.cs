using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoptAPet.Models
{
    public class Shelter
    {
        public int ShelterID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Cep { get; set; }
        public string Number { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string CpfOrCnpj { get; set; }
        public string SocialMedia { get; set; }

        public List<Animal> Animais = new List<Animal>();
    }
}
