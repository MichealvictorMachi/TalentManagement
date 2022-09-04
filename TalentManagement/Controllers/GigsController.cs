using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TalentManagement.Models;

namespace TalentManagement.Controllers
{
    public class GigsController : Controller
    {
        private readonly Talent_ManagementContext _context;

        public GigsController(Talent_ManagementContext context)
        {
            _context = context;
        }

        // GET: Gigs
        public async Task<IActionResult> Index()
        {
              return _context.Gigs != null ? 
                          View(await _context.Gigs.ToListAsync()) :
                          Problem("Entity set 'Talent_ManagementContext.Gigs'  is null.");
        }

        // GET: Gigs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Gigs == null)
            {
                return NotFound();
            }

            var gig = await _context.Gigs
                .FirstOrDefaultAsync(m => m.GigsId == id);
            if (gig == null)
            {
                return NotFound();
            }

            return View(gig);
        }

        // GET: Gigs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gigs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GigsId,GigDate,VenueName,ArtisteId,IncomeGenerated")] Gig gig)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gig);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gig);
        }

        // GET: Gigs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Gigs == null)
            {
                return NotFound();
            }

            var gig = await _context.Gigs.FindAsync(id);
            if (gig == null)
            {
                return NotFound();
            }
            return View(gig);
        }

        // POST: Gigs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GigsId,GigDate,VenueName,ArtisteId,IncomeGenerated")] Gig gig)
        {
            if (id != gig.GigsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gig);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GigExists(gig.GigsId))
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
            return View(gig);
        }

        // GET: Gigs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Gigs == null)
            {
                return NotFound();
            }

            var gig = await _context.Gigs
                .FirstOrDefaultAsync(m => m.GigsId == id);
            if (gig == null)
            {
                return NotFound();
            }

            return View(gig);
        }

        // POST: Gigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Gigs == null)
            {
                return Problem("Entity set 'Talent_ManagementContext.Gigs'  is null.");
            }
            var gig = await _context.Gigs.FindAsync(id);
            if (gig != null)
            {
                _context.Gigs.Remove(gig);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GigExists(int id)
        {
          return (_context.Gigs?.Any(e => e.GigsId == id)).GetValueOrDefault();
        }
    }
}
