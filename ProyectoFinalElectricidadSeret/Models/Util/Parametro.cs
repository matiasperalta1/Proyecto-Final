using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Parametro
    {
        public int ParCodpar { get; set; }
        public string ParAbrevi { get; set; }
        public string ParDescri { get; set; }
        public int? ParValor { get; set; }
        public string ParObserv { get; set; }
    }
}
