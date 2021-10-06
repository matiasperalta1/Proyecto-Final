using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class CeCbesAsoc
    {
        public int CasCodcom { get; set; }
        public decimal CasNrocom { get; set; }
        public int CasLinea { get; set; }
        public int? CasTipcom { get; set; }
        public decimal? CasPtovta { get; set; }
        public decimal? CasNrocas { get; set; }

        public virtual CeCabecera Cas { get; set; }
    }
}
