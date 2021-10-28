using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Ctasbanc
    {
        public int CbaCodctb { get; set; }
        public string CbaDesctb { get; set; }
        public string CbaTipctb { get; set; }
        public string CbaNroctb { get; set; }
        public string CbaCbuctb { get; set; }
        public string CbaSuccta { get; set; }
        public int? CbaCodmon { get; set; }
        public DateTime? CbaFecalt { get; set; }
        public decimal? CbaDescub { get; set; }
        public double? CbaSaldo { get; set; }
        public int? CbaCodcuc { get; set; }
        public string CbaObserv { get; set; }
        public int? CbaCodban { get; set; }
        public virtual Banco CbaCodbanNavigation { get; set; }
        public virtual Moneda CbaCodmonNavigation { get; set; }
    }
}
