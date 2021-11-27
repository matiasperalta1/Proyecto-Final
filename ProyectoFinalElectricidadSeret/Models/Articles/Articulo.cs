using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            ArtMovs = new HashSet<ArtMov>();
            ArtProves = new HashSet<ArtProve>();
            ArticAconds = new HashSet<ArticAcond>();
            ArticStocks = new HashSet<ArticStock>();
            ArticUbics = new HashSet<ArticUbic>();
            CarritoDets = new HashSet<CarritoDet>();
            Precios = new HashSet<Precio>();
            Reclamos = new HashSet<Reclamo>();
            Reglapres = new HashSet<Reglapre>();
        }
        [DisplayName("Codigo de Articulo")]
        [Required]
        public string ArtCodart { get; set; }
        [DisplayName("Codigo de Barras")]
        public string ArtCodbar { get; set; }
        [DisplayName("Codigo Externo")]
        [Required]
        public string ArtCodori { get; set; }
        [DisplayName("Descripcion")]
        [Required]
        public string ArtDescri { get; set; }
        [DisplayName("Descripcion Larga")]
        [Required]
        public string ArtDescrl { get; set; }
        [Required]
        public bool ArtDiscon { get; set; }
        [DisplayName("Linea")]
        [Required]
        public string ArtCodlin { get; set; }
        [DisplayName("Rubro")]
        [Required]
        public string ArtCodrub { get; set; }
        [DisplayName("Sub Rubro")]
        [Required]
        public string ArtCodsru { get; set; }
        [DisplayName("Marca")]
        [Required]
        public string ArtCodmar { get; set; }
        public int ArtEmbala { get; set; }
        public string ArtUmcomp { get; set; }
        public string ArtUmvent { get; set; }
        public decimal ArtCoefcv { get; set; }
        public decimal ArtStoact { get; set; }
        public decimal ArtStocom { get; set; }
        public decimal ArtCanped { get; set; }
        public decimal ArtStomin { get; set; }
        public decimal ArtStomax { get; set; }
        public string ArtObserv { get; set; }
        public int ArtCodpro { get; set; }
        public DateTime? ArtUltcom { get; set; }
        public DateTime? ArtUltact { get; set; }
        public decimal ArtPrecos { get; set; }
        public decimal ArtDtocom { get; set; }
        public decimal ArtValiva { get; set; }
        public int ArtCodmon { get; set; }
        public int? ArtTipimp { get; set; }
        public decimal? ArtImpues { get; set; }
        public decimal ArtDtovta { get; set; }
        public decimal ArtComvta { get; set; }
        public string ArtImagen { get; set; }
        public string ArtCtacom { get; set; }
        public string ArtCtavta { get; set; }
        public string ArtCcocom { get; set; }
        public string ArtCcovta { get; set; }
        public bool? ArtUspart { get; set; }
        public bool? ArtUsseri { get; set; }
        public bool? ArtPromoc { get; set; }
        public int? ArtEquiva { get; set; }
        [DisplayName("Tipo de Articulo")]
        [Required]
        public int ArtCodtar { get; set; }
        [DisplayName("Clasificacion")]
        [Required]
        public int ArtCompue { get; set; } 
        [Required]
        public bool ArtDispon { get; set; }
        public string ArtCodcab { get; set; }
        public byte ArtStover { get; set; }
        public bool ArtAcondi { get; set; }
        public string ArtImaux1 { get; set; }
        public string ArtImaux2 { get; set; }
        public string ArtImaux3 { get; set; }
        public string ArtImaux4 { get; set; }
        public byte ArtEcopro { get; set; }
        public byte ArtEcomp1 { get; set; }
        public byte ArtEcomp2 { get; set; }
        public byte ArtEcomp3 { get; set; }
        public byte ArtDestac { get; set; }
        public decimal ArtAlto { get; set; }
        public decimal ArtAncho { get; set; }
        public decimal ArtProfun { get; set; }
        public decimal ArtPeso { get; set; }
        public decimal ArtVolume { get; set; }
        public string ArtAgrmp1 { get; set; }
        public string ArtAgrmp2 { get; set; }
        public string ArtAgrmp3 { get; set; }
        public string ArtTags { get; set; }

        public virtual Linea ArtCodlinNavigation { get; set; }
        public virtual Marca ArtCodmarNavigation { get; set; }
        public virtual Moneda ArtCodmonNavigation { get; set; }
        public virtual Proveedore ArtCodproNavigation { get; set; }
        public virtual Rubro ArtCodrubNavigation { get; set; }
        public virtual Subrubro ArtCodsruNavigation { get; set; }
        public virtual Tipoart ArtCodtarNavigation { get; set; }
        public virtual Equivalencia Equivalencia { get; set; }
        public virtual ICollection<ArtMov> ArtMovs { get; set; }
        public virtual ICollection<ArtProve> ArtProves { get; set; }
        public virtual ICollection<ArticAcond> ArticAconds { get; set; }
        public virtual ICollection<ArticStock> ArticStocks { get; set; }
        public virtual ICollection<ArticUbic> ArticUbics { get; set; }
        public virtual ICollection<CarritoDet> CarritoDets { get; set; }
        public virtual ICollection<Precio> Precios { get; set; }
        public virtual ICollection<Reclamo> Reclamos { get; set; }
        public virtual ICollection<Reglapre> Reglapres { get; set; }
    }
}
