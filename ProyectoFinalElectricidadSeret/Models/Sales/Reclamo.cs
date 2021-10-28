using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Reclamo
    {
        public Reclamo()
        {
            ReclMovs = new HashSet<ReclMov>();
        }

        public int RecId { get; set; }
        public decimal RecNumero { get; set; }
        public DateTime? RecFecha { get; set; }
        public ulong RecGarant { get; set; }
        public string RecEstado { get; set; }
        public string RecCodart { get; set; }
        public decimal RecCantid { get; set; }
        public string RecDescri { get; set; }
        public string RecDetall { get; set; }
        public decimal RecPrrepa { get; set; }
        public int RecCodpro { get; set; }
        public decimal RecCodcli { get; set; }
        public decimal RecPrrepu { get; set; }
        public decimal RecPrflete { get; set; }
        public decimal RecPrtota { get; set; }
        public string RecInfrep { get; set; }
        public sbyte RecTipcom { get; set; }
        public decimal RecNrocom { get; set; }
        public string RecTratam { get; set; }

        public virtual Articulo RecCodartNavigation { get; set; }
        public virtual Cliente RecCodcliNavigation { get; set; }
        public virtual Proveedore RecCodproNavigation { get; set; }
        public virtual ICollection<ReclMov> ReclMovs { get; set; }
    }
}
