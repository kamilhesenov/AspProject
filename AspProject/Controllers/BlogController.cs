using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Data;
using AspProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AspProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AplicationDbContext _context;
        public BlogController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BlogDefaultViewModel model = new BlogDefaultViewModel
            {
                HomeOurNewsItems = _context.HomeOurNewsItems.Take(6).ToList()
            };

            return View(model);
        }

        public IActionResult BlogLeftSidebar()
        {
            BlogSidebarViewModel model = new BlogSidebarViewModel
            {
                BlogSidebarBlogs = _context.BlogSidebarBlogs.ToList(),
                BlogSidebarBlogItems = _context.BlogSidebarBlogItems.ToList()
            };

            return View(model);
        }
    }
}
