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
    public class TestemonialItemsController : Controller
    {
        private readonly AplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public TestemonialItemsController(AplicationDbContext context,IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Admin/TestemonialItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.TestemonialItems.ToListAsync());
        }

        // GET: Admin/TestemonialItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testemonialItem = await _context.TestemonialItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testemonialItem == null)
            {
                return NotFound();
            }

            return View(testemonialItem);
        }

        // GET: Admin/TestemonialItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TestemonialItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Text,FullName,Position,Upload,Star")] TestemonialItem testemonialItem)
        {
            if (testemonialItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }
            else
            {
                if (testemonialItem.Upload.ContentType != "image/jpeg" && testemonialItem.Upload.ContentType != "image/png" && testemonialItem.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
                }

            }

            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(testemonialItem.Upload);
                testemonialItem.Photo = fileName;

                _context.Add(testemonialItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testemonialItem);
        }

        // GET: Admin/TestemonialItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testemonialItem = await _context.TestemonialItems.FindAsync(id);
            if (testemonialItem == null)
            {
                return NotFound();
            }
            return View(testemonialItem);
        }

        // POST: Admin/TestemonialItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Text,FullName,Position,Photo,Upload,Star")] TestemonialItem testemonialItem)
        {
            if (id != testemonialItem.Id)
            {
                return NotFound();
            }

            if (testemonialItem.Upload.ContentType != "image/jpeg" && testemonialItem.Upload.ContentType != "image/png" && testemonialItem.Upload.ContentType != "image/gif")
            {
                ModelState.AddModelError("Upload", "Siz yalnız png,jpg və ya gif faylı yükləyə bilərsiniz");
            }

            if (testemonialItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "Şəkil məcburidir");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", testemonialItem.Photo);
                    _fileManager.Delete(oldFile);
                    var fileName = _fileManager.Upload(testemonialItem.Upload);
                    testemonialItem.Photo = fileName;
                    _context.Update(testemonialItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestemonialItemExists(testemonialItem.Id))
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
            return View(testemonialItem);
        }

        // GET: Admin/TestemonialItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testemonialItem = await _context.TestemonialItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testemonialItem == null)
            {
                return NotFound();
            }

            return View(testemonialItem);
        }

        // POST: Admin/TestemonialItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testemonialItem = await _context.TestemonialItems.FindAsync(id);
            try
            {
                _fileManager.Delete(testemonialItem.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.TestemonialItems.Remove(testemonialItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.TestemonialItems.Remove(testemonialItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestemonialItemExists(int id)
        {
            return _context.TestemonialItems.Any(e => e.Id == id);
        }
    }
}
