using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Arpagen.Models;

namespace Arpagen.Controllers
{
    public class AreasComumController : Controller
    {
        private readonly AppDbContext _context;

        public AreasComumController(AppDbContext context)
        {
            _context = context;
        }

        // GET: AreasComum
        public async Task<IActionResult> Index()
        {
              return View(await _context.AreasComum.ToListAsync());
        }

        // GET: AreasComum/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AreasComum == null)
            {
                return NotFound();
            }

            var areaComum = await _context.AreasComum
                .FirstOrDefaultAsync(m => m.Id == id);
            if (areaComum == null)
            {
                return NotFound();
            }

            return View(areaComum);
        }

        // GET: AreasComum/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AreasComum/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Bloco,Apartamento,Data")] AreaComum areaComum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(areaComum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(areaComum);
        }

        // GET: AreasComum/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AreasComum == null)
            {
                return NotFound();
            }

            var areaComum = await _context.AreasComum.FindAsync(id);
            if (areaComum == null)
            {
                return NotFound();
            }
            return View(areaComum);
        }

        // POST: AreasComum/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Bloco,Apartamento,Data")] AreaComum areaComum)
        {
            if (id != areaComum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(areaComum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AreaComumExists(areaComum.Id))
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
            return View(areaComum);
        }

        // GET: AreasComum/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AreasComum == null)
            {
                return NotFound();
            }

            var areaComum = await _context.AreasComum
                .FirstOrDefaultAsync(m => m.Id == id);
            if (areaComum == null)
            {
                return NotFound();
            }

            return View(areaComum);
        }

        // POST: AreasComum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AreasComum == null)
            {
                return Problem("Entity set 'AppDbContext.AreasComum'  is null.");
            }
            var areaComum = await _context.AreasComum.FindAsync(id);
            if (areaComum != null)
            {
                _context.AreasComum.Remove(areaComum);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AreaComumExists(int id)
        {
          return _context.AreasComum.Any(e => e.Id == id);
        }
    }
}
