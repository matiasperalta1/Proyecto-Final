using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class CtasctescDet
    {
        public int CdcCodcom { get; set; }
        public decimal CdcNrocom { get; set; }
        public decimal CdcCodpro { get; set; }
        public int CdcNrocuo { get; set; }
        public decimal? CdcImpcuo { get; set; }
        public DateTime? CdcFecven { get; set; }
        public decimal CdcImpsal { get; set; }
        public string CdcEstado { get; set; }
        public string CdcObserv { get; set; }
        public int? CdcCodcoa { get; set; }
        public decimal? CdcNrocoa { get; set; }
        public int? CdcNrocua { get; set; }

        public virtual Ctasctesc Cdc { get; set; }
    }
}
