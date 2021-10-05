using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Ctasctesc
    {
        public Ctasctesc()
        {
            CtasctescDets = new HashSet<CtasctescDet>();
        }

        public int CccCodcom { get; set; }
        public decimal CccNrocom { get; set; }
        public decimal CccCodpro { get; set; }
        public DateTime CccFeccom { get; set; }
        public string CccLetra { get; set; }
        public int? CccCodcop { get; set; }
        public int? CccCodlis { get; set; }
        public int? CccCodmon { get; set; }
        public decimal CccImpdeb { get; set; }
        public decimal CccImphab { get; set; }
        public decimal CccImpsal { get; set; }
        public string CccEstado { get; set; }
        public string CccObserv { get; set; }
        public int? CccCodcob { get; set; }
        public DateTime? CccFecpve { get; set; }
        public DateTime? CccFecuve { get; set; }
        public string CccNrocta { get; set; }

        public virtual ICollection<CtasctescDet> CtasctescDets { get; set; }
    }
}
