using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Familia
    {
        public Familia()
        {
            FamiliasDets = new HashSet<FamiliasDet>();
        }

        public int FamCodfam { get; set; }
        public string FamDescri { get; set; }
        public string FamObserv { get; set; }

        public virtual ICollection<FamiliasDet> FamiliasDets { get; set; }
    }
}
