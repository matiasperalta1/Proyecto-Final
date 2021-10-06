using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Subrubro
    {
        public Subrubro()
        {
            Articulos = new HashSet<Articulo>();
            Reglapres = new HashSet<Reglapre>();
        }

        public string SruCodsru { get; set; }
        public string SruDescri { get; set; }
        public string SruObserv { get; set; }
        public string SruCodrub { get; set; }
        public int SruIdweb { get; set; }
        public byte SruActivo { get; set; }

        public virtual Rubro SruCodrubNavigation { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Reglapre> Reglapres { get; set; }
    }
}
