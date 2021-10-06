using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Pagosccc
    {
        public Pagosccc()
        {
            PagoscccDets = new HashSet<PagoscccDet>();
        }

        public int PfcCodcom { get; set; }
        public decimal PfcNrorec { get; set; }
        public decimal PfcCodpro { get; set; }
        public decimal PfcNrofac { get; set; }
        public int PfcNrocuo { get; set; }
        public DateTime? PfcFecpag { get; set; }
        public DateTime? PfcFecimp { get; set; }
        public decimal PfcImpefe { get; set; }
        public decimal PfcImpche { get; set; }
        public decimal PfcImptra { get; set; }
        public decimal PfcImptar { get; set; }
        public decimal PfcImpret { get; set; }
        public decimal PfcImptot { get; set; }
        public string PfcEstado { get; set; }
        public string PfcObserv { get; set; }

        public virtual ICollection<PagoscccDet> PagoscccDets { get; set; }
    }
}
