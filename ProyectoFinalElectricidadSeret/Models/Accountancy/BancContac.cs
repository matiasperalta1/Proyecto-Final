using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class BancContac
    {
        public int BycCodbce { get; set; }
        public decimal BycCodcon { get; set; }

        public virtual Banco BycCodbceNavigation { get; set; }
        public virtual Contacto BycCodconNavigation { get; set; }
    }
}
