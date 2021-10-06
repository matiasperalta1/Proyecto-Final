using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalElectricidadSeret.Models;
using ProyectoFinalElectricidadSeret.Models.Data;

namespace ProyectoFinalElectricidadSeret.Controllers.Articles
{
    public class ArticulosController : Controller
    {
        private readonly AppDbContext _context;

        public ArticulosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Articulos
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Articulos.Include(a => a.ArtCodlinNavigation).Include(a => a.ArtCodmarNavigation).Include(a => a.ArtCodmonNavigation).Include(a => a.ArtCodproNavigation).Include(a => a.ArtCodrubNavigation).Include(a => a.ArtCodsruNavigation).Include(a => a.ArtCodtarNavigation);
            return View(await appDbContext.Where(a => a.ArtDescri.Contains("lampara")).ToListAsync());
        }

        // GET: Articulos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulos
                .Include(a => a.ArtCodlinNavigation)
                .Include(a => a.ArtCodmarNavigation)
                .Include(a => a.ArtCodmonNavigation)
                .Include(a => a.ArtCodproNavigation)
                .Include(a => a.ArtCodrubNavigation)
                .Include(a => a.ArtCodsruNavigation)
                .Include(a => a.ArtCodtarNavigation)
                .FirstOrDefaultAsync(m => m.ArtCodart == id);
            if (articulo == null)
            {
                return NotFound();
            }

