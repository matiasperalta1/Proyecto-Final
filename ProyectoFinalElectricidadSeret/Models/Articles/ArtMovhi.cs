using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class ArtMovhi
    {
        public uint AymNromov { get; set; }
        public decimal AymCantid { get; set; }
        public string AymCodart { get; set; }
        public string AymTipmov { get; set; }
        public int AymCoddep { get; set; }
        public DateTime AymFecmov { get; set; }
        public string AymObserv { get; set; }
        public int AymCodcom { get; set; }
        public decimal AymNrocom { get; set; }
    }
}
