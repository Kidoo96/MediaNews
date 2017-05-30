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
        // GET: Article
        //public ActionResult Index()
        //{
        //    return View();
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

        public ActionResult Create()
        {
            Article art = new Article();

            return View(art);
        }

        [HttpPost]
        public ActionResult Create(Article art)
        {
            ArticleRepository repo = new ArticleRepository();
            repo.Insert(art);

            return RedirectToAction("List");
        }
    }
}