using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspProject.Data;
using AspProject.Models;
using AspProject.Libs;
using System.IO;

namespace AspProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePortfolioItemsController : Controller
    {
        private readonly AplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public HomePortfolioItemsController(AplicationDbContext context,IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Admin/HomePortfolioItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomePortfolioItems.ToListAsync());
        }

        // GET: Admin/HomePortfolioItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePortfolioItem = await _context.HomePortfolioItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePortfolioItem == null)
            {
                return NotFound();
            }

            return View(homePortfolioItem);
        }

        // GET: Admin/HomePortfolioItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomePortfolioItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Photo,Upload,Category,Id,Title,Content")] HomePortfolioItem homePortfolioItem)
        {
            if (homePortfolioItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }
            else
            {
                if (homePortfolioItem.Upload.ContentType != "image/jpeg" && homePortfolioItem.Upload.ContentType != "image/png" && homePortfolioItem.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
                }

            }

            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(homePortfolioItem.Upload, "wwwroot/uploads/portfolio");
                homePortfolioItem.Photo = fileName;

                _context.Add(homePortfolioItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homePortfolioItem);
        }

        // GET: Admin/HomePortfolioItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePortfolioItem = await _context.HomePortfolioItems.FindAsync(id);
            if (homePortfolioItem == null)
            {
                return NotFound();
            }
            return View(homePortfolioItem);
        }

        // POST: Admin/HomePortfolioItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Photo,Upload,Category,Id,Title,Content")] HomePortfolioItem homePortfolioItem)
        {
            if (id != homePortfolioItem.Id)
            {
                return NotFound();
            }

            if (homePortfolioItem.Upload.ContentType != "image/jpeg" && homePortfolioItem.Upload.ContentType != "image/png" && homePortfolioItem.Upload.ContentType != "image/gif")
            {
                ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
            }

            if (homePortfolioItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "portfolio", homePortfolioItem.Photo);
                    _fileManager.Delete(oldFile);

                    var fileName = _fileManager.Upload(homePortfolioItem.Upload, "wwwroot/uploads/portfolio");
                    homePortfolioItem.Photo = fileName;

                    _context.Update(homePortfolioItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomePortfolioItemExists(homePortfolioItem.Id))
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
            return View(homePortfolioItem);
        }

        // GET: Admin/HomePortfolioItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePortfolioItem = await _context.HomePortfolioItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePortfolioItem == null)
            {
                return NotFound();
            }

            return View(homePortfolioItem);
        }

        // POST: Admin/HomePortfolioItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homePortfolioItem = await _context.HomePortfolioItems.FindAsync(id);
            try
            {
                var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads","portfolio", homePortfolioItem.Photo);
                _fileManager.Delete(oldFile,"wwwroot/uploads/portfolio");
            }
            catch (FileNotFoundException)
            {
                _context.HomePortfolioItems.Remove(homePortfolioItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.HomePortfolioItems.Remove(homePortfolioItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomePortfolioItemExists(int id)
        {
            return _context.HomePortfolioItems.Any(e => e.Id == id);
        }
    }
}
