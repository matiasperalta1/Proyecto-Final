using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Tipoart
    {
        public Tipoart()
        {
            Articulos = new HashSet<Articulo>();
        }

        public int TarCodtar { get; set; }
        public string TarDescri { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
