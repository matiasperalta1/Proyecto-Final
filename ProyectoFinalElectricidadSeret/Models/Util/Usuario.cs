using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Usuario
    {
        public int UsuCodusu { get; set; }
        public string UsuApeyno { get; set; }
        [DisplayName("Nombre de Usuario")]
        [Required]
        public string UsuNombre { get; set; }
        [DisplayName("Contraseña")]
        [Required]
        public string UsuContras { get; set; }
        public int? UsuCatusu { get; set; }
        public string UsuAccrap { get; set; }
        public string UsuObserv { get; set; }
        public decimal UsuPin { get; set; }
    }
}
