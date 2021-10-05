﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class Marca
    {
        public Marca()
        {
            Articulos = new HashSet<Articulo>();
            Reglapres = new HashSet<Reglapre>();
        }

        public string MarCodmar { get; set; }
        public string MarDescri { get; set; }
        public string MarObserv { get; set; }
        public int MarIdweb { get; set; }
        public byte MarActivo { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<Reglapre> Reglapres { get; set; }
    }
}