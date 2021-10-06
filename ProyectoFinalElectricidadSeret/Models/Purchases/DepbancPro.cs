using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class DepbancPro
    {
        public int DepIdmovi { get; set; }
        public int? DepCodcta { get; set; }
        public decimal? DepImpdep { get; set; }
        public DateTime? DepFecdep { get; set; }
        public string DepNromov { get; set; }
        public int? DepCodpro { get; set; }
        public string DepDespro { get; set; }
        public string DepObserv { get; set; }
    }
}
