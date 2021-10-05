using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class ImprComp
    {
        public int IycCodpue { get; set; }
        public int IycCodcom { get; set; }
        public string IycDesimp { get; set; }
        public string IycReport { get; set; }
        public int? IycCopiasNo { get; set; }

        public virtual Comprobante IycCodcomNavigation { get; set; }
        public virtual Puesto IycCodpueNavigation { get; set; }
    }
}
