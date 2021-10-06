using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class ArtMov
    {
        public decimal AymNromov { get; set; }
        public int AymLinea { get; set; }
        public decimal AymCantid { get; set; }
        public string AymCodart { get; set; }
        public int AymCodmov { get; set; }
        public int AymCoddep { get; set; }
        public DateTime? AymFecmov { get; set; }
        public string AymObserv { get; set; }

        public virtual Articulo AymCodartNavigation { get; set; }
        public virtual Deposito AymCoddepNavigation { get; set; }
        public virtual Movstock AymCodmovNavigation { get; set; }
    }
}
