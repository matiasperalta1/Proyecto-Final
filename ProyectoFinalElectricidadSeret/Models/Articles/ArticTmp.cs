using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class ArticTmp
    {
        public string TmpCodori { get; set; }
        public int TmpCodpro { get; set; }
        public string TmpCodmar { get; set; }
        public string TmpDescri { get; set; }
        public string TmpUmcomp { get; set; }
        public decimal TmpPrecos { get; set; }
        public decimal TmpValiva { get; set; }
        public int TmpCodmon { get; set; }
        public decimal TmpDtocom { get; set; }
        public DateTime? TmpFecact { get; set; }
        public string TmpTexto1 { get; set; }
        public virtual Marca TmpCodmarNavigation { get; set; }
        public virtual Proveedore TmpCodproNavigation { get; set; }
    }
}
