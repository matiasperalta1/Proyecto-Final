using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Lisyreg
    {
        public int LyrCodlis { get; set; }
        public int LyrCodreg { get; set; }

        public virtual Listapre LyrCodlisNavigation { get; set; }
        public virtual Reglapre LyrCodregNavigation { get; set; }
    }
}
