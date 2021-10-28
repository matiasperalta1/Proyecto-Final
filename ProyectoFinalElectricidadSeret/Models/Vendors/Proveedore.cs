using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            ArtProves = new HashSet<ArtProve>();
            ArticTmps = new HashSet<ArticTmp>();
            Articulos = new HashSet<Articulo>();
            DepbancPros = new HashSet<DepbancPro>();
            NovedadesProveeds = new HashSet<NovedadesProveed>();
            ProveeContacs = new HashSet<ProveeContac>();
            Reclamos = new HashSet<Reclamo>();
            RetProvees = new HashSet<RetProvee>();
        }

        public int ProCodpro { get; set; }
        public string ProDescri { get; set; }
        public string ProDirecc { get; set; }
        public decimal ProCodloc { get; set; }
        public decimal ProCodprv { get; set; }
        public string ProTele1 { get; set; }
        public string ProTele2 { get; set; }
        public string ProFax { get; set; }
        public string ProMail { get; set; }
        public string ProWeb { get; set; }
        public int ProCodciv { get; set; }
        public string ProCuit { get; set; }
        public string ProIngbru { get; set; }
        public DateTime ProFecalt { get; set; }
        public string ProCai { get; set; }
        public DateTime? ProVencai { get; set; }
        public string ProConcep { get; set; }
        public int ProCodcpa { get; set; }
        public decimal ProSaldo { get; set; }
        public int? ProCodmon { get; set; }
        public string ProObserv { get; set; }
        public sbyte? ProCtacte { get; set; }
        public string ProEstado { get; set; }
        public decimal? ProLimcre { get; set; }
        public DateTime? ProFecufr { get; set; }
        public DateTime? ProFecupa { get; set; }
        public decimal ProDescpa { get; set; }
        public decimal ProDeslis { get; set; }
        public string ProCodpos { get; set; }

        public virtual Condiva ProCodcivNavigation { get; set; }
        public virtual Condpago ProCodcpaNavigation { get; set; }
        public virtual Localidade ProCodlocNavigation { get; set; }
        public virtual Provincia ProCodprvNavigation { get; set; }
        public virtual ICollection<ArtProve> ArtProves { get; set; }
        public virtual ICollection<ArticTmp> ArticTmps { get; set; }
        public virtual ICollection<Articulo> Articulos { get; set; }
        public virtual ICollection<DepbancPro> DepbancPros { get; set; }
        public virtual ICollection<NovedadesProveed> NovedadesProveeds { get; set; }
        public virtual ICollection<ProveeContac> ProveeContacs { get; set; }
        public virtual ICollection<Reclamo> Reclamos { get; set; }
        public virtual ICollection<RetProvee> RetProvees { get; set; }
    }
}
