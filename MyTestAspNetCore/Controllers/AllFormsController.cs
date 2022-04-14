using Microsoft.AspNetCore.Mvc;
using MyTestAspNetCore.Data;
using MyTestAspNetCore.Models;
using System.Diagnostics;

namespace MyTestAspNetCore.Controllers
{
    public class AllFormsController : Controller
    {
        private readonly ApplicationDbContext contextDb;

        public AllFormsController(ApplicationDbContext ContextDb) 
        {
            contextDb = ContextDb;
        }

        #region Create
        //GET METHOD
        public IActionResult Create(int? id)
        {
            var categoryFromDb = contextDb.Organizations.Find(id);
            //if (newF) 
            //{
            //    if (categoryFromDb.Form == null)
            //    {
            //        categoryFromDb.Form = new List<FormsNumberM>();
            //    }
            //    categoryFromDb.Form.Add(new FormsNumberM());
            //    contextDb.Organizations.Update(categoryFromDb);
            //    contextDb.SaveChanges();
            //}
            return View(categoryFromDb);
        }
        //POST METHOD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrganizationM obj)
        {
            //var categoryFromDb = contextDb.Organizations.Find(obj[0].Id);
            //if (categoryFromDb == null) NotFound();
            //FormsNumberM newForm = new();
            //foreach (FormsM o in obj) 
            //{
            //    newForm.Form.Add(o);
            //}
            //categoryFromDb.Form.Add(newForm);
            //contextDb.Organizations.Update(categoryFromDb);
            //contextDb.SaveChanges();
            //TempData["success"] = "Форма успешно добавлена!";
            //return RedirectToAction();
            return RedirectToAction("ViewForms");
        }
        #endregion
        public IActionResult CreateF(OrganizationM? obj, string formN, int? ID)
        {
            var categoryFromDb = contextDb.Organizations.Find(ID);
            if (categoryFromDb.Form == null)
            {
                categoryFromDb.Form = new List<FormsNumberM>();
            }
            categoryFromDb.Form.Add(new FormsNumberM());
            contextDb.Organizations.Update(categoryFromDb);
            contextDb.SaveChanges();
            return RedirectToActionPreserveMethod("Create", "AllForms", categoryFromDb);
            //return RedirectToAction("Create");
        }
    }
}