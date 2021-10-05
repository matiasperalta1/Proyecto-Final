using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class PagoscocDet
    {
        public int PcdCodcom { get; set; }
        public decimal PcdNrofac { get; set; }
        public decimal PcdCodpro { get; set; }
        public int PcdNrolin { get; set; }
        public int PcdCodmpa { get; set; }
        public DateTime? PcdFecpag { get; set; }
        public DateTime? PcdFecimp { get; set; }
        public decimal PcdNrocom { get; set; }
        public string PcdDescri { get; set; }
        public decimal PcdImport { get; set; }
        public string PcdObserv { get; set; }

        public virtual Pagoscoc Pcd { get; set; }
    }
}
