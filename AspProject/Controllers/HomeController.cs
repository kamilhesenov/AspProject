﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Data;
using AspProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReflectionIT.Mvc.Paging;

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
            var hm = _context.HomeOurNewsItems.OrderBy(x => x.Id);
            HomeViewModel model = new HomeViewModel
            {
                Hero = _context.Heroes.FirstOrDefault(),
                Promos = _context.Promos.ToList(),
                AboutUs = _context.AboutUs.FirstOrDefault(),
                AboutUsItems = _context.AboutUsItems.ToList(),
                HomeServiceItems = _context.HomeServiceItems.ToList(),
                HomePortfolioItems = _context.HomePortfolioItems.ToList(),
                Testimonial = _context.Testimonials.FirstOrDefault(),
                TestemonialItems = _context.TestemonialItems.ToList(),
                HomeTeamTwoItems = _context.HomeTeamTwoItems.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                PagedList = PagingList.Create(hm, 3, 1)
            };
         ViewData["nav"] = "home";
            return View(model);
        }

       
    }
}
