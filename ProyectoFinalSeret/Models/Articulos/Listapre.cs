using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Listapre
    {
        public Listapre()
        {
            Lisyregs = new HashSet<Lisyreg>();
        }

        public int LipCodlis { get; set; }
        public string LipNombre { get; set; }
        public DateTime? LipFdesde { get; set; }
        public DateTime? LipFhasta { get; set; }
        public byte? LipVigente { get; set; }
        public bool? LipContiva { get; set; }
        public bool? LipContimp { get; set; }
        public int LipCodmon { get; set; }

        public virtual Moneda LipCodmonNavigation { get; set; }
        public virtual ICollection<Lisyreg> Lisyregs { get; set; }
    }
}
