using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Presup
    {
        public Presup()
        {
            PresupDets = new HashSet<PresupDet>();
        }

        public decimal PtcNropre { get; set; }
        public DateTime? PtcFecpre { get; set; }
        public string PtcFecent { get; set; }
        public int PtcDiasen { get; set; }
        public DateTime? PtcFecven { get; set; }
        public decimal? PtcCodcli { get; set; }
        public string PtcNomcli { get; set; }
        public decimal PtcImport { get; set; }
        public decimal PtcDtogep { get; set; }
        public decimal PtcDtogen { get; set; }
        public decimal PtcBonif1 { get; set; }
        public decimal PtcBonif2 { get; set; }
        public decimal PtcImpnet { get; set; }
        public decimal PtcImpivg { get; set; }
        public decimal PtcImpivr { get; set; }
        public decimal PtcImptot { get; set; }
        public string PtcEntpar { get; set; }
        public int PtcCodmon { get; set; }
        public decimal PtcValmon { get; set; }
        public int PtcCodlis { get; set; }
        public bool? PtcConiva { get; set; }
        public string PtcCcosto { get; set; }
        public int PtcCodcpa { get; set; }
        public string PtcContac { get; set; }
        public int PtcCodtra { get; set; }
        public string PtcEstado { get; set; }
        public int PtcCodven { get; set; }
        public int? PtcCoddep { get; set; }
        public string PtcLeyend { get; set; }
        public string PtcObserv { get; set; }
        public int PtcCodusu { get; set; }

        public virtual ICollection<PresupDet> PresupDets { get; set; }
    }
}
