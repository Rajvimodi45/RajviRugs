using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RajviRugs.Data;
using RajviRugs.Models;

namespace RajviRugs.Controllers
{
    public class RugsController : Controller
    {
        private readonly RajviRugsContext _context;

        public RugsController(RajviRugsContext context)
        {
            _context = context;
        }

        // GET: Rugs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rugs.ToListAsync());
        }

        // GET: Rugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rugs = await _context.Rugs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rugs == null)
            {
                return NotFound();
            }

            return View(rugs);
        }

        // GET: Rugs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rugs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Color,Type,Price,Rating")] Rugs rugs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rugs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rugs);
        }

        // GET: Rugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rugs = await _context.Rugs.FindAsync(id);
            if (rugs == null)
            {
                return NotFound();
            }
            return View(rugs);
        }

        // POST: Rugs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Rugs rugs)
        {
            if (id != rugs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rugs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RugsExists(rugs.Id))
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
            return View(rugs);
        }

        // GET: Rugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rugs = await _context.Rugs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rugs == null)
            {
                return NotFound();
            }

            return View(rugs);
        }

        // POST: Rugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rugs = await _context.Rugs.FindAsync(id);
            _context.Rugs.Remove(rugs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RugsExists(int id)
        {
            return _context.Rugs.Any(e => e.Id == id);
        }
    }
}
