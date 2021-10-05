using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class CobranzasCliente
    {
        public int CobCodcob { get; set; }
        public decimal CobCodcli { get; set; }
        public string CobTipcon { get; set; }
        public string CobDescri { get; set; }
        public DateTime? CobFeccon { get; set; }
        public DateTime? CobFenvoc { get; set; }
        public string CobEstado { get; set; }

        public virtual Cliente CobCodcliNavigation { get; set; }
    }
}
