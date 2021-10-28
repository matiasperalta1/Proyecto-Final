using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Catclient
    {
        public Catclient()
        {
            Clientes = new HashSet<Cliente>();
        }

        public uint CacCodcac { get; set; }
        public string CacDescri { get; set; }
        public string CacAbrevi { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
