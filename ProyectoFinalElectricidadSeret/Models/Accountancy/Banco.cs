using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Banco
    {
        public Banco()
        {
            BancContacs = new HashSet<BancContac>();
            Chequeras = new HashSet<Chequera>();
            Ctasbancs = new HashSet<Ctasbanc>();
            Tarjeta = new HashSet<Tarjeta>();
        }

        public int BanCodban { get; set; }
        public string BanDesban { get; set; }
        public string BanAbrevi { get; set; }

        public virtual ICollection<BancContac> BancContacs { get; set; }
        public virtual ICollection<Chequera> Chequeras { get; set; }
        public virtual ICollection<Ctasbanc> Ctasbancs { get; set; }
        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
    }
}
