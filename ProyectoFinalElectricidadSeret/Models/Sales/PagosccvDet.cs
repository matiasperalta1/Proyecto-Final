using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class PagosccvDet
    {
        public int PfdCodcom { get; set; }
        public decimal PfdNrorec { get; set; }
        public int PfdNrolin { get; set; }
        public int PfdCodmpa { get; set; }
        public DateTime? PfdFecpag { get; set; }
        public DateTime? PfdFecimp { get; set; }
        public decimal PfdNrocom { get; set; }
        public string PfdDescri { get; set; }
        public decimal PfdImport { get; set; }
        public string PfdObserv { get; set; }

        public virtual Pagosccv Pfd { get; set; }
    }
}
