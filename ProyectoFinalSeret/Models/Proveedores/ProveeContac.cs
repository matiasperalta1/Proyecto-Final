using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class ProveeContac
    {
        public int PycCodpro { get; set; }
        public decimal PycCodcon { get; set; }

        public virtual Contacto PycCodconNavigation { get; set; }
        public virtual Proveedore PycCodproNavigation { get; set; }
    }
}
