using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Marca
    {
        public Marca()
        {
            ArticActs = new HashSet<ArticAct>();
            ArticTmps = new HashSet<ArticTmp>();
            Articulos = new HashSet<Articulo>();
            Reglapres = new HashSet<Reglapre>();
        }

        public string MarCodmar { get; set; }
        public string MarDescri { get; set; }
        public string MarObserv { get; set; }
        public uint MarIdweb { get; set; }
        public byte MarActivo { get; set; }

        public virtual ICollection<ArticAct> ArticActs { get; set; }
        public virtual ICollection<ArticTmp> ArticTmps { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Reglapre> Reglapres { get; set; }
    }
}
