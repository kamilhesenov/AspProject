using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspProject.Data;
using AspProject.Models;
using System.IO;
using AspProject.Libs;

namespace AspProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HeroesController : Controller
    {
        private readonly AplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public HeroesController(AplicationDbContext context,IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Admin/Heroes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Heroes.ToListAsync());
        }

        // GET: Admin/Heroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Heroes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return View(hero);
        }

        // GET: Admin/Heroes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Heroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Heading,Upload,Id,AddedDate,Title,Content")] Hero hero)
        {
            if (hero.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }
            else
            {
                if (hero.Upload.ContentType != "image/jpeg" && hero.Upload.ContentType != "image/png" && hero.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
                }

            }

            if (ModelState.IsValid)
            {

                var fileName = _fileManager.Upload(hero.Upload);
                hero.Photo = fileName;

                _context.Add(hero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hero);
        }

        // GET: Admin/Heroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            

            var hero = await _context.Heroes.FindAsync(id);
            if (hero == null)
            {
                return NotFound();
            }
            return View(hero);
        }

        // POST: Admin/Heroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Heading,Photo,Upload,Id,AddedDate,Title,Content")] Hero hero)
        {
            if (id != hero.Id)
            {
                return NotFound();
            }

            if (hero.Upload.ContentType != "image/jpeg" && hero.Upload.ContentType != "image/png" && hero.Upload.ContentType != "image/gif")
            {
                ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
            }

            if (hero.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }
            if (ModelState.IsValid)
            {
                
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", hero.Photo);
                    _fileManager.Delete(oldFile);

                    var fileName = _fileManager.Upload(hero.Upload);
                    hero.Photo = fileName;
                    _context.Update(hero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeroExists(hero.Id))
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
            return View(hero);
        }

        // GET: Admin/Heroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Heroes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return View(hero);
        }

        // POST: Admin/Heroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            var hero = await _context.Heroes.FindAsync(id);
            try
            {
                _fileManager.Delete(hero.Photo);
            }
            catch(FileNotFoundException)
            {
                _context.Heroes.Remove(hero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeroExists(int id)
        {
            return _context.Heroes.Any(e => e.Id == id);
        }
    }
}
