using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class FacturasvDet
    {
        public int FvdCodcom { get; set; }
        public decimal FvdNrofac { get; set; }
        public int FvdNrolin { get; set; }
        public string FvdCodart { get; set; }
        public string FvdDescri { get; set; }
        public string FvdUnimed { get; set; }
        public decimal FvdCantid { get; set; }
        public decimal FvdPrecio { get; set; }
        public decimal FvdBonif1 { get; set; }
        public decimal FvdBonif2 { get; set; }
        public decimal FvdImpnet { get; set; }
        public decimal FvdValiva { get; set; }
        public decimal FvdImpivg { get; set; }
        public decimal FvdImpivr { get; set; }
        public decimal FvdImpnog { get; set; }
        public decimal FvdImptot { get; set; }
        public decimal FvdNropre { get; set; }
        public decimal FvdNroped { get; set; }
        public int FvdNrolpe { get; set; }
        public decimal FvdNrorem { get; set; }
        public int FvdNrolre { get; set; }
        public string FvdEstado { get; set; }
        public string FvdObserv { get; set; }
        public uint FvdLinaco { get; set; }
    }
}
