using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Chequera
    {
        public int ChqCodchq { get; set; }
        public string ChqTipche { get; set; }
        public bool? ChqActiva { get; set; }
        public decimal? ChqDesnum { get; set; }
        public decimal? ChqHasnum { get; set; }
        public decimal? ChqUltnum { get; set; }
        public decimal ChqCodbce { get; set; }
    }
}
