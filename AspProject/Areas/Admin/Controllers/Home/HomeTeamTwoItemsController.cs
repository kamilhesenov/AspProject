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

namespace AspProject.Areas.Admin.Controllers.Home
{
    [Area("Admin")]
    public class HomeTeamTwoItemsController : Controller
    {
        private readonly AplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public HomeTeamTwoItemsController(AplicationDbContext context,IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Admin/HomeTeamTwoItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeTeamTwoItems.ToListAsync());
        }

        // GET: Admin/HomeTeamTwoItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTeamTwoItem = await _context.HomeTeamTwoItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeTeamTwoItem == null)
            {
                return NotFound();
            }

            return View(homeTeamTwoItem);
        }

        // GET: Admin/HomeTeamTwoItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/HomeTeamTwoItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Position,Text,Upload,Facebook,Linkedin,Dribbble")] HomeTeamTwoItem homeTeamTwoItem)
        {
            if(homeTeamTwoItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }
            else
            {
                if (homeTeamTwoItem.Upload.ContentType != "image/jpeg" && homeTeamTwoItem.Upload.ContentType != "image/png" && homeTeamTwoItem.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
                }

            }
            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(homeTeamTwoItem.Upload);
                homeTeamTwoItem.Photo = fileName;

                _context.Add(homeTeamTwoItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeTeamTwoItem);
        }

        // GET: Admin/HomeTeamTwoItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTeamTwoItem = await _context.HomeTeamTwoItems.FindAsync(id);
            if (homeTeamTwoItem == null)
            {
                return NotFound();
            }
            return View(homeTeamTwoItem);
        }

        // POST: Admin/HomeTeamTwoItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Position,Text,Photo,Upload,Facebook,Linkedin,Dribbble")] HomeTeamTwoItem homeTeamTwoItem)
        {
            if (id != homeTeamTwoItem.Id)
            {
                return NotFound();
            }
            if (homeTeamTwoItem.Upload.ContentType != "image/jpeg" && homeTeamTwoItem.Upload.ContentType != "image/png" && homeTeamTwoItem.Upload.ContentType != "image/gif")
            {
                ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
            }

            if (homeTeamTwoItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", homeTeamTwoItem.Photo);
                    _fileManager.Delete(oldFile);

                    var fileName = _fileManager.Upload(homeTeamTwoItem.Upload);
                    homeTeamTwoItem.Photo = fileName;
                    _context.Update(homeTeamTwoItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeTeamTwoItemExists(homeTeamTwoItem.Id))
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
            return View(homeTeamTwoItem);
        }

        // GET: Admin/HomeTeamTwoItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTeamTwoItem = await _context.HomeTeamTwoItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeTeamTwoItem == null)
            {
                return NotFound();
            }

            return View(homeTeamTwoItem);
        }

        // POST: Admin/HomeTeamTwoItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeTeamTwoItem = await _context.HomeTeamTwoItems.FindAsync(id);
            try
            {
                _fileManager.Delete(homeTeamTwoItem.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.HomeTeamTwoItems.Remove(homeTeamTwoItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.HomeTeamTwoItems.Remove(homeTeamTwoItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeTeamTwoItemExists(int id)
        {
            return _context.HomeTeamTwoItems.Any(e => e.Id == id);
        }
    }
}
