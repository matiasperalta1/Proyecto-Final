using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class PedidosvDet
    {
        public decimal PvdNroped { get; set; }
        public int PvdNrolin { get; set; }
        public string PvdCodart { get; set; }
        public string PvdDescri { get; set; }
        public string PvdEspeci { get; set; }
        public DateTime? PvdFecent { get; set; }
        public string PvdUnimed { get; set; }
        public decimal PvdCanped { get; set; }
        public decimal PvdCanent { get; set; }
        public decimal PvdPreunit { get; set; }
        public decimal PvdBonif1 { get; set; }
        public decimal PvdBonif2 { get; set; }
        public decimal PvdImpnet { get; set; }
        public decimal PvdValiva { get; set; }
        public decimal PvdImpivg { get; set; }
        public decimal PvdImpivr { get; set; }
        public decimal PvdImptot { get; set; }
        public decimal PvdNropre { get; set; }
        public decimal PvdNrorem { get; set; }
        public decimal PvdNrofac { get; set; }
        public string PvdEstado { get; set; }
        public string PvdObserv { get; set; }

        public virtual Pedidosv PvdNropedNavigation { get; set; }
    }
}
