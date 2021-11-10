using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalElectricidadSeret.Data;
using ProyectoFinalElectricidadSeret.Models;
using Microsoft.AspNetCore.Http;

namespace ProyectoFinalElectricidadSeret.Controllers.Util
{
    public class UsuaMenusController : Controller
    {
        private readonly AppDbContext _context;

        public UsuaMenusController(AppDbContext context)
        {
            _context = context;
        }


        // GET: UsuaMenus
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.UsuaMenus.Include(u => u.UymCodmenNavigation);
            return View(await appDbContext.ToListAsync());
        }

        // GET: UsuaMenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuaMenu = await _context.UsuaMenus
                .Include(u => u.UymCodmenNavigation)
                .FirstOrDefaultAsync(m => m.UymCodmen == id);
            if (usuaMenu == null)
            {
                return NotFound();
            }

            return View(usuaMenu);
        }

        // GET: UsuaMenus/Create
        public IActionResult Create()
        {
            ViewData["UymCodmen"] = new SelectList(_context.Menus, "MenCodmen", "MenCodmen");
            return View();
        }

        // POST: UsuaMenus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UymCodmen,UymCodusu,UymNumopc,UymDesopc,UymNivacc")] UsuaMenu usuaMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuaMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UymCodmen"] = new SelectList(_context.Menus, "MenCodmen", "MenCodmen", usuaMenu.UymCodmen);
            return View(usuaMenu);
        }

        // GET: UsuaMenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuaMenu = await _context.UsuaMenus.FindAsync(id);
            if (usuaMenu == null)
            {
                return NotFound();
            }
            ViewData["UymCodmen"] = new SelectList(_context.Menus, "MenCodmen", "MenCodmen", usuaMenu.UymCodmen);
            return View(usuaMenu);
        }

        // POST: UsuaMenus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UymCodmen,UymCodusu,UymNumopc,UymDesopc,UymNivacc")] UsuaMenu usuaMenu)
        {
            if (id != usuaMenu.UymCodmen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuaMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuaMenuExists(usuaMenu.UymCodmen))
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
            ViewData["UymCodmen"] = new SelectList(_context.Menus, "MenCodmen", "MenCodmen", usuaMenu.UymCodmen);
            return View(usuaMenu);
        }

        // GET: UsuaMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuaMenu = await _context.UsuaMenus
                .Include(u => u.UymCodmenNavigation)
                .FirstOrDefaultAsync(m => m.UymCodmen == id);
            if (usuaMenu == null)
            {
                return NotFound();
            }

            return View(usuaMenu);
        }

        // POST: UsuaMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuaMenu = await _context.UsuaMenus.FindAsync(id);
            _context.UsuaMenus.Remove(usuaMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuaMenuExists(int id)
        {
            return _context.UsuaMenus.Any(e => e.UymCodmen == id);
        }
    }
}
