using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspProject.Data;
using AspProject.Models.Service;
using AspProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AspProject.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AplicationDbContext _context;
        public ServicesController(AplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ServiceViewModel model = new ServiceViewModel
            {
                HomeServiceItems = _context.HomeServiceItems.ToList(),
                Clients = _context.Clients.ToList(),
                ServicePromos = _context.ServicePromos.ToList(),
                Counters = _context.Counters.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                CounterPhoto = _context.CounterPhotos.FirstOrDefault(),
                HeaderViewModel = new HeaderViewModel
                {
                    Title = "Our Services",
                    Subject = "Pages",
                    Content = "Services"
                }
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SendMessage(ServiceViewModel model)
        {
            if (ModelState.IsValid)
            {
                Message message = new Message
                {
                    Name = model.Message.Name,
                    Email = model.Message.Email,
                    Text = model.Message.Text
                };

                _context.Messages.Add(message);

                _context.SaveChanges();
                

                return RedirectToAction("Index", "Services");
            }

            return RedirectToAction("index", "Services");
        }
    }
}
