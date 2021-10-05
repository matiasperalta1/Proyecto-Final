using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Errore
    {
        public int ErrId { get; set; }
        public decimal? ErrCodigo { get; set; }
        public string ErrDescri { get; set; }
        public string ErrAplica { get; set; }
        public string ErrFormul { get; set; }
        public string ErrPuesto { get; set; }
        public string ErrUsuari { get; set; }
    }
}
