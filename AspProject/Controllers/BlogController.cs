using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Data;
using AspProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace AspProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AplicationDbContext _context;
        public BlogController(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page = 1, int pageSize = 3)
        {
            var items = _context.HomeOurNewsItems.AsNoTracking().OrderBy(x => x.Id);
            var pagingData = await PagingList.CreateAsync(items, pageSize, page);
            BlogDefaultViewModel model = new BlogDefaultViewModel
            {
                PagingList = pagingData,
                HeaderViewModel = new HeaderViewModel
                {
                    Title = "Blog Default",
                    Subject = "Blog",
                    Content = "Blog Default"
                }
            };

            return View(model);
        }

        public IActionResult BlogLeftSidebar()
        {
            BlogSidebarViewModel model = new BlogSidebarViewModel
            {
                BlogSidebarBlogs = _context.BlogSidebarBlogs.ToList(),
                BlogSidebarBlogItems = _context.BlogSidebarBlogItems.ToList(),
                HeaderViewModel = new HeaderViewModel
                {
                    Title = "Blog Left Sidebar",
                    Subject = "Blog",
                    Content = "Blog Left Sidebar"
                }
            };

            return View(model);
        }
    }
}
