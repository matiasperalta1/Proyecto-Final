using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class BcosCbancEmp
    {
        public decimal BceCodbce { get; set; }
        public string BceDesban { get; set; }
        public string BceDirecc { get; set; }
        public decimal BceCodloc { get; set; }
        public decimal BceCodprv { get; set; }
        public string BceTele1 { get; set; }
        public string BceTele2 { get; set; }
        public string BceFax { get; set; }
        public string BceMail { get; set; }
        public string BceWeb { get; set; }
        public int? BceCodciv { get; set; }
        public string BceCuit { get; set; }
        public string BceIngbru { get; set; }
        public DateTime? BceFecalt { get; set; }
        public string BceTipcue { get; set; }
        public string BceDescta { get; set; }
        public string BceNrocta { get; set; }
        public string BceCbucta { get; set; }
        public string BceSuccta { get; set; }
        public int? BceCodmon { get; set; }
        public decimal? BceDescub { get; set; }
        public double? BceSaldo { get; set; }
        public int? BceCodcuc { get; set; }
        public string BceObserv { get; set; }

        public virtual Condiva BceCodcivNavigation { get; set; }
        public virtual Localidade BceCodlocNavigation { get; set; }
        public virtual Provincia BceCodprvNavigation { get; set; }
    }
}
