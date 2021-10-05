using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class ArticUbic
    {
        public string AyuCodart { get; set; }
        public int AyuCoddep { get; set; }
        public string AyuGalpon { get; set; }
        public string AyuPasillo { get; set; }
        public string AyuEstant { get; set; }
        public string AyuNivel { get; set; }

        public virtual Articulo AyuCodartNavigation { get; set; }
        public virtual Deposito AyuCoddepNavigation { get; set; }
    }
}
