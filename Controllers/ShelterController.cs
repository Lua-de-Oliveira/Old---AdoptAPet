using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdoptAPet.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdoptAPet.Controllers
{
    public class ShelterController : Controller
    {
        private IShelterRepository repository;

        public ShelterController(IShelterRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Shelters);
    }
}
