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

namespace ProyectoFinalElectricidadSeret.Controllers.Clients
{
    public class ClientesController : Controller
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> ClientsABMC(string mode, decimal id)
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
            Cliente currentClient = new Cliente();
            if (TempData.ContainsKey("currentClient"))
            {
                currentClient = JsonConvert.DeserializeObject<Cliente>(TempData["currentClient"].ToString());
            }
            if (id != 0)
            {
                currentClient = JsonConvert.DeserializeObject<Cliente>(JsonConvert.SerializeObject(await _context.Clientes.Where(a => a.CliCodcli == id).FirstOrDefaultAsync()));
            }
            MapSelects();
            IEnumerable<Tiposdocumento> documentTypes = await _context.Tiposdocumentos.ToListAsync();
            ViewBag.documentTypes = documentTypes;
            ViewBag.clientProvince = await _context.Provincias.ToListAsync();
            ViewBag.clientLocation = await _context.Localidades.ToListAsync();
            return View(currentClient);

        }
        public void MapSelects()
        {
            if (!TempData.ContainsKey("selectedProvince"))
            {
                TempData["selectedProvince"] = "Seleccione una provincia";
            }
            if (!TempData.ContainsKey("selectedLocation"))
            {
                TempData["selectedLocation"] = "Seleccione una localidad";
            }
        }

        public async Task<IActionResult> GetClient(Cliente cliente)
        {
            Cliente currentClient = new Cliente();
            currentClient = await _context.Clientes.Where(c => c.CliCodcli == cliente.CliCodcli).FirstOrDefaultAsync();
            if (currentClient != null)
            {
                TempData["currentClient"] = JsonConvert.SerializeObject(currentClient);
                TempData["selectedProvince"] = await _context.Provincias.Where(p => p.PrvCodprv == currentClient.CliCodprv).Select(r => r.PrvDescri).FirstOrDefaultAsync();
                TempData["selectedLocation"] = await _context.Localidades.Where(l => l.LocCodloc == currentClient.CliCodloc).Select(s => s.LocDescri).FirstOrDefaultAsync();
            }
            else
            {
                ViewBag.ErrorMessage = "El cliente ingresado no se encuentra.";
            }
            return RedirectToAction("ClientsABMC", "Clientes");
        }


        public async Task<IActionResult> CancelAction()
        {
            return RedirectToAction("ClientsABMC", "Clientes");
        }


    }
}
