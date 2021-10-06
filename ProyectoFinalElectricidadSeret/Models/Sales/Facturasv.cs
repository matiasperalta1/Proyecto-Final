using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Facturasv
    {
        public int FvcCodcom { get; set; }
        public decimal FvcNrofac { get; set; }
        public DateTime? FvcFecfac { get; set; }
        public string FvcLetra { get; set; }
        public int FvcCodcpa { get; set; }
        public int FvcCodlis { get; set; }
        public int FvcCodmon { get; set; }
        public decimal FvcCodcli { get; set; }
        public decimal FvcImport { get; set; }
        public decimal FvcDtogep { get; set; }
        public decimal FvcDtogen { get; set; }
        public decimal FvcBonif1 { get; set; }
        public decimal FvcBonif2 { get; set; }
        public decimal FvcImpneg { get; set; }
        public decimal FvcImpivg { get; set; }
        public decimal FvcImpner { get; set; }
        public decimal FvcImpivr { get; set; }
        public decimal FvcImpnog { get; set; }
        public decimal FvcImptot { get; set; }
        public decimal FvcNropre { get; set; }
        public decimal FvcNroped { get; set; }
        public decimal FvcNrorem { get; set; }
        public string FvcNrooco { get; set; }
        public string FvcEstado { get; set; }
        public string FvcObserv { get; set; }
        public int FvcCoddep { get; set; }
        public int FvcCodven { get; set; }
        public int FvcCodtra { get; set; }
        public string FvcLugent { get; set; }
        public string FvcLeyend { get; set; }
        public int FvcAcopio { get; set; }
        public int FvcCodusu { get; set; }
    }
}
