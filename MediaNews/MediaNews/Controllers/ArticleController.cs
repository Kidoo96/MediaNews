using MediaNews.Models;
using MediaNews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaNews.Controllers
{
    public class ArticleController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        // GET: Article
        //public ActionResult Index()
        //{


        //    return View("List");
        //}

        public ActionResult List()
        {
            List<Article> article = new List<Article>();
            article = new ArticleRepository().GetAll().ToList();

            return View(article);
        }

        public ActionResult Edit(int id)
        {
            Article article = new ArticleRepository().GetAll().FirstOrDefault(a => a.ID == id);

            return View(article);
        }

        [HttpPost]
        public ActionResult Edit(Article art)
        {
            ArticleRepository repo = new ArticleRepository();
            repo.Update(art);

            return RedirectToAction("List"); 
        }

        public ActionResult Delete(int id)
        {
            ArticleRepository repo = new ArticleRepository();
            repo.Delete(id);

            return RedirectToAction("List");
        }

        public void GetById(int id)
        {
            CategoryModel cm = new CategoryRepository().GetAll().FirstOrDefault(d => d.ID == id);
        }

        public ActionResult Create()
        {

            Article art = new Article();

            CategoryRepository catrepo = new CategoryRepository();
      
            ViewBag.category = new SelectList(catrepo.GetAll(), "ID", "Name");

            return View(art);
        }

        [HttpPost]
        public ActionResult Create(Article art, HttpPostedFileBase file)
        {
                
            ArticleRepository repo = new ArticleRepository();

            if (file != null)
            {
                art.imagePath = new byte[file.ContentLength];
                file.InputStream.Read(art.imagePath, 0, file.ContentLength);
            }
           

            repo.Insert(art);

            return RedirectToAction("List");
        }

        [HttpPost]
        public ActionResult Details(int id)
        {
            Article arti = new ArticleRepository().GetAll().FirstOrDefault(d => d.ID == id);

            return View(arti);
        }

    }
}