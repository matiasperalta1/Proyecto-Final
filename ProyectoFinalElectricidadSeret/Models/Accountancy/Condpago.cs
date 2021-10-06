using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Condpago
    {
        public Condpago()
        {
            Clientes = new HashSet<Cliente>();
            Proveedores = new HashSet<Proveedore>();
        }

        public int CopCodcpa { get; set; }
        public string CopModulo { get; set; }
        public int? CopDias1vto { get; set; }
        public int? CopDiasuvto { get; set; }
        public int? CopDiacuo { get; set; }
        public int? CopCuotas { get; set; }
        public int? CopPartic { get; set; }
        public string CopDescri { get; set; }
        public decimal CopDto1 { get; set; }
        public decimal CopDto2 { get; set; }
        public decimal CopDto3 { get; set; }
        public decimal CopRec1 { get; set; }
        public int? CopCodlis { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
