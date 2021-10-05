using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Catclient
    {
        public Catclient()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int CacCodcac { get; set; }
        public string CacDescri { get; set; }
        public string CacAbrevi { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
