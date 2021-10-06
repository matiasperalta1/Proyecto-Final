using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class CajasAyc
    {
        public int AycNumses { get; set; }
        public DateTime AycFecmov { get; set; }
        public DateTime? AycFecaper { get; set; }
        public string AycUsuaper { get; set; }
        public DateTime? AycFeccie { get; set; }
        public string AycUsucie { get; set; }
        public decimal AycRecefe { get; set; }
        public decimal AycRecche { get; set; }
        public decimal AycRectar { get; set; }
        public decimal AycRecdep { get; set; }
        public decimal AycRectot { get; set; }
    }
}
