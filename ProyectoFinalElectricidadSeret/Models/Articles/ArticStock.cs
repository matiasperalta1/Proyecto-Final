using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class ArticStock
    {
        public string AstCodart { get; set; }
        public int AstCoddep { get; set; }
        public decimal AstStoact { get; set; }
        public decimal AstStocom { get; set; }
        public decimal AstStomin { get; set; }
        public decimal AstStomax { get; set; }
        public decimal AstCanped { get; set; }
        public string AstObserv { get; set; }

        public virtual Articulo AstCodartNavigation { get; set; }
        public virtual Deposito AstCoddepNavigation { get; set; }
    }
}
