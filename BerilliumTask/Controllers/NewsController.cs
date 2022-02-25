using BerilliumTask.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerilliumTask.Controllers
{
    public class NewsController : Controller
    {

        private readonly AppDbContext db;

        public NewsController(AppDbContext database)
        {
            this.db = database;
        }

        public IActionResult Index()
        {
            ViewBag.Count = db.News.Count();
            //return RedirectToAction("LoadNews");
            return View(db.News.Take(5).ToList());
        }
        public IActionResult LoadNews(int skip=0)
        {
            return PartialView("_NewsPartial", db.News.Skip(skip).Take(5).ToList());
           
        }
    }
}