            return View(articulo);
        }

        // GET: Articulos/Create
        public IActionResult Create()
        {
            ViewData["ArtCodlin"] = new SelectList(_context.Lineas, "LinCodlin", "LinCodlin");
            ViewData["ArtCodmar"] = new SelectList(_context.Marcas, "MarCodmar", "MarCodmar");
            ViewData["ArtCodmon"] = new SelectList(_context.Monedas, "MonCodmon", "MonCodmon");
            ViewData["ArtCodpro"] = new SelectList(_context.Proveedores, "ProCodpro", "ProCodpro");
            ViewData["ArtCodrub"] = new SelectList(_context.Rubros, "RubCodrub", "RubCodrub");
            ViewData["ArtCodsru"] = new SelectList(_context.Subrubros, "SruCodsru", "SruCodsru");
            ViewData["ArtCodtar"] = new SelectList(_context.Tipoarts, "TarCodtar", "TarCodtar");
            return View();
        }

        // POST: Articulos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtCodart,ArtCodbar,ArtCodori,ArtDescri,ArtDescrl,ArtDiscon,ArtCodlin,ArtCodrub,ArtCodsru,ArtCodmar,ArtEmbala,ArtUmcomp,ArtUmvent,ArtCoefcv,ArtStoact,ArtStocom,ArtCanped,ArtStomin,ArtStomax,ArtObserv,ArtCodpro,ArtUltcom,ArtUltact,ArtPrecos,ArtDtocom,ArtValiva,ArtCodmon,ArtTipimp,ArtImpues,ArtDtovta,ArtComvta,ArtImagen,ArtCtacom,ArtCtavta,ArtCcocom,ArtCcovta,ArtUspart,ArtUsseri,ArtPromoc,ArtEquiva,ArtCodtar,ArtCompue,ArtDispon,ArtCodcab,ArtStover,ArtAcondi,ArtImaux1,ArtImaux2,ArtImaux3,ArtImaux4,ArtEcopro,ArtEcomp1,ArtEcomp2,ArtEcomp3,ArtDestac,ArtAlto,ArtAncho,ArtProfun,ArtPeso,ArtVolume,ArtAgrmp1,ArtAgrmp2,ArtAgrmp3,ArtTags")] Articulo articulo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(articulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtCodlin"] = new SelectList(_context.Lineas, "LinCodlin", "LinCodlin", articulo.ArtCodlin);
            ViewData["ArtCodmar"] = new SelectList(_context.Marcas, "MarCodmar", "MarCodmar", articulo.ArtCodmar);
            ViewData["ArtCodmon"] = new SelectList(_context.Monedas, "MonCodmon", "MonCodmon", articulo.ArtCodmon);
            ViewData["ArtCodpro"] = new SelectList(_context.Proveedores, "ProCodpro", "ProCodpro", articulo.ArtCodpro);
            ViewData["ArtCodrub"] = new SelectList(_context.Rubros, "RubCodrub", "RubCodrub", articulo.ArtCodrub);
            ViewData["ArtCodsru"] = new SelectList(_context.Subrubros, "SruCodsru", "SruCodsru", articulo.ArtCodsru);
            ViewData["ArtCodtar"] = new SelectList(_context.Tipoarts, "TarCodtar", "TarCodtar", articulo.ArtCodtar);
            return View(articulo);
        }

        // GET: Articulos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }
            ViewData["ArtCodlin"] = new SelectList(_context.Lineas, "LinCodlin", "LinCodlin", articulo.ArtCodlin);
            ViewData["ArtCodmar"] = new SelectList(_context.Marcas, "MarCodmar", "MarCodmar", articulo.ArtCodmar);
            ViewData["ArtCodmon"] = new SelectList(_context.Monedas, "MonCodmon", "MonCodmon", articulo.ArtCodmon);
            ViewData["ArtCodpro"] = new SelectList(_context.Proveedores, "ProCodpro", "ProCodpro", articulo.ArtCodpro);
            ViewData["ArtCodrub"] = new SelectList(_context.Rubros, "RubCodrub", "RubCodrub", articulo.ArtCodrub);
            ViewData["ArtCodsru"] = new SelectList(_context.Subrubros, "SruCodsru", "SruCodsru", articulo.ArtCodsru);
            ViewData["ArtCodtar"] = new SelectList(_context.Tipoarts, "TarCodtar", "TarCodtar", articulo.ArtCodtar);
            return View(articulo);
        }

        // POST: Articulos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ArtCodart,ArtCodbar,ArtCodori,ArtDescri,ArtDescrl,ArtDiscon,ArtCodlin,ArtCodrub,ArtCodsru,ArtCodmar,ArtEmbala,ArtUmcomp,ArtUmvent,ArtCoefcv,ArtStoact,ArtStocom,ArtCanped,ArtStomin,ArtStomax,ArtObserv,ArtCodpro,ArtUltcom,ArtUltact,ArtPrecos,ArtDtocom,ArtValiva,ArtCodmon,ArtTipimp,ArtImpues,ArtDtovta,ArtComvta,ArtImagen,ArtCtacom,ArtCtavta,ArtCcocom,ArtCcovta,ArtUspart,ArtUsseri,ArtPromoc,ArtEquiva,ArtCodtar,ArtCompue,ArtDispon,ArtCodcab,ArtStover,ArtAcondi,ArtImaux1,ArtImaux2,ArtImaux3,ArtImaux4,ArtEcopro,ArtEcomp1,ArtEcomp2,ArtEcomp3,ArtDestac,ArtAlto,ArtAncho,ArtProfun,ArtPeso,ArtVolume,ArtAgrmp1,ArtAgrmp2,ArtAgrmp3,ArtTags")] Articulo articulo)
        {
            if (id != articulo.ArtCodart)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(articulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticuloExists(articulo.ArtCodart))
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
            ViewData["ArtCodlin"] = new SelectList(_context.Lineas, "LinCodlin", "LinCodlin", articulo.ArtCodlin);
            ViewData["ArtCodmar"] = new SelectList(_context.Marcas, "MarCodmar", "MarCodmar", articulo.ArtCodmar);
            ViewData["ArtCodmon"] = new SelectList(_context.Monedas, "MonCodmon", "MonCodmon", articulo.ArtCodmon);
            ViewData["ArtCodpro"] = new SelectList(_context.Proveedores, "ProCodpro", "ProCodpro", articulo.ArtCodpro);
            ViewData["ArtCodrub"] = new SelectList(_context.Rubros, "RubCodrub", "RubCodrub", articulo.ArtCodrub);
            ViewData["ArtCodsru"] = new SelectList(_context.Subrubros, "SruCodsru", "SruCodsru", articulo.ArtCodsru);
            ViewData["ArtCodtar"] = new SelectList(_context.Tipoarts, "TarCodtar", "TarCodtar", articulo.ArtCodtar);
            return View(articulo);
        }

        // GET: Articulos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var articulo = await _context.Articulos
                .Include(a => a.ArtCodlinNavigation)
                .Include(a => a.ArtCodmarNavigation)
                .Include(a => a.ArtCodmonNavigation)
                .Include(a => a.ArtCodproNavigation)
                .Include(a => a.ArtCodrubNavigation)
                .Include(a => a.ArtCodsruNavigation)
                .Include(a => a.ArtCodtarNavigation)
                .FirstOrDefaultAsync(m => m.ArtCodart == id);
            if (articulo == null)
            {
                return NotFound();
            }

            ViewBag.Rubros = _context.Rubros.Find();

            return View(articulo);
        }

        // POST: Articulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            _context.Articulos.Remove(articulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticuloExists(string id)
        {
            return _context.Articulos.Any(e => e.ArtCodart == id);
        }
    }
}
