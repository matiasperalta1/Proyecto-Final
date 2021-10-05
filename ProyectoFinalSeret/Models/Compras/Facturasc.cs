using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Facturasc
    {
        public int FccCodcom { get; set; }
        public decimal FccNrofac { get; set; }
        public decimal FccCodpro { get; set; }
        public DateTime? FccFecfac { get; set; }
        public DateTime? FccFecreg { get; set; }
        public string FccLetra { get; set; }
        public int FccCodcpa { get; set; }
        public int FccCodlis { get; set; }
        public int FccCodmon { get; set; }
        public decimal FccImport { get; set; }
        public decimal FccDtogep { get; set; }
        public decimal FccDtogen { get; set; }
        public decimal FccBonif1 { get; set; }
        public decimal FccBonif2 { get; set; }
        public decimal FccImpneg { get; set; }
        public decimal FccImpner { get; set; }
        public decimal FccImpnea { get; set; }
        public decimal FccImpivg { get; set; }
        public decimal FccImpivr { get; set; }
        public decimal FccImpiva { get; set; }
        public decimal FccImpper { get; set; }
        public decimal FccImpret { get; set; }
        public decimal FccImpiin { get; set; }
        public decimal FccImptot { get; set; }
        public decimal FccNropre { get; set; }
        public decimal FccNroped { get; set; }
        public decimal FccNrorem { get; set; }
        public string FvcNrooco { get; set; }
        public string FccEstado { get; set; }
        public string FccObserv { get; set; }
        public int FccCoddep { get; set; }
        public int FccCodtra { get; set; }
        public string FccLugent { get; set; }
        public string FccLeyend { get; set; }
        public int FccCodcop { get; set; }
        public string FccNrocai { get; set; }
        public DateTime? FccVencai { get; set; }
        public int? FccOrdlib { get; set; }
        public decimal FccValmon { get; set; }
        public int FccCmoori { get; set; }
        public int FccCodusu { get; set; }

        public virtual Concepto FccCodcopNavigation { get; set; }
    }
}
