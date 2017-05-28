using MediaNews.Models;
using MediaNews.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MediaNews.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult List()
        {
            List<NewsModel> news = new List<NewsModel>();
            news = new NewsRepository().GetAll().ToList();
            return View(news);
        }

        public ActionResult Edit(int id)
        {
            NewsModel news = new NewsRepository().GetAll().FirstOrDefault(n => n.ID == id);
            return View(news); // TODO Add VIEW
        }

        [HttpPost]
        public ActionResult Edit(NewsModel news)
        {
            NewsRepository repo = new NewsRepository();
            repo.Update(news);
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            NewsRepository repo = new NewsRepository();
            repo.Delete(id);
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            NewsModel n = new NewsModel();
            return View(n); // TODO Add VIEW
        }

        [HttpPost]
        public ActionResult Create(NewsModel news)
        {
            NewsRepository repo = new NewsRepository();
            repo.Insert(news);

            return RedirectToAction("List");
        }
    }
}