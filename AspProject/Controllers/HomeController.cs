using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Data;
using AspProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace AspProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,AplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Hero = _context.Heroes.FirstOrDefault(),
                Promo = _context.Promos.FirstOrDefault(),
                AboutUs = _context.AboutUs.FirstOrDefault(),
                HomeService = _context.HomeServices.FirstOrDefault(),
                HomeServiceItem = _context.HomeServiceItems.FirstOrDefault(),
                DownloadApp = _context.DownloadApps.FirstOrDefault(),
                DownloadAppStor = _context.DownloadAppStors.FirstOrDefault(),
                HomeOurNew = _context.HomeOurNews.FirstOrDefault(),
                HomeOurNewsItem = _context.HomeOurNewsItems.FirstOrDefault(),
                Testimonial = _context.Testimonials.FirstOrDefault(),
                TestemonialItem = _context.TestemonialItems.FirstOrDefault(),
                HomeTeamTwo = _context.HomeTeamTwos.FirstOrDefault(),
                HomeTeamTwoItem = _context.HomeTeamTwoItems.FirstOrDefault(),
                HomeCallToAction = _context.HomeCallToActions.FirstOrDefault()
            };
         ViewData["nav"] = "home";
            return View(model);
        }

       
    }
}
