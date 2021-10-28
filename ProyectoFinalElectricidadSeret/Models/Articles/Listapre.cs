using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Listapre
    {
        public Listapre()
        {
            Clientes = new HashSet<Cliente>();
            Condpagos = new HashSet<Condpago>();
            Lisyregs = new HashSet<Lisyreg>();
        }

        public int LipCodlis { get; set; }
        public string LipNombre { get; set; }
        public DateTime? LipFdesde { get; set; }
        public DateTime? LipFhasta { get; set; }
        public sbyte? LipVigente { get; set; }
        public bool? LipContiva { get; set; }
        public bool? LipContimp { get; set; }
        public int LipCodmon { get; set; }

        public virtual Moneda LipCodmonNavigation { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Condpago> Condpagos { get; set; }
        public virtual ICollection<Lisyreg> Lisyregs { get; set; }
    }
}
