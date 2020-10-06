using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspProject.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ServicesDetails()
        {
            return View();
        }

        public IActionResult PageFaq()
        {
            return View();
        }
    }
}
