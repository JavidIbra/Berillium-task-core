using BerilliumTask.DAL;
using BerilliumTask.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerilliumTask.Controllers
{
    public class ProjectsController : Controller
    {

        private readonly AppDbContext db;

        public ProjectsController(AppDbContext database)
        {
            this.db = database;
        }

        public IActionResult Index()
        {
            return View(db.Projects.Take(6).ToList());
        }

        public IActionResult SearchProject(string query)
        {
            List<Project> result = (List<Project>)db.Projects.Where(x => x.Header.ToLower().Contains(query.ToLower())).ToList();
            return PartialView("_ProjectPartial", result);
        }

    }
}
