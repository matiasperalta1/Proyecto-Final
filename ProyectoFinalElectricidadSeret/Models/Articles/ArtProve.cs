using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class ArtProve
    {
        public int AypCodpro { get; set; }
        public string AypCodart { get; set; }

        public virtual Articulo AypCodartNavigation { get; set; }
        public virtual Proveedore AypCodproNavigation { get; set; }
    }
}
