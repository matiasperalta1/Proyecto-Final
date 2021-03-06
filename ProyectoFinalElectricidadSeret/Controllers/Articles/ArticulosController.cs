using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProyectoFinalElectricidadSeret.Data;
using ProyectoFinalElectricidadSeret.Models;
using ProyectoFinalElectricidadSeret.Models.Accountancy;

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
            if (HttpContext.Session.Keys.Contains("FormType"))
            {
                TempData["FormType"] = HttpContext.Session.GetString("FormType");
            }
            else {
                TempData["FormType"] = "generalData";
            }
            TempData["Mode"] = mode;
            switch (mode)
            {
                case "edit":
                    TempData["FormMode"] = false;
                    TempData["ActionButtons"] = true;
                    TempData["AddButton"] = true;
                    break;
                case "add":
                    HttpContext.Session.Remove("currentArticle");
                    TempData["FormMode"] = false;
                    TempData["ActionButtons"] = true;
                    TempData["AddButton"] = true;
                    break;
                case "read":
                    TempData["FormMode"] = true;
                    TempData["ActionButtons"] = false;
                    TempData["AddButton"] = false;
                    break;
                case null:
                    TempData["Mode"] = "read";
                    TempData["FormMode"] = true;
                    TempData["ActionButtons"] = false;
                    TempData["AddButton"] = false;
                    break;
            }
            Articulo currentArticle = new Articulo();
            if (HttpContext.Session.Keys.Contains("currentArticle"))
            {
                currentArticle = JsonConvert.DeserializeObject<Articulo>(HttpContext.Session.GetString("currentArticle").ToString());
            }
            if (id != null)
            {
                currentArticle = JsonConvert.DeserializeObject<Articulo>(JsonConvert.SerializeObject(await _context.Articulos.Where(a=>a.ArtCodart==id).FirstOrDefaultAsync()));
            }
            MapSelects();
            if (currentArticle.ArtCodart != null)
            {
                ViewBag.PriceLists = await MapPriceList(currentArticle.ArtCodart.ToString());
                currentArticle.ArticStocks = await _context.ArticStocks.Where(s => s.AstCodart == currentArticle.ArtCodart).ToListAsync();
            }
            return View(currentArticle);
            
        }

        public async Task<List<PriceList>> MapPriceList(string articulo)
        {
            List<PriceList> priceList = new List<PriceList>();
            IEnumerable<Listapre> listapres = await _context.Listapres.OrderBy(l => l.LipCodlis).ToListAsync();
            Precio precio = await _context.Precios.Where(p => p.PreCodart == articulo).FirstOrDefaultAsync();
            for(var i = 1;i <= 15; i++)
            {
                PriceList price = new PriceList();
                price.NomLista = listapres.ToList()[i-1].LipNombre;
                price.NroLista = listapres.ToList()[i-1].LipCodlis;
                price.PConIva = (decimal)precio.GetType().GetProperty("PrePvci" + i.ToString("000")).GetValue(precio, null);
                price.PSinIva = (decimal)precio.GetType().GetProperty("PrePvsi" + i.ToString("000")).GetValue(precio, null);
                price.Utilidad = (decimal)precio.GetType().GetProperty("PreUtil" + i.ToString("000")).GetValue(precio, null);
                price.TipoAct = (string)precio.GetType().GetProperty("PreTcal" + i.ToString("000")).GetValue(precio, null);
                int codmoneda= Int32.Parse(precio.GetType().GetProperty("PreCmon" + i.ToString("000")).GetValue(precio, null).ToString());
                price.Moneda = await _context.Monedas.Where(m => m.MonCodmon == codmoneda).Select(m => m.MonDescri).FirstOrDefaultAsync();
                priceList.Add(price);
            }
            return priceList;

        }

        public async void MapSelects() {
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
            if (!TempData.ContainsKey("selectedIva"))
            {
                TempData["selectedIva"] = "Seleccione un tipo de Iva";
            }
            if (!TempData.ContainsKey("selectedCurrency"))
            {
                TempData["selectedCurrency"] = "Seleccione un tipo de Moneda";
            }
            ViewBag.ArticleTypes = await _context.Tipoarts.ToListAsync();
            ViewBag.ArticleCategory = await _context.Rubros.ToListAsync();
            ViewBag.ArticleSubCategory = await _context.Subrubros.ToListAsync();
            ViewBag.ArticleLine = await _context.Lineas.ToListAsync();
            ViewBag.ArticleBrand = await _context.Marcas.ToListAsync();
            ViewBag.ArticleIva = await _context.Ivas.ToListAsync();
            ViewBag.ArticleCurrency = await _context.Monedas.ToListAsync();
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
                TempData["selectedCurrency"] = await _context.Monedas.Where(c => c.MonCodmon == currentArticle.ArtCodmon).Select(c => c.MonDescri).FirstOrDefaultAsync();
                TempData["selectedIva"] = articulo.ArtValiva.ToString();
                HttpContext.Session.SetString("currentArticle", JsonConvert.SerializeObject(currentArticle));
            }
            else
            {
                ViewBag.ErrorMessage = "El articulo ingresado no se encuentra.";
            }
            return RedirectToAction("ArticlesABMC", "Articulos");
        }

        public async Task<IActionResult> ChangeMode(string mode) 
        {
            HttpContext.Session.SetString("FormType", mode);
            return RedirectToAction("ArticlesABMC", "Articulos", new { mode = TempData["Mode"].ToString() });
        }
        [HttpPost]
        public async Task<IActionResult> SaveGeneralData(Articulo articulo)
        {
            Articulo originalArticle = JsonConvert.DeserializeObject<Articulo>(HttpContext.Session.GetString("currentArticle"));
            //Mepeo solo los campos que cambiaron para no peder los que no tienen input en esta pestaña
            originalArticle.ArtCodart = articulo.ArtCodart;
            originalArticle.ArtCodbar = articulo.ArtCodbar;
            originalArticle.ArtCodori = articulo.ArtCodori;
            originalArticle.ArtDescri = articulo.ArtDescri;
            originalArticle.ArtDescrl = articulo.ArtDescrl;
            originalArticle.ArtCodtar = articulo.ArtCodtar;
            originalArticle.ArtDiscon = articulo.ArtDiscon;
            originalArticle.ArtDispon = articulo.ArtDispon;
            originalArticle.ArtCompue = articulo.ArtCompue;
            originalArticle.ArtAcondi = articulo.ArtAcondi;
            originalArticle.ArtCodrub = articulo.ArtCodrub;
            originalArticle.ArtCodsru = articulo.ArtCodsru;
            originalArticle.ArtCodlin = articulo.ArtCodlin;
            originalArticle.ArtCodmar = articulo.ArtCodmar;
            originalArticle.ArtUmcomp = articulo.ArtUmcomp;
            originalArticle.ArtUmvent = articulo.ArtUmvent;
            originalArticle.ArtCoefcv = articulo.ArtCoefcv;
            HttpContext.Session.SetString("currentArticle", JsonConvert.SerializeObject(originalArticle));
            return RedirectToAction("ArticlesABMC", "Articulos", new { mode = TempData["Mode"].ToString() });
        }

        public async Task<IActionResult> SavePriceData(Articulo articulo)
        {
            Articulo originalArticle = JsonConvert.DeserializeObject<Articulo>(HttpContext.Session.GetString("currentArticle"));
            originalArticle.ArtPrecos = articulo.ArtPrecos;
            originalArticle.ArtDtocom = articulo.ArtDtocom;
            originalArticle.ArtDtovta = articulo.ArtDtovta;
            originalArticle.ArtComvta = articulo.ArtComvta;
            originalArticle.ArtValiva = articulo.ArtValiva;
            originalArticle.ArtCodmon = articulo.ArtCodmon;
            HttpContext.Session.SetString("currentArticle", JsonConvert.SerializeObject(originalArticle));
            return RedirectToAction("ArticlesABMC", "Articulos", new { mode = TempData["Mode"].ToString()});
        }

        public async Task<IActionResult> SaveStockData(Articulo articulo)
        {
            Articulo originalArticle = JsonConvert.DeserializeObject<Articulo>(HttpContext.Session.GetString("currentArticle"));
            originalArticle.ArtStomax = articulo.ArtStomax;
            originalArticle.ArtStomin = articulo.ArtStomin;
            originalArticle.ArtStover = articulo.ArtStover;
            HttpContext.Session.SetString("currentArticle", JsonConvert.SerializeObject(originalArticle));
            return RedirectToAction("ArticlesABMC", "Articulos", new { mode = TempData["Mode"].ToString() });
        }

        public async Task<IActionResult> CancelAction()
        {
            HttpContext.Session.Remove("currentArticle");
            return RedirectToAction("ArticlesABMC", "Articulos", new {mode="read"});
        }


    }
}
