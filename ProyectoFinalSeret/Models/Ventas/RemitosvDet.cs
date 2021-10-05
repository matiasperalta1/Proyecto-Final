using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class RemitosvDet
    {
        public decimal RvdNrorem { get; set; }
        public int RvdNrolin { get; set; }
        public string RvdCodart { get; set; }
        public string RvdDescri { get; set; }
        public string RvdUnimed { get; set; }
        public decimal RvdCantid { get; set; }
        public decimal RvdCandev { get; set; }
        public decimal RvdPrecio { get; set; }
        public decimal RvdBonif1 { get; set; }
        public decimal RvdBonif2 { get; set; }
        public decimal RvdImpnet { get; set; }
        public decimal RvdValiva { get; set; }
        public decimal RvdImpivg { get; set; }
        public decimal RvdImpivr { get; set; }
        public decimal RvdImptot { get; set; }
        public decimal RvdNropre { get; set; }
        public decimal RvdNroped { get; set; }
        public int RvdNrolpe { get; set; }
        public decimal RvdNrofac { get; set; }
        public string RvdEstado { get; set; }
        public string RvdObserv { get; set; }
        public int RvdLinaco { get; set; }

        public virtual Remitosv RvdNroremNavigation { get; set; }
    }
}
