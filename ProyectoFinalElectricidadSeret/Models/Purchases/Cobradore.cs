using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Cobradore
    {
        public int CobCodcob { get; set; }
        public string CobDescri { get; set; }
        public decimal? CobComisi { get; set; }
        public string CobCuil { get; set; }
        public DateTime? CobFingre { get; set; }
        public decimal? CobNlegaj { get; set; }
        public decimal? CobNtarje { get; set; }
        public string CobObserv { get; set; }
    }
}
