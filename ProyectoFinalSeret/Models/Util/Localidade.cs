using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Localidade
    {
        public Localidade()
        {
            BcosCbancEmps = new HashSet<BcosCbancEmp>();
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedore>();
        }

        public decimal LocCodloc { get; set; }
        public string LocCodpos { get; set; }
        public string LocDescri { get; set; }
        public string LocObserv { get; set; }
        public decimal LocCodprv { get; set; }

        public virtual ICollection<BcosCbancEmp> BcosCbancEmps { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
