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
    public class HomeOurNewsItemsController : Controller
    {
        private readonly AplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public HomeOurNewsItemsController(AplicationDbContext context,IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Admin/HomeOurNewsItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeOurNewsItems.ToListAsync());
        }

        // GET: Admin/HomeOurNewsItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeOurNewsItem = await _context.HomeOurNewsItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeOurNewsItem == null)
            {
                return NotFound();
            }

            return View(homeOurNewsItem);
        }

        // GET: Admin/HomeOurNewsItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeOurNewsItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Upload,Label,Heading,AddedDate,Id,Title,Content")] HomeOurNewsItem homeOurNewsItem)
        {
            if (homeOurNewsItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }
            else
            {
                if (homeOurNewsItem.Upload.ContentType != "image/jpeg" && homeOurNewsItem.Upload.ContentType != "image/png" && homeOurNewsItem.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
                }

            }
            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(homeOurNewsItem.Upload);
                homeOurNewsItem.Photo = fileName;

                _context.Add(homeOurNewsItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeOurNewsItem);
        }

        // GET: Admin/HomeOurNewsItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeOurNewsItem = await _context.HomeOurNewsItems.FindAsync(id);
            if (homeOurNewsItem == null)
            {
                return NotFound();
            }
            return View(homeOurNewsItem);
        }

        // POST: Admin/HomeOurNewsItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Photo,Upload,Label,Heading,AddedDate,Id,Title,Content")] HomeOurNewsItem homeOurNewsItem)
        {
            if (id != homeOurNewsItem.Id)
            {
                return NotFound();
            }
            if (homeOurNewsItem.Upload.ContentType != "image/jpeg" && homeOurNewsItem.Upload.ContentType != "image/png" && homeOurNewsItem.Upload.ContentType != "image/gif")
            {
                ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
            }

            if (homeOurNewsItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", homeOurNewsItem.Photo);
                    _fileManager.Delete(oldFile);

                    var fileName = _fileManager.Upload(homeOurNewsItem.Upload);
                    homeOurNewsItem.Photo = fileName;
                    _context.Update(homeOurNewsItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeOurNewsItemExists(homeOurNewsItem.Id))
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
            return View(homeOurNewsItem);
        }

        // GET: Admin/HomeOurNewsItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeOurNewsItem = await _context.HomeOurNewsItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeOurNewsItem == null)
            {
                return NotFound();
            }

            return View(homeOurNewsItem);
        }

        // POST: Admin/HomeOurNewsItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeOurNewsItem = await _context.HomeOurNewsItems.FindAsync(id);
            try
            {
                _fileManager.Delete(homeOurNewsItem.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.HomeOurNewsItems.Remove(homeOurNewsItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.HomeOurNewsItems.Remove(homeOurNewsItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeOurNewsItemExists(int id)
        {
            return _context.HomeOurNewsItems.Any(e => e.Id == id);
        }
    }
}
