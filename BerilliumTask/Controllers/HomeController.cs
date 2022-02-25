using BerilliumTask.DAL;
using BerilliumTask.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BerilliumTask.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext db;

        public HomeController(AppDbContext database)
        {
            this.db = database;
        }

        public IActionResult Index()
        {

            HomeViewModel vm = new HomeViewModel
            {

                banners = db.Banners.ToList(),
                Projects= db.Projects.ToList(),
                news= db.News.Take(3).ToList(),
                testimonial= db.Testimonials.FirstOrDefault(),
                services = db.Services.ToList()

            };

            return View(vm);
        }

    }
}
