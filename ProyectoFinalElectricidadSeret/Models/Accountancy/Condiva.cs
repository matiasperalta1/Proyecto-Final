using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Condiva
    {
        public Condiva()
        {
            BcosCbancEmps = new HashSet<BcosCbancEmp>();
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedore>();
        }

        public int CoiCodciv { get; set; }
        public string CoiDescri { get; set; }
        public string CoiAbrevi { get; set; }
        public string CoiLetrac { get; set; }
        public string CoiTasdif { get; set; }

        public virtual ICollection<BcosCbancEmp> BcosCbancEmps { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
