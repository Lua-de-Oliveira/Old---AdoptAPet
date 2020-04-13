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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Shelter newShelter)
        {
            repository.AddShelter(newShelter);
            return RedirectToAction("List");
        }

        public ViewResult Edit(int shelterID) =>
           View(repository.Shelters
           .FirstOrDefault(shelter => shelter.ShelterID == shelterID)
       );

        [HttpPost]
        public IActionResult Edit(Shelter shelter)
        {
            if (ModelState.IsValid)
            {
                repository.EditShelter(shelter);
                TempData["message"] = "Alterado com sucesso!";
                return RedirectToAction("List");
            }
            else
            {
                return View(shelter);
            }
        }

        public ViewResult Delete(Shelter shelter)
        {
            var s = repository.Shelters
                .FirstOrDefault(m => m.ShelterID == shelter.ShelterID);

            return View(s);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int shelterID)
        {
            Shelter deleteShelter = repository.DeleteShelter(shelterID);
            if (deleteShelter != null)
            {
                TempData["message"] = $"{deleteShelter.Name} foi excluido.";
            }
            return RedirectToAction("List");
        }
    }
}
