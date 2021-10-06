using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Puesto
    {
        public Puesto()
        {
            ImprComps = new HashSet<ImprComp>();
        }

        public int PueCodpue { get; set; }
        public string PueNompc { get; set; }
        public string PueDirip { get; set; }
        public string PueDespue { get; set; }
        public bool? PueImpfis { get; set; }
        public int? PuePuefis { get; set; }
        public int PueCoddep { get; set; }
        public string PueUsuari { get; set; }
        public int PueCodlis { get; set; }
        public int? PuePresis { get; set; }
        public int? PuePreman { get; set; }
        public int? PuePrefis { get; set; }
        public int? PuePreots { get; set; }
        public string PueHtmail { get; set; }
        public int PuePtmail { get; set; }
        public string PueUsmail { get; set; }
        public string PuePsmail { get; set; }
        public int? PuePrecel { get; set; }

        public virtual Deposito PueCoddepNavigation { get; set; }
        public virtual ICollection<ImprComp> ImprComps { get; set; }
    }
}
