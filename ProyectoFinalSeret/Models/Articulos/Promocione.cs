using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Promocione
    {
        public string PrmCodart { get; set; }
        public string PrmPrecio { get; set; }
        public DateTime? PrmFdesde { get; set; }
        public DateTime? PrmHasta { get; set; }
        public decimal? PrmIva { get; set; }
    }
}
