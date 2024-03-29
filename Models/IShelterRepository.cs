﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoptAPet.Models
{
    public interface IShelterRepository
    {
        IQueryable<Shelter> Shelters { get; }

        void AddShelter(Shelter newShelter);
        void EditShelter(Shelter newShelter);
        Shelter DeleteShelter(int shelterID);
    }
}
