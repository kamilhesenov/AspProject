using AspProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.ViewComponets
{
    public class HomeFooterLinksComponent : ViewComponent
    {
        private readonly AplicationDbContext _context;
        public HomeFooterLinksComponent(AplicationDbContext context)
        {
            _context = context;
        }
        public ViewViewComponentResult Invoke()
        {
            var link = _context.SocialLinks.FirstOrDefault();

            return View(link);
        }
    }
}
