using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalElectricidadSeret.Controllers.Util.Menus
{
    public class MenuLvl1
    {
        public MenuItem Lvl1_MenuItem { get; set; }
        public ICollection<MenuLvL2> Lvl2_MenuItems { get; set; }
    }
}
