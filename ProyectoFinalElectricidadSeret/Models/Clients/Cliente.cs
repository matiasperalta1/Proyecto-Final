using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClienContacs = new HashSet<ClienContac>();
            CobranzasClientes = new HashSet<CobranzasCliente>();
            NovedadesClientes = new HashSet<NovedadesCliente>();
            Reclamos = new HashSet<Reclamo>();
            RetClients = new HashSet<RetClient>();
        }

        public decimal CliCodcli { get; set; }
        public string CliDescri { get; set; }
        public string CliDirecc { get; set; }
        public decimal CliCodloc { get; set; }
        public decimal CliCodprv { get; set; }
        public string CliTele1 { get; set; }
        public string CliTele2 { get; set; }
        public string CliFax { get; set; }
        public string CliMail { get; set; }
        public string CliWeb { get; set; }
        public int CliCodciv { get; set; }
        public string CliCuit { get; set; }
        public string CliIngbru { get; set; }
        public DateTime? CliFecalt { get; set; }
        public int CliCodcpa { get; set; }
        public decimal CliSaldo { get; set; }
        public uint CliCodcac { get; set; }
        public string CliEstado { get; set; }
        public int? CliCodcuc { get; set; }
        public int? CliCodcob { get; set; }
        public int? CliCodven { get; set; }
        public int CliCodlis { get; set; }
        public decimal CliLimcre { get; set; }
        public int? CliCodmon { get; set; }
        public DateTime? CliFecvig { get; set; }
        public bool? CliBlofac { get; set; }
        public DateTime? CliFecufa { get; set; }
        public DateTime? CliFecure { get; set; }
        public int? CliCodgru { get; set; }
        public DateTime? CliFecnac { get; set; }
        public string CliObserv { get; set; }
        public byte? CliCtacte { get; set; }
        public bool? CliRemito { get; set; }
        public uint CliCodtra { get; set; }
        public string CliCodpos { get; set; }
        public int CliCodtdo { get; set; }

        public virtual Catclient CliCodcacNavigation { get; set; }
        public virtual Condiva CliCodcivNavigation { get; set; }
        public virtual Cobradore CliCodcobNavigation { get; set; }
        public virtual Condpago CliCodcpaNavigation { get; set; }
        public virtual Listapre CliCodlisNavigation { get; set; }
        public virtual Localidade CliCodlocNavigation { get; set; }
        public virtual Moneda CliCodmonNavigation { get; set; }
        public virtual Provincia CliCodprvNavigation { get; set; }
        public virtual Tiposdocumento CliCodtdoNavigation { get; set; }
        public virtual Vendedore CliCodvenNavigation { get; set; }
        public virtual ICollection<ClienContac> ClienContacs { get; set; }
        public virtual ICollection<CobranzasCliente> CobranzasClientes { get; set; }
        public virtual ICollection<NovedadesCliente> NovedadesClientes { get; set; }
        public virtual ICollection<Reclamo> Reclamos { get; set; }
        public virtual ICollection<RetClient> RetClients { get; set; }
    }
}
