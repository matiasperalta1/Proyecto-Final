using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class PedidoscDet
    {
        public decimal PcdNroped { get; set; }
        public int PcdNrolin { get; set; }
        public string PcdCodart { get; set; }
        public string PcdCodori { get; set; }
        public string PcdDescri { get; set; }
        public string PcdEspeci { get; set; }
        public decimal PcdNrorem { get; set; }
        public DateTime? PcdFecent { get; set; }
        public string PcdUnimed { get; set; }
        public decimal PcdCanped { get; set; }
        public decimal PcdCanent { get; set; }
        public decimal PcdPreuni { get; set; }
        public decimal PcdBonif1 { get; set; }
        public decimal PcdBonif2 { get; set; }
        public decimal PcdImpnet { get; set; }
        public decimal PcdImpivg { get; set; }
        public decimal PcdImpivr { get; set; }
        public decimal PcdImptot { get; set; }
        public decimal PcdNropre { get; set; }
        public decimal PcdValiva { get; set; }
        public decimal PcdNrofac { get; set; }
        public string PcdEstado { get; set; }
        public string PcdObserv { get; set; }
        public int PcdCodmon { get; set; }
        public int PcdLinaco { get; set; }
        public string PcdTipaco { get; set; }

        public virtual Pedidosc PcdNropedNavigation { get; set; }
    }
}
