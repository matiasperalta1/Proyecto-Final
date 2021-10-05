using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class ReclMov
    {
        public int MorId { get; set; }
        public int MorIdrec { get; set; }
        public DateTime MorFecmov { get; set; }
        public string MorTipmov { get; set; }
        public string MorDescri { get; set; }

        public virtual Reclamo MorIdrecNavigation { get; set; }
    }
}
