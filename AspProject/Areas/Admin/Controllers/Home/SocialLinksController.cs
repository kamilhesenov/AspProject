﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspProject.Data;
using AspProject.Models.Home;

namespace AspProject.Areas.Admin.Controllers.Home
{
    [Area("Admin")]
    public class SocialLinksController : Controller
    {
        private readonly AplicationDbContext _context;

        public SocialLinksController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SocialLinks
        public async Task<IActionResult> Index()
        {
            return View(await _context.SocialLinks.ToListAsync());
        }

        // GET: Admin/SocialLinks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialLink = await _context.SocialLinks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialLink == null)
            {
                return NotFound();
            }

            return View(socialLink);
        }

        // GET: Admin/SocialLinks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SocialLinks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Facebook,Twitter,Linkedin,Dribbble")] SocialLink socialLink)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socialLink);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socialLink);
        }

        // GET: Admin/SocialLinks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialLink = await _context.SocialLinks.FindAsync(id);
            if (socialLink == null)
            {
                return NotFound();
            }
            return View(socialLink);
        }

        // POST: Admin/SocialLinks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Facebook,Twitter,Linkedin,Dribbble")] SocialLink socialLink)
        {
            if (id != socialLink.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socialLink);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialLinkExists(socialLink.Id))
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
            return View(socialLink);
        }

        // GET: Admin/SocialLinks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialLink = await _context.SocialLinks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialLink == null)
            {
                return NotFound();
            }

            return View(socialLink);
        }

        // POST: Admin/SocialLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socialLink = await _context.SocialLinks.FindAsync(id);
            _context.SocialLinks.Remove(socialLink);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocialLinkExists(int id)
        {
            return _context.SocialLinks.Any(e => e.Id == id);
        }
    }
}
