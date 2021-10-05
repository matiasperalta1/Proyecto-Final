using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Concepto
    {
        public Concepto()
        {
            Facturascs = new HashSet<Facturasc>();
            MovCajadets = new HashSet<MovCajadet>();
        }

        public int CoeCodcop { get; set; }
        public string CoeDescri { get; set; }
        public string CoeEntsal { get; set; }
        public string CoeModulo { get; set; }
        public string CoeObserv { get; set; }

        public virtual ICollection<Facturasc> Facturascs { get; set; }
        public virtual ICollection<MovCajadet> MovCajadets { get; set; }
    }
}
