using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Tarjrec
    {
        public int TjrIdmovi { get; set; }
        public int TjrNumaut { get; set; }
        public string TjrNrolot { get; set; }
        public string TjrNumcup { get; set; }
        public int TjrCodtar { get; set; }
        public decimal TjrImppgo { get; set; }
        public int? TjrCancuo { get; set; }
        public int? TjrCodcli { get; set; }
        public string TjrDescli { get; set; }
        public string TjrRespon { get; set; }
        public DateTime? TjrFecacr { get; set; }
        public decimal TjrImpacre { get; set; }
        public int? TjrCuoacre { get; set; }
        public string TjrEstado { get; set; }
        public string TjrObserv { get; set; }
    }
}
