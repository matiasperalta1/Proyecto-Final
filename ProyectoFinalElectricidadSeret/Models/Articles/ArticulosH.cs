using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class ArticulosH
    {
        public long IdMovArt { get; set; }
        public string AreCodart { get; set; }
        public decimal ArePrecos { get; set; }
        public int AreCodmon { get; set; }
        public string AreUsuari { get; set; }
        public string AreOperac { get; set; }
        public DateTime AreFecope { get; set; }
    }
}
