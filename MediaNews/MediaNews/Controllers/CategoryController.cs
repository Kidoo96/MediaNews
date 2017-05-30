using MediaNews.Models;
using MediaNews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaNews.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult List()
        {
            List<CategoryModel> cat = new List<CategoryModel>();
            cat = new CategoryRepository().GetAll().ToList();

            return View(cat); // TODO View
        }

        public ActionResult Edit(int id)
        {
            CategoryModel cat = new CategoryRepository().GetAll().FirstOrDefault(c => c.ID == id);

            return View(cat);
        }

        [HttpPost]
        public ActionResult Edit(CategoryModel cat)
        {
            CategoryRepository repo = new CategoryRepository();
            repo.Update(cat);

            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            CategoryRepository repo = new CategoryRepository();
            repo.Delete(id);

            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            CategoryModel cat = new CategoryModel();

            return View(cat);
        }

        [HttpPost]
        public ActionResult Create(CategoryModel cat)
        {
            CategoryRepository repo = new CategoryRepository();
            repo.Insert(cat);

            return RedirectToAction("List");
        }

    }
}