using Microsoft.AspNetCore.Mvc;
using MyTestAspNetCore.Data;
using MyTestAspNetCore.Models;

namespace MyTestAspNetCore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext contextDb;
        public CategoryController(ApplicationDbContext ContextDb)
        {
            contextDb = ContextDb;
        }
        public IActionResult Index()
        {
            List<CategoryM> objCategoryList = contextDb.Categories.ToList();
            return View(objCategoryList);
        }
        //GET METHOD
        public IActionResult Create()
        {
            return View();
        }
        //POST METHOD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryM obj)
        {
            if (ModelState.IsValid)
            {
                contextDb.Categories.Add(obj);
                contextDb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
