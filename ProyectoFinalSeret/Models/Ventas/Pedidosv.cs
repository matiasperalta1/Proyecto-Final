using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Pedidosv
    {
        public Pedidosv()
        {
            PedidosvDets = new HashSet<PedidosvDet>();
        }

        public decimal PvcNroped { get; set; }
        public DateTime? PvcFecped { get; set; }
        public DateTime? PvcFecent { get; set; }
        public decimal PvcCodcli { get; set; }
        public string PvcNomcli { get; set; }
        public decimal PvcImport { get; set; }
        public decimal PvcDtogep { get; set; }
        public decimal PvcDtogen { get; set; }
        public decimal PvcBonif1 { get; set; }
        public decimal PvcBonif2 { get; set; }
        public decimal PvcNeto { get; set; }
        public decimal PvcImpivg { get; set; }
        public decimal PvcImpivr { get; set; }
        public decimal PvcTotal { get; set; }
        public string PvcObserv { get; set; }
        public string PvcEntpar { get; set; }
        public decimal PvcNropre { get; set; }
        public decimal PvcNrorem { get; set; }
        public decimal PvcNrofac { get; set; }
        public string PvcNrooco { get; set; }
        public string PvcEstado { get; set; }
        public int PvcCoddep { get; set; }
        public int PvcCodven { get; set; }
        public int PvcCodlis { get; set; }
        public string PvcLugent { get; set; }
        public string PvcLeyend { get; set; }
        public int PvcAcopio { get; set; }
        public int PvcCodcpa { get; set; }
        public int PvcCodtra { get; set; }
        public int PvcCodusu { get; set; }

        public virtual ICollection<PedidosvDet> PedidosvDets { get; set; }
    }
}
