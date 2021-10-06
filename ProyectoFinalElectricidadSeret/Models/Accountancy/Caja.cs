using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Caja
    {
        public Caja()
        {
            MovCajas = new HashSet<MovCaja>();
        }

        public int CajCodcaj { get; set; }
        public string CajDescri { get; set; }
        public string CajObserv { get; set; }

        public virtual ICollection<MovCaja> MovCajas { get; set; }
    }
}
