using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class RetClient
    {
        public int RtcNromov { get; set; }
        public int RtcCodret { get; set; }
        public decimal RtcCodcli { get; set; }
        public decimal RtcNrorec { get; set; }
        public DateTime? RtcFecmov { get; set; }
        public int? RtcNroret { get; set; }
        public DateTime? RtcFecret { get; set; }
        public decimal RtcImpret { get; set; }

        public virtual Cliente RtcCodcliNavigation { get; set; }
        public virtual Retencione RtcCodretNavigation { get; set; }
    }
}
