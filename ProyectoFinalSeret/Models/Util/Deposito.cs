using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Deposito
    {
        public Deposito()
        {
            ArtMovs = new HashSet<ArtMov>();
            ArticStocks = new HashSet<ArticStock>();
            ArticUbics = new HashSet<ArticUbic>();
            Puestos = new HashSet<Puesto>();
        }

        public int DepCoddep { get; set; }
        public string DepDescri { get; set; }

        public virtual ICollection<ArtMov> ArtMovs { get; set; }
        public virtual ICollection<ArticStock> ArticStocks { get; set; }
        public virtual ICollection<ArticUbic> ArticUbics { get; set; }
        public virtual ICollection<Puesto> Puestos { get; set; }
    }
}
