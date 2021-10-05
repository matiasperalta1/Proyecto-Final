using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Movstock
    {
        public Movstock()
        {
            ArtMovs = new HashSet<ArtMov>();
        }

        public int MosCodmov { get; set; }
        public string MosDescri { get; set; }
        public string MosConcep { get; set; }
        public string MosObserv { get; set; }
        public string MosTipmov { get; set; }

        public virtual ICollection<ArtMov> ArtMovs { get; set; }
    }
}
