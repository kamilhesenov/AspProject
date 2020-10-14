using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspProject.Data;
using AspProject.Models.Home;

namespace AspProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutUsItemsController : Controller
    {
        private readonly AplicationDbContext _context;

        public AboutUsItemsController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AboutUsItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.AboutUsItems.ToListAsync());
        }

        // GET: Admin/AboutUsItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsItem = await _context.AboutUsItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutUsItem == null)
            {
                return NotFound();
            }

            return View(aboutUsItem);
        }

        // GET: Admin/AboutUsItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutUsItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Heading,Subject")] AboutUsItem aboutUsItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aboutUsItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aboutUsItem);
        }

        // GET: Admin/AboutUsItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsItem = await _context.AboutUsItems.FindAsync(id);
            if (aboutUsItem == null)
            {
                return NotFound();
            }
            return View(aboutUsItem);
        }

        // POST: Admin/AboutUsItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Heading,Subject")] AboutUsItem aboutUsItem)
        {
            if (id != aboutUsItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aboutUsItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AboutUsItemExists(aboutUsItem.Id))
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
            return View(aboutUsItem);
        }

        // GET: Admin/AboutUsItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutUsItem = await _context.AboutUsItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aboutUsItem == null)
            {
                return NotFound();
            }

            return View(aboutUsItem);
        }

        // POST: Admin/AboutUsItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aboutUsItem = await _context.AboutUsItems.FindAsync(id);
            _context.AboutUsItems.Remove(aboutUsItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AboutUsItemExists(int id)
        {
            return _context.AboutUsItems.Any(e => e.Id == id);
        }
    }
}
