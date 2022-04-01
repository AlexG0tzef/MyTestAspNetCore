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

        #region Create
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
            if (obj.Name.Contains("!")) 
            {
                ModelState.AddModelError("Name", "Test Error");
            }
            if (ModelState.IsValid)
            {
                contextDb.Categories.Add(obj);
                contextDb.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        #endregion

        #region Edit
        //GET METHOD
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var categoryFromDb = contextDb.Categories.Find(id);
                if (categoryFromDb == null) NotFound();
                return View(categoryFromDb);
            }
        }
        //POST METHOD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryM obj)
        {
            if (obj.Name.Contains("!"))
            {
                ModelState.AddModelError("Name", "Test Error");
            }
            if (ModelState.IsValid)
            {
                contextDb.Categories.Update(obj);
                contextDb.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        #endregion

        #region Delete
        //GET METHOD
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var categoryFromDb = contextDb.Categories.Find(id);
                if (categoryFromDb == null) NotFound();
                return View(categoryFromDb);
            }
        }
        //POST METHOD
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = contextDb.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            contextDb.Categories.Remove(obj);
            contextDb.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
        #endregion
    }
}
