using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Chinook.Data;
using Chinook.Models;

namespace Chinook.Controllers
{
    public class CancionsController : Controller
    {
        private readonly ChinookContext _context;

        public CancionsController(ChinookContext context)
        {
            _context = context;
        }

        // GET: Cancions
        public async Task<IActionResult> Index()
        {
            var chinookContext = _context.Cancion.Include(c => c.Album).Include(c => c.Genero);
            return View(await chinookContext.ToListAsync());
        }


        // GET: Cancions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cancion = await _context.Cancion
                .Include(c => c.Album)
                .Include(c => c.Genero)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cancion == null)
            {
                return NotFound();
            }

            return View(cancion);
        }

        // GET: Cancions/Create
        public IActionResult Create()
        {
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id");
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Id");
            return View();
        }

        // POST: Cancions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,AlbumId,GeneroId")] Cancion cancion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cancion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", cancion.AlbumId);
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Id", cancion.GeneroId);
            return View(cancion);
        }

        // GET: Cancions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cancion = await _context.Cancion.FindAsync(id);
            if (cancion == null)
            {
                return NotFound();
            }
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", cancion.AlbumId);
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Id", cancion.GeneroId);
            return View(cancion);
        }

        // POST: Cancions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,AlbumId,GeneroId")] Cancion cancion)
        {
            if (id != cancion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cancion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CancionExists(cancion.Id))
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
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", cancion.AlbumId);
            ViewData["GeneroId"] = new SelectList(_context.Genero, "Id", "Id", cancion.GeneroId);
            return View(cancion);
        }

        // GET: Cancions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cancion = await _context.Cancion
                .Include(c => c.Album)
                .Include(c => c.Genero)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cancion == null)
            {
                return NotFound();
            }

            return View(cancion);
        }

        // POST: Cancions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cancion = await _context.Cancion.FindAsync(id);
            _context.Cancion.Remove(cancion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CancionExists(int id)
        {
            return _context.Cancion.Any(e => e.Id == id);
        }
    }
}
