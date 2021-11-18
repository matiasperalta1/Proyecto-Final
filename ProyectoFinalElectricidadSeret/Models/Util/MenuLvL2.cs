using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalElectricidadSeret.Models
{
    public class MenuLvL2
    {
        public MenuItem Lvl2_MenuItem{ get; set; }
        public ICollection<MenuItem> Lvl3_MenuItems { get; set; }
    }
}
