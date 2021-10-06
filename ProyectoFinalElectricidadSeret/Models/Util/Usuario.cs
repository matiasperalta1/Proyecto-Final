using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Usuario
    {
        public int UsuCodusu { get; set; }
        public string UsuApeyno { get; set; }
        public string UsuNombre { get; set; }
        public string UsuContras { get; set; }
        public int? UsuCatusu { get; set; }
        public string UsuAccrap { get; set; }
        public string UsuObserv { get; set; }
        public decimal UsuPin { get; set; }
    }
}
