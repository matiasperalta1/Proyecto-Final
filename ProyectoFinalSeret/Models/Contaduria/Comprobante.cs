using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Comprobante
    {
        public Comprobante()
        {
            ComprobNumeros = new HashSet<ComprobNumero>();
            ImprComps = new HashSet<ImprComp>();
        }

        public int ComCodcom { get; set; }
        public string ComLetra { get; set; }
        public decimal? ComNumero { get; set; }
        public string ComDescri { get; set; }
        public int? ComCoddiv { get; set; }
        public string ComAbrevia { get; set; }
        public bool? ComActivo { get; set; }
        public string ComGrupo { get; set; }
        public int? ComGruact { get; set; }
        public int? ComMaxlin { get; set; }
        public int? ComCopias { get; set; }
        public string ComObserv { get; set; }
        public string ComCodcit { get; set; }
        public int? ComCodafi { get; set; }
        public string ComAbrev1 { get; set; }

        public virtual ICollection<ComprobNumero> ComprobNumeros { get; set; }
        public virtual ICollection<ImprComp> ImprComps { get; set; }
    }
}
