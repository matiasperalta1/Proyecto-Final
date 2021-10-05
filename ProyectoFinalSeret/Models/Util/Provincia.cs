using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Provincia
    {
        public Provincia()
        {
            BcosCbancEmps = new HashSet<BcosCbancEmp>();
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedore>();
        }

        public decimal PrvCodprv { get; set; }
        public string PrvDescri { get; set; }

        public virtual ICollection<BcosCbancEmp> BcosCbancEmps { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
