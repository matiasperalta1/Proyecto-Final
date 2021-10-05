using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Remitosc
    {
        public Remitosc()
        {
            RemitoscDets = new HashSet<RemitoscDet>();
        }

        public decimal RccNrorem { get; set; }
        public decimal RccCodpro { get; set; }
        public DateTime? RccFecrem { get; set; }
        public decimal RccImport { get; set; }
        public decimal RccDtogep { get; set; }
        public decimal RccDtogen { get; set; }
        public decimal RccBonif1 { get; set; }
        public decimal RccBonif2 { get; set; }
        public decimal RccImpnet { get; set; }
        public decimal RccImpivg { get; set; }
        public decimal RccImpivr { get; set; }
        public decimal RccImptot { get; set; }
        public decimal RccNropre { get; set; }
        public decimal RccNroped { get; set; }
        public decimal RccNrofac { get; set; }
        public string RccNrooco { get; set; }
        public string RccEstado { get; set; }
        public string RccObserv { get; set; }
        public int RccCoddep { get; set; }
        public int RccCodven { get; set; }
        public int RccCodtra { get; set; }
        public string RccLugent { get; set; }
        public string RccLeyend { get; set; }
        public int RccCodlis { get; set; }
        public int RccAcopio { get; set; }
        public int RccCodcpa { get; set; }
        public int RccCodusu { get; set; }

        public virtual ICollection<RemitoscDet> RemitoscDets { get; set; }
    }
}
