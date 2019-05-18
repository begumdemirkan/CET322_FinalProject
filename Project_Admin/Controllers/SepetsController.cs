using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_Admin.Data;
using Project_Admin.Models;

namespace Project_Admin.Controllers
{
    public class SepetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SepetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sepets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sepets.ToListAsync());
        }

        // GET: Sepets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sepet = await _context.Sepets
                .FirstOrDefaultAsync(m => m.SepetId == id);
            if (sepet == null)
            {
                return NotFound();
            }

            return View(sepet);
        }

        // GET: Sepets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sepets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SepetId,Quantity")] Sepet sepet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sepet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sepet);
        }

        // GET: Sepets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sepet = await _context.Sepets.FindAsync(id);
            if (sepet == null)
            {
                return NotFound();
            }
            return View(sepet);
        }

        // POST: Sepets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SepetId,Quantity")] Sepet sepet)
        {
            if (id != sepet.SepetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sepet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SepetExists(sepet.SepetId))
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
            return View(sepet);
        }

        // GET: Sepets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sepet = await _context.Sepets
                .FirstOrDefaultAsync(m => m.SepetId == id);
            if (sepet == null)
            {
                return NotFound();
            }

            return View(sepet);
        }

        // POST: Sepets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sepet = await _context.Sepets.FindAsync(id);
            _context.Sepets.Remove(sepet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SepetExists(int id)
        {
            return _context.Sepets.Any(e => e.SepetId == id);
        }
    }
}
