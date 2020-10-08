using AspProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspProject.ViewComponets
{
    public class HomePageFooterComponent : ViewComponent
    {
        private readonly AplicationDbContext _context;
        public HomePageFooterComponent(AplicationDbContext context)
        {
            _context = context;
        }
        public ViewViewComponentResult Invoke()
        {
            var footer = _context.Settings.FirstOrDefault();

            return View(footer);
        }
    }
}
