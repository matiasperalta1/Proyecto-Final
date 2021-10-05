using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Pedidosc
    {
        public Pedidosc()
        {
            PedidoscDets = new HashSet<PedidoscDet>();
        }

        public decimal PccNroped { get; set; }
        public DateTime? PccFecped { get; set; }
        public DateTime? PccFecent { get; set; }
        public decimal PccCodpro { get; set; }
        public decimal PccImport { get; set; }
        public decimal PccDtogep { get; set; }
        public decimal PccDtogen { get; set; }
        public decimal PccBonif1 { get; set; }
        public decimal PccBonif2 { get; set; }
        public decimal PccNeto { get; set; }
        public decimal PccImpivg { get; set; }
        public decimal PccImpivr { get; set; }
        public decimal PccTotal { get; set; }
        public string PccObserv { get; set; }
        public string PccEntpar { get; set; }
        public decimal PccNropre { get; set; }
        public decimal PccNrorem { get; set; }
        public decimal PccNrofac { get; set; }
        public string PccNrooco { get; set; }
        public string PccEstado { get; set; }
        public int PccCoddep { get; set; }
        public int PccCodven { get; set; }
        public int PccCodlis { get; set; }
        public string PccLugent { get; set; }
        public string PccLeyend { get; set; }
        public int PccAcopio { get; set; }
        public int PccCodcpa { get; set; }
        public int PccCodtra { get; set; }
        public string PccEnvio { get; set; }
        public string PccDescri { get; set; }
        public string PccMail { get; set; }
        public int PccCodusu { get; set; }

        public virtual ICollection<PedidoscDet> PedidoscDets { get; set; }
    }
}
