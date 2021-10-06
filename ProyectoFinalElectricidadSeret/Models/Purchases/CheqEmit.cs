using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class CheqEmit
    {
        public int CheIdcheq { get; set; }
        public int? CheNumche { get; set; }
        public int CheCodban { get; set; }
        public int CheCodloc { get; set; }
        public DateTime? CheFecemi { get; set; }
        public DateTime? CheFeccob { get; set; }
        public decimal CheImport { get; set; }
        public int? CheCodpro { get; set; }
        public string CheDespro { get; set; }
        public DateTime? CheFecent { get; set; }
        public string CheEstado { get; set; }
        public string CheObserv { get; set; }
    }
}
