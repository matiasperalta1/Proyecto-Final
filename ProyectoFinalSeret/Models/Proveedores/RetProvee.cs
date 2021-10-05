using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class RetProvee
    {
        public int Rtpnromov { get; set; }
        public int RtpCodret { get; set; }
        public int? RtpCodpro { get; set; }
        public decimal? RtpNrorec { get; set; }
        public decimal? RtpNrofac { get; set; }
        public DateTime? RtpFecmov { get; set; }
        public int? RtpNroret { get; set; }
        public DateTime? RtpFecret { get; set; }
        public decimal RtpImpret { get; set; }

        public virtual Retencione RtpCodretNavigation { get; set; }
    }
}
