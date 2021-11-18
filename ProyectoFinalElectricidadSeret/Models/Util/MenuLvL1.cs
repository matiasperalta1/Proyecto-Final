using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalElectricidadSeret.Models
{
    public class MenuLvl1
    {
        public string Lvl1_MenuName { get; set; }
        public int Lvl1_MenuOrder { get; set; }
        public ICollection<MenuLvL2> Lvl2_MenuItems { get; set; }
    }
}
