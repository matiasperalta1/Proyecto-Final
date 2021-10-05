using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalSeret.Models.Util
{
    public partial class CarritoDet
    {
        public int CadId { get; set; }
        public int CadCarid { get; set; }
        public string CadCodart { get; set; }
        public double CadCantid { get; set; }

        public virtual Carrito CadCar { get; set; }
    }
}
