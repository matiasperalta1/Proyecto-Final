using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class CeIva
    {
        public int IvaCodcom { get; set; }
        public decimal IvaNrocom { get; set; }
        public int IvaLinea { get; set; }
        public int? IvaCodiva { get; set; }
        public decimal? IvaBasimp { get; set; }
        public decimal? IvaImport { get; set; }

        public virtual CeCabecera Iva { get; set; }
    }
}
