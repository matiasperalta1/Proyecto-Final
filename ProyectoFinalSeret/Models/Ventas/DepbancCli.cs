using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class DepbancCli
    {
        public int DecIdmovi { get; set; }
        public int? DecCodcta { get; set; }
        public decimal DecImpdep { get; set; }
        public DateTime? DecFecdep { get; set; }
        public string DecNromov { get; set; }
        public int? DecCodcli { get; set; }
        public string DecDescli { get; set; }
        public string DecObserv { get; set; }
    }
}
