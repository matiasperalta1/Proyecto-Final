﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Tarjeta
    {
        public int TarCodtar { get; set; }
        public string TarDestar { get; set; }
        public int? TarCodban { get; set; }
        public string TarTiptar { get; set; }
        public string TarObserv { get; set; }
    }
}