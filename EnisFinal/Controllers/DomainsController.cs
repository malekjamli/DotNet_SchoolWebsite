﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnisFinal.Data;
using EnisFinal.Models;

namespace EnisFinal.Controllers
{
    public class DomainsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DomainsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Domains
        public async Task<IActionResult> Index()
        {
              return View(await _context.Domain.ToListAsync());
        }

        // GET: Domains/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Domain == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain
                .FirstOrDefaultAsync(m => m.DomainId == id);
            if (domain == null)
            {
                return NotFound();
            }

            return View(domain);
        }

        // GET: Domains/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Domains/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DomainId,Name")] Domain domain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(domain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(domain);
        }

        // GET: Domains/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Domain == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain.FindAsync(id);
            if (domain == null)
            {
                return NotFound();
            }
            return View(domain);
        }

        // POST: Domains/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DomainId,Name")] Domain domain)
        {
            if (id != domain.DomainId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(domain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DomainExists(domain.DomainId))
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
            return View(domain);
        }

        // GET: Domains/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Domain == null)
            {
                return NotFound();
            }

            var domain = await _context.Domain
                .FirstOrDefaultAsync(m => m.DomainId == id);
            if (domain == null)
            {
                return NotFound();
            }

            return View(domain);
        }

        // POST: Domains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Domain == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Domain'  is null.");
            }
            var domain = await _context.Domain.FindAsync(id);
            if (domain != null)
            {
                _context.Domain.Remove(domain);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DomainExists(int id)
        {
          return _context.Domain.Any(e => e.DomainId == id);
        }
    }
}
