using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Usuario
    {

        public int UsuCodusu { get; set; }

        public string UsuApeyno { get; set; }
        [Required]
        public string UsuNombre { get; set; }
        [Required]
        public string UsuContras { get; set; }

        public int? UsuCatusu { get; set; }

        public string UsuAccrap { get; set; }

        public string UsuObserv { get; set; }
        public decimal UsuPin { get; set; }
    }
}
