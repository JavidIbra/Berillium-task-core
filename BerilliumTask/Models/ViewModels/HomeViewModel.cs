using BerilliumTask.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BerilliumTask.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Banner> banners { get; set; }
        public List<Project> Projects { get; set; }
        public Testimonial testimonial { get; set; }
        public List<News> news { get; set; }
        public List<Service> services { get; set; }

    }
}
