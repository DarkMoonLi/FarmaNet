﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FarmaNetBackend.Data;
using FarmaNetBackend.Models;

namespace FarmaNetBackend.Controllers
{
    public class ManufacturersController : Controller
    {
        private readonly PharmacyDbContext _context;

        public ManufacturersController(PharmacyDbContext context)
        {
            _context = context;
        }

        // GET: Manufacturers
        public async Task<IActionResult> Index()
        {
              return View(await _context.Manufacturers.ToListAsync());
        }

        // GET: Manufacturers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Manufacturers == null)
            {
                return NotFound();
            }

            var manufacturer = await _context.Manufacturers
                .FirstOrDefaultAsync(m => m.IdManufacturer == id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            return View(manufacturer);
        }

        // GET: Manufacturers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manufacturers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdManufacturer,Name,Address")] Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manufacturer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manufacturer);
        }

        // GET: Manufacturers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Manufacturers == null)
            {
                return NotFound();
            }

            var manufacturer = await _context.Manufacturers.FindAsync(id);
            if (manufacturer == null)
            {
                return NotFound();
            }
            return View(manufacturer);
        }

        // POST: Manufacturers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdManufacturer,Name,Address")] Manufacturer manufacturer)
        {
            if (id != manufacturer.IdManufacturer)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(manufacturer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManufacturerExists(manufacturer.IdManufacturer))
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
            return View(manufacturer);
        }

        // GET: Manufacturers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Manufacturers == null)
            {
                return NotFound();
            }

            var manufacturer = await _context.Manufacturers
                .FirstOrDefaultAsync(m => m.IdManufacturer == id);
            if (manufacturer == null)
            {
                return NotFound();
            }

            return View(manufacturer);
        }

        // POST: Manufacturers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Manufacturers == null)
            {
                return Problem("Entity set 'PharmacyDbContext.Manufacturers'  is null.");
            }
            var manufacturer = await _context.Manufacturers.FindAsync(id);
            if (manufacturer != null)
            {
                _context.Manufacturers.Remove(manufacturer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManufacturerExists(int id)
        {
          return _context.Manufacturers.Any(e => e.IdManufacturer == id);
        }
    }
}
*/