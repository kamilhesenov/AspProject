using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AspProject.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options):base(options)
        {

        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<DownloadApp> DownloadApps { get; set; }
        public DbSet<DownloadAppStor> DownloadAppStors { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HomeCallToAction> HomeCallToActions { get; set; }
        public DbSet<HomeOurNew> HomeOurNews { get; set; }
        public DbSet<HomeOurNewsItem> HomeOurNewsItems { get; set; }
        public DbSet<HomePortfolio> HomePortfolios { get; set; }
        public DbSet<HomePortfolioItem> HomePortfolioItems { get; set; }
        public DbSet<HomeService> HomeServices { get; set; }
        public DbSet<HomeServiceItem> HomeServiceItems { get; set; }
        public DbSet<HomeTeamTwo> HomeTeamTwos { get; set; }
        public DbSet<HomeTeamTwoItem> HomeTeamTwoItems { get; set; }
        public DbSet<Promo> Promos { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TestemonialItem> TestemonialItems { get; set; }
    }
}
