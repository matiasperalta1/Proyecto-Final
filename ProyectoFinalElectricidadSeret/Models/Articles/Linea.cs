using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Linea
    {
        public Linea()
        {
            Articulos = new HashSet<Articulo>();
            Reglapres = new HashSet<Reglapre>();
        }

        public string LinCodlin { get; set; }
        public string LinDescri { get; set; }
        public string LinObserv { get; set; }
        public short LinDivweb { get; set; }
        public byte LinActiva { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Reglapre> Reglapres { get; set; }
    }
}
