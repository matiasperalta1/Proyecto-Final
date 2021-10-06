using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Reglapre
    {
        public Reglapre()
        {
            Lisyregs = new HashSet<Lisyreg>();
        }

        public int RepCodreg { get; set; }
        public string RepDesreg { get; set; }
        public int? RepNivel { get; set; }
        public string RepCodlin { get; set; }
        public string RepCodrub { get; set; }
        public string RepCodsru { get; set; }
        public string RepCodmar { get; set; }
        public string RepCodart { get; set; }
        public decimal? RepUtilid { get; set; }
        public string RepObserv { get; set; }

        public virtual Articulo RepCodartNavigation { get; set; }
        public virtual Linea RepCodlinNavigation { get; set; }
        public virtual Marca RepCodmarNavigation { get; set; }
        public virtual Rubro RepCodrubNavigation { get; set; }
        public virtual Subrubro RepCodsruNavigation { get; set; }
        public virtual ICollection<Lisyreg> Lisyregs { get; set; }
    }
}
