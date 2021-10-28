using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Errore
    {
        public uint ErrId { get; set; }
        public decimal? ErrCodigo { get; set; }
        public string ErrDescri { get; set; }
        public string ErrAplica { get; set; }
        public string ErrFormul { get; set; }
        public string ErrPuesto { get; set; }
        public string ErrUsuari { get; set; }
        public DateTime ErrFechor { get; set; }
    }
}
