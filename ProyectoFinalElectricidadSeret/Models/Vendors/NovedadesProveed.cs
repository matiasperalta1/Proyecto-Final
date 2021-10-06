using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class NovedadesProveed
    {
        public int NovCodnov { get; set; }
        public int NovCodpro { get; set; }
        public string NovDescri { get; set; }
        public DateTime? NovFecnov { get; set; }
        public DateTime? NovFecnot { get; set; }
        public int NovActiva { get; set; }

        public virtual Proveedore NovCodproNavigation { get; set; }
    }
}
