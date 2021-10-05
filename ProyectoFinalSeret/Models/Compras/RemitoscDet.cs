using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class RemitoscDet
    {
        public decimal RcdNrorem { get; set; }
        public decimal RcdCodpro { get; set; }
        public int RcdNrolin { get; set; }
        public string RcdCodart { get; set; }
        public string RcdCodori { get; set; }
        public string RcdDescri { get; set; }
        public string RcdUnimed { get; set; }
        public decimal RcdCantid { get; set; }
        public decimal RcdCandev { get; set; }
        public decimal RcdPrecio { get; set; }
        public decimal RcdBonif1 { get; set; }
        public decimal RcdBonif2 { get; set; }
        public decimal RcdImpnet { get; set; }
        public decimal RcdImpivg { get; set; }
        public decimal RcdImpivr { get; set; }
        public decimal RcdImptot { get; set; }
        public decimal RcdNropre { get; set; }
        public decimal RcdNroped { get; set; }
        public int RcdNrolpe { get; set; }
        public decimal RcdNrofac { get; set; }
        public string RcdEstado { get; set; }
        public string RcdObserv { get; set; }
        public decimal RcdValiva { get; set; }
        public int RcdLinaco { get; set; }
        public string RcdTipaco { get; set; }

        public virtual Remitosc Rcd { get; set; }
    }
}
