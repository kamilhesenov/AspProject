using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspProject.Data;
using AspProject.Models;

namespace AspProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeServiceItemsController : Controller
    {
        private readonly AplicationDbContext _context;

        public HomeServiceItemsController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/HomeServiceItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeServiceItems.ToListAsync());
        }

        // GET: Admin/HomeServiceItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeServiceItem = await _context.HomeServiceItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeServiceItem == null)
            {
                return NotFound();
            }

            return View(homeServiceItem);
        }

        // GET: Admin/HomeServiceItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeServiceItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Info,Icon,Id,Title,Content")] HomeServiceItem homeServiceItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeServiceItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeServiceItem);
        }

        // GET: Admin/HomeServiceItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeServiceItem = await _context.HomeServiceItems.FindAsync(id);
            if (homeServiceItem == null)
            {
                return NotFound();
            }
            return View(homeServiceItem);
        }

        // POST: Admin/HomeServiceItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Info,Icon,Id,Title,Content")] HomeServiceItem homeServiceItem)
        {
            if (id != homeServiceItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeServiceItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeServiceItemExists(homeServiceItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(homeServiceItem);
        }

        // GET: Admin/HomeServiceItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeServiceItem = await _context.HomeServiceItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeServiceItem == null)
            {
                return NotFound();
            }

            return View(homeServiceItem);
        }

        // POST: Admin/HomeServiceItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeServiceItem = await _context.HomeServiceItems.FindAsync(id);
            _context.HomeServiceItems.Remove(homeServiceItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeServiceItemExists(int id)
        {
            return _context.HomeServiceItems.Any(e => e.Id == id);
        }
    }
}
