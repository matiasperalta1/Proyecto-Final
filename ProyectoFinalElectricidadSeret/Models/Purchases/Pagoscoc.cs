using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Pagoscoc
    {
        public Pagoscoc()
        {
            PagoscocDets = new HashSet<PagoscocDet>();
        }

        public int PccCodcom { get; set; }
        public decimal PccNrofac { get; set; }
        public decimal PccCodpro { get; set; }
        public DateTime? PccFecpag { get; set; }
        public DateTime? PccFecimp { get; set; }
        public decimal PccImpefe { get; set; }
        public decimal PccImpche { get; set; }
        public decimal PccImptra { get; set; }
        public decimal PccImptar { get; set; }
        public decimal PccImpret { get; set; }
        public decimal PccImptot { get; set; }
        public string PccEstado { get; set; }
        public string PccObserv { get; set; }

        public virtual ICollection<PagoscocDet> PagoscocDets { get; set; }
    }
}
