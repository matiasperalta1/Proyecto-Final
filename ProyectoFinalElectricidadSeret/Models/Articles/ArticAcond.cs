using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class ArticAcond
    {
        public string AyaCodart { get; set; }
        public int AyaLinea { get; set; }
        public string AyaTipo { get; set; }
        public string AyaUnmed { get; set; }
        public decimal AyaCant { get; set; }
        public string AyaObserv { get; set; }
        public int AyaCoddep { get; set; }

        public virtual Articulo AyaCodartNavigation { get; set; }
    }
}
