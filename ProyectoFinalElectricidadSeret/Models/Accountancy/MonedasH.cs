using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class MonedasH
    {
        public int Id { get; set; }
        public int MonCodmon { get; set; }
        public string MonCodafi { get; set; }
        public decimal? MonValmon { get; set; }
        public string MonNomusu { get; set; }
        public string MonOperac { get; set; }
        public DateTime MonFecope { get; set; }
    }
}
