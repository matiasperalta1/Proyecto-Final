using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class CeTiqueAcceso
    {
        public decimal CetPrefij { get; set; }
        public string CetToken { get; set; }
        public string CetSign { get; set; }
        public DateTime? CetGrabac { get; set; }
        public DateTime? CetValido { get; set; }
        public string CetCerdig { get; set; }
    }
}
