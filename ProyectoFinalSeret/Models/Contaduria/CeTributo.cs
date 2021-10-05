using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class CeTributo
    {
        public int TriCodcom { get; set; }
        public decimal TriNrocom { get; set; }
        public int TriLinea { get; set; }
        public int? TriCodtri { get; set; }
        public string TriDescri { get; set; }
        public decimal? TriBasimp { get; set; }
        public decimal? TriAlicuo { get; set; }
        public decimal? TriImport { get; set; }

        public virtual CeCabecera Tri { get; set; }
    }
}
