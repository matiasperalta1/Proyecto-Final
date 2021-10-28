using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Rubro
    {
        public Rubro()
        {
            Articulos = new HashSet<Articulo>();
            Reglapres = new HashSet<Reglapre>();
            Subrubros = new HashSet<Subrubro>();
        }

        public string RubCodrub { get; set; }
        public string RubDescri { get; set; }
        public string RubObserv { get; set; }
        public uint RubIdweb { get; set; }
        public byte RubActivo { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Reglapre> Reglapres { get; set; }
        public virtual ICollection<Subrubro> Subrubros { get; set; }
    }
}
