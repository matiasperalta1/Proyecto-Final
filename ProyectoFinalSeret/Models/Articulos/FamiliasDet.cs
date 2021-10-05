using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class FamiliasDet
    {
        public int FadCodfam { get; set; }
        public string FadCoddet { get; set; }
        public string FadDescri { get; set; }
        public string FadDesabr { get; set; }
        public string FadObserv { get; set; }
        public int FadIdweb { get; set; }

        public virtual Familia FadCodfamNavigation { get; set; }
    }
}
