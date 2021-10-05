using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Moneda
    {
        public Moneda()
        {
            Articulos = new HashSet<Articulo>();
            Listapres = new HashSet<Listapre>();
        }

        public int MonCodmon { get; set; }
        public string MonDescri { get; set; }
        public decimal? MonValmon { get; set; }
        public string MonSigmon { get; set; }
        public string MonCodafi { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Listapre> Listapres { get; set; }
    }
}
