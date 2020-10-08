using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Data;
using AspProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AspProject.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AplicationDbContext _context;
        public ProjectController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ProjectViewModel model = new ProjectViewModel
            {
                AboutTestimonials = _context.AboutTestimonials.ToList()
            };

            return View(model);
        }
    }
}
