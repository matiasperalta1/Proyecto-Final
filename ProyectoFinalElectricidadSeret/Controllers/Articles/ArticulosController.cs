using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProyectoFinalElectricidadSeret.Data;
using ProyectoFinalElectricidadSeret.Models;

namespace ProyectoFinalElectricidadSeret.Controllers.Articles
{
    public class ArticulosController : Controller
    {
        private readonly AppDbContext _context;

        public ArticulosController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> ArticlesABMC(string mode, string id)
        {
            switch (mode)
            {
                case "edit":
                    TempData["FormMode"] = false;
                    TempData["ActionButtons"] = true;
                    TempData["AddButton"] = true;
                    break;
                case "add":
                    TempData["FormMode"] = false;
                    TempData["ActionButtons"] = true;
                    TempData["AddButton"] = true;
                    break;
                case null:
                    TempData["FormMode"] = true;
                    TempData["ActionButtons"] = false;
                    TempData["AddButton"] = false;
                    break;
            }
            Articulo currentArticle = new Articulo();
            if (TempData.ContainsKey("currentArticle"))
            {
                currentArticle = JsonConvert.DeserializeObject<Articulo>(TempData["currentArticle"].ToString());
            }
            if (id != null)
            {
                currentArticle = JsonConvert.DeserializeObject<Articulo>(JsonConvert.SerializeObject(await _context.Articulos.Where(a=>a.ArtCodart==id).FirstOrDefaultAsync()));
            }
            MapSelects();
            IEnumerable<Tipoart> articleTypes = await _context.Tipoarts.ToListAsync();
            ViewBag.ArticleTypes = articleTypes;
            ViewBag.ArticleCategory = await _context.Rubros.ToListAsync();
            ViewBag.ArticleSubCategory = await _context.Subrubros.ToListAsync();
            ViewBag.ArticleLine = await _context.Lineas.ToListAsync();
            ViewBag.ArticleBrand = await _context.Marcas.ToListAsync();
            return View(currentArticle);
            
        }

        public void MapSelects() {
            if (!TempData.ContainsKey("selectedCategory"))
            {
                TempData["selectedCategory"] = "Seleccione un Rubro";
            }
            if (!TempData.ContainsKey("selectedSubCategory"))
            {
                TempData["selectedSubCategory"] = "Seleccione un Sub Rubro";
            }
            if (!TempData.ContainsKey("selectedLine"))
            {
                TempData["selectedLine"] = "Seleccione una Linea";
            }
            if (!TempData.ContainsKey("selectedBrand"))
            {
                TempData["selectedBrand"] = "Seleccione una Marca";
            }
        }

        public async Task<IActionResult> GetArticle(Articulo articulo)
        {
            Articulo currentArticle = new Articulo();
            currentArticle = await _context.Articulos.Where(a => a.ArtCodart == articulo.ArtCodart).FirstOrDefaultAsync();
            if (currentArticle != null)
            {
                TempData["selectedCategory"] = await _context.Rubros.Where(r => r.RubCodrub == currentArticle.ArtCodrub).Select(r => r.RubDescri).FirstOrDefaultAsync();
                TempData["selectedSubCategory"] = await _context.Subrubros.Where(s => s.SruCodsru == currentArticle.ArtCodsru).Select(s => s.SruDescri).FirstOrDefaultAsync();
                TempData["selectedLine"] = await _context.Lineas.Where(l => l.LinCodlin == currentArticle.ArtCodlin).Select(l => l.LinDescri).FirstOrDefaultAsync();
                TempData["selectedBrand"] = await _context.Marcas.Where(m => m.MarCodmar == currentArticle.ArtCodmar).Select(m => m.MarDescri).FirstOrDefaultAsync();
                TempData["currentArticle"] = JsonConvert.SerializeObject(currentArticle);
            }
            else
            {
                ViewBag.ErrorMessage = "El articulo ingresado no se encuentra.";
            }
            return RedirectToAction("ArticlesABMC", "Articulos");
        }


        public async Task<IActionResult> CancelAction()
        {
            return RedirectToAction("ArticlesABMC", "Articulos");
        }


    }
}
