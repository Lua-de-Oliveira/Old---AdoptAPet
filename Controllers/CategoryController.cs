using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdoptAPet.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdoptAPet.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ICategoryRepository repository;

        public CategoryController(ICategoryRepository repo)
        {
            repository = repo;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category newCategory)
        {
            repository.AddCategory(newCategory);
            return RedirectToAction("List");
        }

        public ViewResult Edit(int categoryID) =>
            View(repository.Categories
            .FirstOrDefault(category => category.CategoryID == categoryID)
        );

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                repository.EditCategory(category);
                TempData["message"] = $"{category.Name} alterado com sucesso!";
                return RedirectToAction("List");
            }
            else
            {
                return View(category);
            }
        }

        public ViewResult Delete(Category category)
        {
        var c= repository.Categories
            .FirstOrDefault(m => m.CategoryID == category.CategoryID);

        return View(c);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(int categoryID)
        {
            Category deleteCategory = repository.DeleteCategory(categoryID);
            if (deleteCategory != null)
            {
                TempData["message"] = $"{deleteCategory.Name} foi excluido";
            }
            return RedirectToAction("List");
        }

        public ViewResult List() => View(repository.Categories);
    }
}
