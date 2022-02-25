using BerilliumTask.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace BerilliumTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Service> Services { get; set; }
        
    }
}
