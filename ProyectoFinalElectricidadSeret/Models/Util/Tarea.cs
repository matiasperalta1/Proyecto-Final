using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Tarea
    {
        public int TarId { get; set; }
        public string TarModulo { get; set; }
        public string TarDescri { get; set; }
        public string TarPuesto { get; set; }
        public string TarUsuari { get; set; }
    }
}
