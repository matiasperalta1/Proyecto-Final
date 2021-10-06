using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class CeCabecera
    {
        public CeCabecera()
        {
            CeCbesAsocs = new HashSet<CeCbesAsoc>();
            CeIvas = new HashSet<CeIva>();
            CeTributos = new HashSet<CeTributo>();
        }

        public int CelCodcom { get; set; }
        public decimal CelNrocom { get; set; }
        public int? CelConcep { get; set; }
        public int? CelTipdoc { get; set; }
        public decimal? CelNrodoc { get; set; }
        public string CelTipcom { get; set; }
        public decimal? CelPtovta { get; set; }
        public decimal? CelNrodes { get; set; }
        public decimal? CelNrohas { get; set; }
        public string CelFeccom { get; set; }
        public decimal? CelImptot { get; set; }
        public decimal? CelImpcon { get; set; }
        public decimal? CelImpnet { get; set; }
        public decimal? CelImpexe { get; set; }
        public decimal? CelImpiva { get; set; }
        public decimal? CelImptri { get; set; }
        public string CelFserde { get; set; }
        public string CelFserha { get; set; }
        public string CelFecven { get; set; }
        public string CelMoneid { get; set; }
        public decimal? CelMoncot { get; set; }
        public string CelResult { get; set; }
        public string CelNrocae { get; set; }
        public string CelVencae { get; set; }
        public string CelReproc { get; set; }
        public string CelObserv { get; set; }
        public string CelErrmsg { get; set; }
        public decimal? CelCodcli { get; set; }

        public virtual ICollection<CeCbesAsoc> CeCbesAsocs { get; set; }
        public virtual ICollection<CeIva> CeIvas { get; set; }
        public virtual ICollection<CeTributo> CeTributos { get; set; }
    }
}
