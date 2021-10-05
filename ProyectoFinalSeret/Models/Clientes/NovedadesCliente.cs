using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class NovedadesCliente
    {
        public int NovCodnov { get; set; }
        public decimal NovCodcli { get; set; }
        public string NovDescri { get; set; }
        public DateTime? NovFecnov { get; set; }
        public DateTime? NovFecnot { get; set; }
        public int NovActiva { get; set; }

        public virtual Cliente NovCodcliNavigation { get; set; }
    }
}
