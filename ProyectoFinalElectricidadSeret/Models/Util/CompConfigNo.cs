using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class CompConfigNo
    {
        public uint CocCodcom { get; set; }
        public string CocDescom { get; set; }
        public uint CocMaxlin { get; set; }
        public int? CocCopias { get; set; }
        public string CocReport { get; set; }
        public string CocObserv { get; set; }
    }
}
