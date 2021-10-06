using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class ComprobNumero
    {
        public int CynCodcom { get; set; }
        public int CynPrefij { get; set; }
        public decimal? CynNumero { get; set; }
        public int? CynGruact { get; set; }
        public string CynObserv { get; set; }

        public virtual Comprobante CynCodcomNavigation { get; set; }
    }
}
