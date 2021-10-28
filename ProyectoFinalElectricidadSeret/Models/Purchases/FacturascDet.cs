using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class FacturascDet
    {
        public int FcdCodcom { get; set; }
        public decimal FcdNrofac { get; set; }
        public int FcdCodpro { get; set; }
        public int FcdNrolin { get; set; }
        public string FcdCodart { get; set; }
        public string FcdCodori { get; set; }
        public string FcdDescri { get; set; }
        public string FcdUnimed { get; set; }
        public decimal FcdCantid { get; set; }
        public decimal FcdPrecio { get; set; }
        public decimal FcdBonif1 { get; set; }
        public decimal FcdBonif2 { get; set; }
        public decimal FcdImpnet { get; set; }
        public decimal FcdImpivg { get; set; }
        public decimal FcdImpivr { get; set; }
        public decimal FcdImptot { get; set; }
        public decimal FcdNropre { get; set; }
        public decimal FcdNroped { get; set; }
        public int FcdNrolpe { get; set; }
        public decimal FcdNrorem { get; set; }
        public int FcdNrolre { get; set; }
        public string FcdEstado { get; set; }
        public string FcdObserv { get; set; }
        public decimal FcdValiva { get; set; }
    }
}
