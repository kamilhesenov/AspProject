using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Models;
using AspProject.Models.About;
using AspProject.Models.Home;
using Microsoft.EntityFrameworkCore;

namespace AspProject.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options):base(options)
        {

        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<AboutUsItem> AboutUsItems { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HomeOurNewsItem> HomeOurNewsItems { get; set; }
        public DbSet<HomePortfolioItem> HomePortfolioItems { get; set; }
        public DbSet<HomeServiceItem> HomeServiceItems { get; set; }
        public DbSet<HomeTeamTwoItem> HomeTeamTwoItems { get; set; }
        public DbSet<Promo> Promos { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TestemonialItem> TestemonialItems { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<AboutPromo> AboutPromos { get; set; }
        public DbSet<AboutTestimonial> AboutTestimonials { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<OurWorkProcess> OurWorkProcesses { get; set; }
    }
}
