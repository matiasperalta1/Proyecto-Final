using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class CtasctesvDet
    {
        public int CdvCodcom { get; set; }
        public decimal CdvNrocom { get; set; }
        public int CdvNrocuo { get; set; }
        public decimal? CdvImpcuo { get; set; }
        public DateTime? CdvFecven { get; set; }
        public decimal CdvImpsal { get; set; }
        public string CdvEstado { get; set; }
        public string CdvObserv { get; set; }
        public int? CdvCodcoa { get; set; }
        public decimal? CdvNrocoa { get; set; }
        public int? CdvNrocua { get; set; }

        public virtual Ctasctesv Cdv { get; set; }
    }
}
