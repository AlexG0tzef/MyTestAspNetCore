﻿using Microsoft.AspNetCore.Mvc;
using MyTestAspNetCore.Data;
using MyTestAspNetCore.Models;
using System.Diagnostics;

namespace MyTestAspNetCore.Controllers
{
    public class AllFormsController : Controller
    {
        private readonly ApplicationDbContext contextDb;
        private string formNum;
        private OrganizationM org { get; set; }
        private FormsM form { get; set; }
        public AllFormsController(ApplicationDbContext ContextDb) 
        {
            contextDb = ContextDb;
        }
        //public IActionResult Index()
        //{
        //    List<OrganizationM> objOrgList = contextDb.Organizations.ToList();
        //    return View(objOrgList);
        //}

        #region Create
        //GET METHOD
        public IActionResult Create(string FormNum)
        {
            formNum = FormNum;
            return View();
        }
        //POST METHOD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(OrganizationM obj)
        {
            //if (ModelState.IsValid)
            //{
            //    contextDb.Organizations.Add(obj);
            //    contextDb.SaveChanges();
            //    TempData["success"] = "Организация успешно добавлена!";
            //    return RedirectToAction("Index");
            //}
            //return View(obj);

            contextDb.Organizations.Add(obj);
            contextDb.SaveChanges();
            TempData["success"] = "Организация успешно добавлена!";
            return RedirectToAction("Index");
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
                var categoryFromDb = contextDb.Organizations.Find(id);
                if (categoryFromDb == null) NotFound();
                return View(categoryFromDb);
            }
        }
        //POST METHOD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(OrganizationM obj)
        {
            if (ModelState.IsValid)
            {
                contextDb.Organizations.Update(obj);
                contextDb.SaveChanges();
                TempData["success"] = "Организация обновлена!";
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
                var categoryFromDb = contextDb.Organizations.Find(id);
                if (categoryFromDb == null) NotFound();
                return View(categoryFromDb);
            }
        }
        //POST METHOD
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = contextDb.Organizations.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            contextDb.Organizations.Remove(obj);
            contextDb.SaveChanges();
            TempData["success"] = "Организация успешно удалена!";
            return RedirectToAction("Index");
        }
        #endregion
    }
}