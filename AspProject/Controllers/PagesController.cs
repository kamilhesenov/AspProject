using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Data;
using AspProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AspProject.Controllers
{
    public class PagesController : Controller
    {
        private readonly AplicationDbContext _context;
        public PagesController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PageProjectDetailViewModel model = new PageProjectDetailViewModel
            {
                ProjectDetail = _context.ProjectDetails.FirstOrDefault(),
                ProjectDetailItems = _context.ProjectDetailItems.ToList()
            };

            return View(model);
        }

        public IActionResult ServicesDetails()
        {
            PageServicestDetailViewModel model = new PageServicestDetailViewModel
            {
                ServicesDetail = _context.ServicesDetails.FirstOrDefault(),
                ServicesDetailItems = _context.ServicesDetailItems.ToList(),
                Setting = _context.Settings.FirstOrDefault()
            };

            return View(model);
        }

        public IActionResult PageFaq()
        {
            PageFAQViewModel model = new PageFAQViewModel
            {
                PageFaqPromos = _context.PageFaqPromos.ToList()
            };

            return View(model);
        }
    }
}
