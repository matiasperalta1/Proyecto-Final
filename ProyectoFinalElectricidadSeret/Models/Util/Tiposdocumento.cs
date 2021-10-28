using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Tiposdocumento
    {
        public Tiposdocumento()
        {
            Clientes = new HashSet<Cliente>();
        }
        public int TdoCodtdo { get; set; }
        public int TdoCodafi { get; set; }
        public string TdoDescri { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
