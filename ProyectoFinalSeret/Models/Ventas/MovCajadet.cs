using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class MovCajadet
    {
        public long ModId { get; set; }
        public int ModMocid { get; set; }
        public int ModCodcop { get; set; }
        public string ModDescri { get; set; }
        public decimal ModDebe { get; set; }
        public decimal ModHaber { get; set; }
        public string ModObserv { get; set; }

        public virtual Concepto ModCodcopNavigation { get; set; }
        public virtual MovCaja ModMoc { get; set; }
    }
}
