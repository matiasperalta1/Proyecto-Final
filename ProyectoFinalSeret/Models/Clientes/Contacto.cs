using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Contacto
    {
        public Contacto()
        {
            ClienContacs = new HashSet<ClienContac>();
            ProveeContacs = new HashSet<ProveeContac>();
        }

        public decimal ConCodcon { get; set; }
        public string ConNombre { get; set; }
        public string ConCargo { get; set; }
        public string ConTelef1 { get; set; }
        public string ConTelef2 { get; set; }
        public string ConFax { get; set; }
        public string ConIntern { get; set; }
        public string ConTelcel { get; set; }
        public string ConMail { get; set; }
        public string ConHorari { get; set; }
        public DateTime? ConFecnac { get; set; }
        public string ConObserv { get; set; }
        public byte? ConEnviaf { get; set; }

        public virtual ICollection<ClienContac> ClienContacs { get; set; }
        public virtual ICollection<ProveeContac> ProveeContacs { get; set; }
    }
}
