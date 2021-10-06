using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Presupmod
    {
        public Presupmod()
        {
            PresupmodDets = new HashSet<PresupmodDet>();
        }

        public decimal PtcNropre { get; set; }
        public DateTime? PtcFecpre { get; set; }
        public DateTime? PtcFecven { get; set; }
        public decimal? PtcCodcli { get; set; }
        public string PtcNompre { get; set; }
        public string PtcEstado { get; set; }
        public string PtcLeyend { get; set; }
        public string PtcObserv { get; set; }

        public virtual ICollection<PresupmodDet> PresupmodDets { get; set; }
    }
}
