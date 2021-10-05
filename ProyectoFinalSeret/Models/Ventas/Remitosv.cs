using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Remitosv
    {
        public Remitosv()
        {
            RemitosvDets = new HashSet<RemitosvDet>();
        }

        public decimal RvcNrorem { get; set; }
        public DateTime? RvcFecrem { get; set; }
        public decimal RvcCodcli { get; set; }
        public decimal RvcImport { get; set; }
        public decimal RvcDtogep { get; set; }
        public decimal RvcDtogen { get; set; }
        public decimal RvcBonif1 { get; set; }
        public decimal RvcBonif2 { get; set; }
        public decimal RvcImpnet { get; set; }
        public decimal RvcImpivg { get; set; }
        public decimal RvcImpivr { get; set; }
        public decimal RvcImptot { get; set; }
        public decimal RvcNropre { get; set; }
        public decimal RvcNroped { get; set; }
        public decimal RvcNrofac { get; set; }
        public string RvcNrooco { get; set; }
        public string RvcEstado { get; set; }
        public string RvcObserv { get; set; }
        public int RvcCoddep { get; set; }
        public int RvcCodven { get; set; }
        public int RvcCodtra { get; set; }
        public string RvcLugent { get; set; }
        public string RvcLeyend { get; set; }
        public int RvcCodlis { get; set; }
        public int RvcAcopio { get; set; }
        public int RvcCodcpa { get; set; }
        public int RvcCodusu { get; set; }

        public virtual ICollection<RemitosvDet> RemitosvDets { get; set; }
    }
}
