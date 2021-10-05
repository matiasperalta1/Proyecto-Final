using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class MovCaja
    {
        public MovCaja()
        {
            MovCajadets = new HashSet<MovCajadet>();
        }

        public int MocId { get; set; }
        public int MocCodcaj { get; set; }
        public DateTime? MocFecmov { get; set; }
        public decimal MocSalini { get; set; }
        public decimal MocSalfin { get; set; }
        public DateTime? MocFehoap { get; set; }
        public DateTime? MocFehoci { get; set; }
        public string MocUsuape { get; set; }
        public string MocUsucie { get; set; }
        public string MocObserv { get; set; }

        public virtual Caja MocCodcajNavigation { get; set; }
        public virtual ICollection<MovCajadet> MovCajadets { get; set; }
    }
}
