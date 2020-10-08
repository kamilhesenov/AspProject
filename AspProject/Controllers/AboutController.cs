using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Data;
using AspProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AspProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AplicationDbContext _context;


        public AboutController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutViewModel model = new AboutViewModel
            {
                HomeTeamTwoItems = _context.HomeTeamTwoItems.ToList(),
                Abouts = _context.Abouts.FirstOrDefault(),
                AboutItems = _context.AboutItems.ToList(),
                AboutTestimonials = _context.AboutTestimonials.ToList(),
                AboutPromos = _context.AboutPromos.ToList(),
                OurWorkProcesses = _context.OurWorkProcesses.ToList(),
                Clients = _context.Clients.ToList()
            };

            return View(model); 
        }
    }
}
