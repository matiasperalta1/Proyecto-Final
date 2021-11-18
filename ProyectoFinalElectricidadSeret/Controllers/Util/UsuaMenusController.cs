using Microsoft.AspNetCore.Mvc;
using ProyectoFinalElectricidadSeret.Data;
using ProyectoFinalElectricidadSeret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalElectricidadSeret.Controllers
{
    public class UsuaMenusController : Controller
    {
        private readonly AppDbContext _context;

        public UsuaMenusController(AppDbContext context)
        {
            _context = context;
        }

       

    }
}
