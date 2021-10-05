using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class ClienContac
    {
        public decimal CycCodcli { get; set; }
        public decimal CycCodcon { get; set; }

        public virtual Cliente CycCodcliNavigation { get; set; }
        public virtual Contacto CycCodconNavigation { get; set; }
    }
}
