using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Carrito
    {
        public Carrito()
        {
            CarritoDets = new HashSet<CarritoDet>();
        }

        public int CarId { get; set; }
        public DateTime? CarFecha { get; set; }

        public virtual ICollection<CarritoDet> CarritoDets { get; set; }
    }
}
