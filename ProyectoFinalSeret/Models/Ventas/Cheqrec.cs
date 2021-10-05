using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Cheqrec
    {
        public int ChrIdcheq { get; set; }
        public long? ChrNumche { get; set; }
        public int? ChrCodban { get; set; }
        public int? ChrCodloc { get; set; }
        public DateTime? ChrFecemi { get; set; }
        public DateTime? ChrFeccob { get; set; }
        public DateTime? ChrFecrec { get; set; }
        public string ChrLibrad { get; set; }
        public string ChrRespon { get; set; }
        public decimal? ChrImport { get; set; }
        public int? ChrCodcli { get; set; }
        public string ChrDescli { get; set; }
        public int? ChrCodpro { get; set; }
        public string ChrDespro { get; set; }
        public DateTime? ChrFecent { get; set; }
        public string ChrEstado { get; set; }
        public string ChrObserv { get; set; }
    }
}
