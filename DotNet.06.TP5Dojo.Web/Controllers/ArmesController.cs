using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO;

namespace DotNet._06.TP5Dojo.Web.Controllers
{
    public class ArmesController : Controller
    {
        private readonly DojoContext _context;

        public ArmesController(DojoContext context)
        {
            _context = context;
        }

        // GET: Armes
        public async Task<IActionResult> Index()
        {
              return _context.Arme != null ? 
                          View(await _context.Arme.ToListAsync()) :
                          Problem("Entity set 'DojoContext.Arme'  is null.");
        }

        // GET: Armes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Arme == null)
            {
                return NotFound();
            }

            var arme = await _context.Arme
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arme == null)
            {
                return NotFound();
            }

            return View(arme);
        }

        // GET: Armes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Armes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Degats")] Arme arme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arme);
        }

        // GET: Armes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Arme == null)
            {
                return NotFound();
            }

            var arme = await _context.Arme.FindAsync(id);
            if (arme == null)
            {
                return NotFound();
            }
            return View(arme);
        }

        // POST: Armes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Degats")] Arme arme)
        {
            if (id != arme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArmeExists(arme.Id))
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
            return View(arme);
        }

        // GET: Armes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Arme == null)
            {
                return NotFound();
            }

            var arme = await _context.Arme
                .FirstOrDefaultAsync(m => m.Id == id);
            if (arme == null)
            {
                return NotFound();
            }

            return View(arme);
        }

        // POST: Armes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Arme == null)
            {
                return Problem("Entity set 'DojoContext.Arme'  is null.");
            }
            var arme = await _context.Arme.FindAsync(id);
            if (arme != null)
            {
                _context.Arme.Remove(arme);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArmeExists(int id)
        {
          return (_context.Arme?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
