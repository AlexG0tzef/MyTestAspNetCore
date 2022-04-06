using Microsoft.AspNetCore.Mvc;
using MyTestAspNetCore.Data;
using MyTestAspNetCore.Models;
using System.Diagnostics;

namespace MyTestAspNetCore.Controllers
{
    public class Form10Controller : Controller
    {
        private readonly ApplicationDbContext contextDb;
        public Form10Controller(ApplicationDbContext ContextDb) 
        {
            contextDb = ContextDb;
        }
        public IActionResult Index()
        {
            List<OrganizationM> objOrgList = contextDb.Organizations.ToList();
            return View(objOrgList);
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
        public IActionResult Create(OrganizationM obj)
        {
            if (ModelState.IsValid)
            {
                contextDb.Organizations.Add(obj);
                contextDb.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        #endregion
    }
}