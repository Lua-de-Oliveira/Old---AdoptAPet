using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdoptAPet.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdoptAPet.Controllers
{
    public class AnimalController : Controller
    {
        private IAnimalRepository repository;

        public AnimalController(IAnimalRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Animals);
    }
}
