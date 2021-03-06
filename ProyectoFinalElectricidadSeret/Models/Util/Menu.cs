using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Menu
    {
        public Menu()
        {
            UsuaMenus = new HashSet<UsuaMenu>();
        }

        public int MenCodmen { get; set; }
        public string MenMenu { get; set; }
        public short MenMenord { get; set; }
        public string MenSubmen { get; set; }
        public short MenSbmord { get; set; }
        public string MenSsbmen { get; set; }
        public short MenSsbord { get; set; }
        public string MenFormul { get; set; }
        public string MenObserv { get; set; }
        public string MenController { get; set; }
        public string MenAction { get; set; }

        public virtual ICollection<UsuaMenu> UsuaMenus { get; set; }
    }
}
