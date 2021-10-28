using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Vendedore
    {
        public Vendedore()
        {
            Clientes = new HashSet<Cliente>();
        }
        public int VenCodven { get; set; }
        public decimal VenComisi { get; set; }
        public string VenCuil { get; set; }
        public string VenDescri { get; set; }
        public DateTime? VenFecing { get; set; }
        public decimal VenNroleg { get; set; }
        public decimal VenNrotar { get; set; }
        public string VenObserv { get; set; }
        public decimal VenPin { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
