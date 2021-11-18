using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalElectricidadSeret.Models
{
    public class MenuItem
    {
        public string MenuItemName { get; set; }
        public string MenuItemAction { get; set; }
        public string MenuItemController { get; set; }
        public int MenuItemOrder { get; set; }
    }
}
