using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalElectricidadSeret.Models.Accountancy
{
    public class PriceList
    {
        public int NroLista { get; set; }
        public string NomLista { get; set; }
        public string TipoAct { get; set; }
        public decimal Utilidad { get; set; }
        public decimal PSinIva { get; set; }
        public decimal PConIva { get; set; }
        public string Moneda { get; set; }
    }
}
