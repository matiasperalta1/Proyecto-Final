using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class PagoscccDet
    {
        public int PfdCodcom { get; set; }
        public decimal PfdNrorec { get; set; }
        public decimal PfdCodpro { get; set; }
        public int PfdNrolin { get; set; }
        public int PfdCodmpa { get; set; }
        public DateTime? PfdFecpag { get; set; }
        public DateTime? PfdFecimp { get; set; }
        public decimal PfdNrocom { get; set; }
        public string PfdDescri { get; set; }
        public decimal PfdImport { get; set; }
        public string PfdObserv { get; set; }
        public string PfdAgrupa { get; set; }

        public virtual Pagosccc Pfd { get; set; }
    }
}
