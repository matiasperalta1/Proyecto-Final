using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class PresupmodDet
    {
        public decimal PtdNropre { get; set; }
        public int PtdNrolin { get; set; }
        public string PtdCodart { get; set; }
        public string PtdDescri { get; set; }
        public string PtdEspeci { get; set; }
        public string PtdUnimed { get; set; }
        public decimal PtdCantid { get; set; }
        public decimal PtdPrecio { get; set; }
        public decimal PtdValiva { get; set; }
        public decimal PtdBonif1 { get; set; }
        public decimal PtdBonif2 { get; set; }
        public decimal PtdImpnet { get; set; }
        public decimal PtdImpivg { get; set; }
        public decimal PtdImpivr { get; set; }
        public decimal PtdImptot { get; set; }
        public string PtdObserv { get; set; }
        public string PtdCodmar { get; set; }

        public virtual Presupmod PtdNropreNavigation { get; set; }
    }
}
