using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Ctasctesv
    {
        public Ctasctesv()
        {
            CtasctesvDets = new HashSet<CtasctesvDet>();
        }

        public int CcvCodcom { get; set; }
        public decimal CcvNrocom { get; set; }
        public DateTime CcvFeccom { get; set; }
        public string CcvLetra { get; set; }
        public int? CcvCodcop { get; set; }
        public int? CcvCodlis { get; set; }
        public int? CcvCodmon { get; set; }
        public decimal? CcvCodcli { get; set; }
        public decimal CcvImpdeb { get; set; }
        public decimal CcvImphab { get; set; }
        public decimal CcvImpsal { get; set; }
        public string CcvEstado { get; set; }
        public string CcvObserv { get; set; }
        public int? CcvCodcob { get; set; }
        public DateTime? CcvFecpve { get; set; }
        public DateTime? CcvFecuve { get; set; }
        public decimal CcvSalcli { get; set; }

        public virtual ICollection<CtasctesvDet> CtasctesvDets { get; set; }
    }
}
