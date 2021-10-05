using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Devolucione
    {
        public int DevNrodev { get; set; }
        public DateTime? DevFecdev { get; set; }
        public double? DevCodrem { get; set; }
        public int? DevLinrem { get; set; }
        public decimal? DevCandev { get; set; }
        public int DevCoddev { get; set; }
        public string DevCodart { get; set; }
        public string DevDescri { get; set; }
        public string DevUnimed { get; set; }

        public virtual DevolucMot DevCoddevNavigation { get; set; }
    }
}
