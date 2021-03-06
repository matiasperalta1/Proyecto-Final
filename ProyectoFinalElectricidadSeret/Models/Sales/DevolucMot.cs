using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class DevolucMot
    {
        public DevolucMot()
        {
            Devoluciones = new HashSet<Devolucione>();
        }

        public int DemCoddev { get; set; }
        public string DemDescri { get; set; }

        public virtual ICollection<Devolucione> Devoluciones { get; set; }
    }
}
