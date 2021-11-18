using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProyectoFinalElectricidadSeret.Models;

#nullable disable

namespace ProyectoFinalElectricidadSeret.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acceso> Accesos { get; set; }
        public virtual DbSet<ArtComp> ArtComps { get; set; }
        public virtual DbSet<ArtEtiq> ArtEtiqs { get; set; }
        public virtual DbSet<ArtImp> ArtImps { get; set; }
        public virtual DbSet<ArtMov> ArtMovs { get; set; }
        public virtual DbSet<ArtMovhi> ArtMovhis { get; set; }
        public virtual DbSet<ArtProve> ArtProves { get; set; }
        public virtual DbSet<ArticAcond> ArticAconds { get; set; }
        public virtual DbSet<ArticAct> ArticActs { get; set; }
        public virtual DbSet<ArticStock> ArticStocks { get; set; }
        public virtual DbSet<ArticTmp> ArticTmps { get; set; }
        public virtual DbSet<ArticUbic> ArticUbics { get; set; }
        public virtual DbSet<Articulo> Articulos { get; set; }
        public virtual DbSet<ArticulosH> ArticulosHes { get; set; }
        public virtual DbSet<BancContac> BancContacs { get; set; }
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<BcosCbancEmp> BcosCbancEmps { get; set; }
        public virtual DbSet<Caja> Cajas { get; set; }
        public virtual DbSet<CajasAyc> CajasAycs { get; set; }
        public virtual DbSet<Carrito> Carritos { get; set; }
        public virtual DbSet<CarritoDet> CarritoDets { get; set; }
        public virtual DbSet<CasillasCorreo> CasillasCorreos { get; set; }
        public virtual DbSet<Catclient> Catclients { get; set; }
        public virtual DbSet<Ccosto> Ccostos { get; set; }
        public virtual DbSet<CeCabecera> CeCabeceras { get; set; }
        public virtual DbSet<CeCbesAsoc> CeCbesAsocs { get; set; }
        public virtual DbSet<CeIva> CeIvas { get; set; }
        public virtual DbSet<CeTiqueAcceso> CeTiqueAccesos { get; set; }
        public virtual DbSet<CeTributo> CeTributos { get; set; }
        public virtual DbSet<CheqEmit> CheqEmits { get; set; }
        public virtual DbSet<Cheqrec> Cheqrecs { get; set; }
        public virtual DbSet<Chequera> Chequeras { get; set; }
        public virtual DbSet<ClienContac> ClienContacs { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClientesVie> ClientesVies { get; set; }
        public virtual DbSet<Cobradore> Cobradores { get; set; }
        public virtual DbSet<CobranzasCliente> CobranzasClientes { get; set; }
        public virtual DbSet<CompConfigNo> CompConfigNos { get; set; }
        public virtual DbSet<ComprobNumero> ComprobNumeros { get; set; }
        public virtual DbSet<Comprobante> Comprobantes { get; set; }
        public virtual DbSet<Concepto> Conceptos { get; set; }
        public virtual DbSet<Condiva> Condivas { get; set; }
        public virtual DbSet<Condpago> Condpagos { get; set; }
        public virtual DbSet<CondpagoAnt> CondpagoAnts { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<ContrFiscal> ContrFiscals { get; set; }
        public virtual DbSet<Coperacion> Coperacions { get; set; }
        public virtual DbSet<Ctasbanc> Ctasbancs { get; set; }
        public virtual DbSet<CtasbancPro> CtasbancPros { get; set; }
        public virtual DbSet<Ctasctesc> Ctasctescs { get; set; }
        public virtual DbSet<CtasctescDet> CtasctescDets { get; set; }
        public virtual DbSet<Ctasctesv> Ctasctesvs { get; set; }
        public virtual DbSet<CtasctesvDet> CtasctesvDets { get; set; }
        public virtual DbSet<DepbancCli> DepbancClis { get; set; }
        public virtual DbSet<DepbancPro> DepbancPros { get; set; }
        public virtual DbSet<Deposito> Depositos { get; set; }
        public virtual DbSet<DevolucMot> DevolucMots { get; set; }
        public virtual DbSet<Devolucione> Devoluciones { get; set; }
        public virtual DbSet<Divisione> Divisiones { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Equivalencia> Equivalencias { get; set; }
        public virtual DbSet<Errore> Errores { get; set; }
        public virtual DbSet<Facturasc> Facturascs { get; set; }
        public virtual DbSet<FacturascDet> FacturascDets { get; set; }
        public virtual DbSet<Facturasv> Facturasvs { get; set; }
        public virtual DbSet<FacturasvDet> FacturasvDets { get; set; }
        public virtual DbSet<Familia> Familias { get; set; }
        public virtual DbSet<FamiliasDet> FamiliasDets { get; set; }
        public virtual DbSet<ImprComp> ImprComps { get; set; }
        public virtual DbSet<ImpresorasNo> ImpresorasNos { get; set; }
        public virtual DbSet<Iva> Ivas { get; set; }
        public virtual DbSet<Linea> Lineas { get; set; }
        public virtual DbSet<Listapre> Listapres { get; set; }
        public virtual DbSet<Lisyreg> Lisyregs { get; set; }
        public virtual DbSet<Localidade> Localidades { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Mediopago> Mediopagos { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuBak> MenuBaks { get; set; }
        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<MonedasH> MonedasHes { get; set; }
        public virtual DbSet<MovCaja> MovCajas { get; set; }
        public virtual DbSet<MovCajadet> MovCajadets { get; set; }
        public virtual DbSet<Movstock> Movstocks { get; set; }
        public virtual DbSet<NovedadesCliente> NovedadesClientes { get; set; }
        public virtual DbSet<NovedadesProveed> NovedadesProveeds { get; set; }
        public virtual DbSet<Pagosccc> Pagoscccs { get; set; }
        public virtual DbSet<PagoscccDet> PagoscccDets { get; set; }
        public virtual DbSet<Pagosccv> Pagosccvs { get; set; }
        public virtual DbSet<PagosccvDet> PagosccvDets { get; set; }
        public virtual DbSet<Pagoscoc> Pagoscocs { get; set; }
        public virtual DbSet<PagoscocDet> PagoscocDets { get; set; }
        public virtual DbSet<Pagoscov> Pagoscovs { get; set; }
        public virtual DbSet<PagoscovDet> PagoscovDets { get; set; }
        public virtual DbSet<Paise> Paises { get; set; }
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<Pedidosc> Pedidoscs { get; set; }
        public virtual DbSet<PedidoscDet> PedidoscDets { get; set; }
        public virtual DbSet<Pedidosv> Pedidosvs { get; set; }
        public virtual DbSet<PedidosvDet> PedidosvDets { get; set; }
        public virtual DbSet<Pre> Pres { get; set; }
        public virtual DbSet<Precio> Precios { get; set; }
        public virtual DbSet<Presup> Presups { get; set; }
        public virtual DbSet<PresupDet> PresupDets { get; set; }
        public virtual DbSet<Presupmod> Presupmods { get; set; }
        public virtual DbSet<PresupmodDet> PresupmodDets { get; set; }
        public virtual DbSet<Promocione> Promociones { get; set; }
        public virtual DbSet<ProveeContac> ProveeContacs { get; set; }
        public virtual DbSet<Proveedore> Proveedores { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Puesto> Puestos { get; set; }
        public virtual DbSet<ReclMov> ReclMovs { get; set; }
        public virtual DbSet<Reclamo> Reclamos { get; set; }
        public virtual DbSet<Reglapre> Reglapres { get; set; }
        public virtual DbSet<Remitosc> Remitoscs { get; set; }
        public virtual DbSet<RemitoscDet> RemitoscDets { get; set; }
        public virtual DbSet<Remitosv> Remitosvs { get; set; }
        public virtual DbSet<RemitosvDet> RemitosvDets { get; set; }
        public virtual DbSet<RetClient> RetClients { get; set; }
        public virtual DbSet<RetProvee> RetProvees { get; set; }
        public virtual DbSet<Retencione> Retenciones { get; set; }
        public virtual DbSet<Rubro> Rubros { get; set; }
        public virtual DbSet<SgiGrup> SgiGrups { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Subrubro> Subrubros { get; set; }
        public virtual DbSet<Tarea> Tareas { get; set; }
        public virtual DbSet<Tarjeta> Tarjetas { get; set; }
        public virtual DbSet<Tarjrec> Tarjrecs { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }
        public virtual DbSet<Tipoart> Tipoarts { get; set; }
        public virtual DbSet<Tiposdocumento> Tiposdocumentos { get; set; }
        public virtual DbSet<Transporte> Transportes { get; set; }
        public virtual DbSet<Unimed> Unimeds { get; set; }
        public virtual DbSet<UsuaMenu> UsuaMenus { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vendedore> Vendedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Acceso>(entity =>
            {
                entity.HasKey(e => new { e.AccCodacc, e.AccFecing })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("accesos");

                entity.HasComment("Ingressos y egresos al sistema")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.AccCodacc)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ACC_CODACC")
                    .HasComment("Ingreso");

                entity.Property(e => e.AccFecing)
                    .HasColumnType("timestamp")
                    .HasColumnName("ACC_FECING")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.AccNompc)
                    .HasMaxLength(15)
                    .HasColumnName("ACC_NOMPC")
                    .HasComment("puesto");

                entity.Property(e => e.AccNomusu)
                    .HasMaxLength(10)
                    .HasColumnName("ACC_NOMUSU")
                    .HasComment("Usuario");

                entity.Property(e => e.AccObserv)
                    .HasMaxLength(30)
                    .HasColumnName("ACC_OBSERV");

                entity.Property(e => e.AccTipo)
                    .HasMaxLength(1)
                    .HasColumnName("ACC_TIPO")
                    .HasComment("tipo de movimiento E/S");
            });

            modelBuilder.Entity<ArtComp>(entity =>
            {
                entity.HasKey(e => e.ArcCodart)
                    .HasName("PRIMARY");

                entity.ToTable("art_comp");

                entity.HasComment("Articulos compuestos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.ArcCodart)
                    .HasMaxLength(15)
                    .HasColumnName("ARC_CODART")
                    .HasComment("codigo del articulo");

                entity.Property(e => e.ArcCantid)
                    .HasPrecision(7, 2)
                    .HasColumnName("ARC_CANTID")
                    .HasComment("Cantidad");

                entity.Property(e => e.ArcCodcom)
                    .HasMaxLength(15)
                    .HasColumnName("ARC_CODCOM")
                    .HasComment("codigo del articulo que lo forma");

                entity.Property(e => e.ArcObserv)
                    .HasMaxLength(40)
                    .HasColumnName("ARC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<ArtEtiq>(entity =>
            {
                entity.HasKey(e => e.EtiId)
                    .HasName("PRIMARY");

                entity.ToTable("art_etiq");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.EtiId)
                    .HasColumnName("ETI_ID")
                    .HasComment("Id Etiqueta");

                entity.Property(e => e.EtiCantid)
                    .HasColumnName("ETI_CANTID")
                    .HasComment("Cantidad");

                entity.Property(e => e.EtiCodart)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("ETI_CODART")
                    .HasDefaultValueSql("' '")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.EtiLote)
                    .HasColumnName("ETI_LOTE")
                    .HasComment("Lote");
            });

            modelBuilder.Entity<ArtImp>(entity =>
            {
                entity.HasKey(e => e.AriId)
                    .HasName("PRIMARY");

                entity.ToTable("art_imp");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.AriId).HasColumnName("ARI_ID");

                entity.Property(e => e.AriCodart)
                    .HasMaxLength(15)
                    .HasColumnName("ARI_CODART");

                entity.Property(e => e.AriError)
                    .HasMaxLength(255)
                    .HasColumnName("ARI_ERROR");

                entity.Property(e => e.AriFechor)
                    .HasColumnType("timestamp")
                    .HasColumnName("ARI_FECHOR")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<ArtMov>(entity =>
            {
                entity.HasKey(e => new { e.AymNromov, e.AymLinea })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("art_mov");

                entity.HasComment("Articulos - Movimientos de stock")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.AymCodart, "fk_art_mov_articulos1");

                entity.HasIndex(e => e.AymCoddep, "fk_art_mov_depositos1");

                entity.HasIndex(e => e.AymCodmov, "fk_art_mov_movstock1");

                entity.Property(e => e.AymNromov)
                    .HasPrecision(12)
                    .HasColumnName("AYM_NROMOV")
                    .HasComment("Nro de movimiento");

                entity.Property(e => e.AymLinea)
                    .HasColumnName("AYM_LINEA")
                    .HasComment("Linea");

                entity.Property(e => e.AymCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("AYM_CANTID")
                    .HasComment("Cantidad");

                entity.Property(e => e.AymCodart)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("AYM_CODART")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Codigo del articulo");

                entity.Property(e => e.AymCoddep)
                    .HasColumnName("AYM_CODDEP")
                    .HasComment("Codigo de deposito");

                entity.Property(e => e.AymCodmov)
                    .HasColumnName("AYM_CODMOV")
                    .HasComment("Codigo de movimiento");

                entity.Property(e => e.AymFecmov)
                    .HasColumnType("date")
                    .HasColumnName("AYM_FECMOV")
                    .HasComment("Fecha del movimiento");

                entity.Property(e => e.AymObserv)
                    .HasMaxLength(30)
                    .HasColumnName("AYM_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.AymCodartNavigation)
                    .WithMany(p => p.ArtMovs)
                    .HasForeignKey(d => d.AymCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_art_mov_articulos1");

                entity.HasOne(d => d.AymCoddepNavigation)
                    .WithMany(p => p.ArtMovs)
                    .HasForeignKey(d => d.AymCoddep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_art_mov_depositos1");

                entity.HasOne(d => d.AymCodmovNavigation)
                    .WithMany(p => p.ArtMovs)
                    .HasForeignKey(d => d.AymCodmov)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_art_mov_movstock1");
            });

            modelBuilder.Entity<ArtMovhi>(entity =>
            {
                entity.HasKey(e => e.AymNromov)
                    .HasName("PRIMARY");

                entity.ToTable("art_movhis");

                entity.HasComment("Articulos -\r\n\r\nMovimientos de stock hist")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.AymCodart, "fk_art_mov_articulos1");

                entity.HasIndex(e => e.AymCoddep, "fk_art_mov_depositos1");

                entity.Property(e => e.AymNromov)
                    .HasColumnName("AYM_NROMOV")
                    .HasComment("Nro de movimiento");

                entity.Property(e => e.AymCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("AYM_CANTID")
                    .HasComment("Cantidad");

                entity.Property(e => e.AymCodart)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("AYM_CODART")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Codigo del articulo");

                entity.Property(e => e.AymCodcom)
                    .HasColumnName("AYM_CODCOM")
                    .HasComment("Cod. Comprobante");

                entity.Property(e => e.AymCoddep)
                    .HasColumnName("AYM_CODDEP")
                    .HasComment("Codigo de deposito");

                entity.Property(e => e.AymFecmov)
                    .HasColumnType("timestamp")
                    .HasColumnName("AYM_FECMOV")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Fecha del movimiento");

                entity.Property(e => e.AymNrocom)
                    .HasPrecision(12)
                    .HasColumnName("AYM_NROCOM")
                    .HasComment("Nro. Comprobante");

                entity.Property(e => e.AymObserv)
                    .HasMaxLength(30)
                    .HasColumnName("AYM_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.AymTipmov)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("AYM_TIPMOV")
                    .HasDefaultValueSql("' '")
                    .HasComment("Tipo de movimiento");
            });

            modelBuilder.Entity<ArtProve>(entity =>
            {
                entity.HasKey(e => new { e.AypCodpro, e.AypCodart })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("art_prove");

                entity.HasComment("articulos y proveedores")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.AypCodart, "fk_art_prove_articulos1");

                entity.Property(e => e.AypCodpro)
                    .HasColumnName("AYP_CODPRO")
                    .HasComment("Codigo de proveedor");

                entity.Property(e => e.AypCodart)
                    .HasMaxLength(15)
                    .HasColumnName("AYP_CODART")
                    .HasComment("Codigo de articulo");

                entity.HasOne(d => d.AypCodartNavigation)
                    .WithMany(p => p.ArtProves)
                    .HasForeignKey(d => d.AypCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_art_prove_articulos1");

                entity.HasOne(d => d.AypCodproNavigation)
                    .WithMany(p => p.ArtProves)
                    .HasForeignKey(d => d.AypCodpro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_art_prove_proveedores1");
            });

            modelBuilder.Entity<ArticAcond>(entity =>
            {
                entity.HasKey(e => new { e.AyaCodart, e.AyaLinea })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("artic_acond");

                entity.HasComment("Articulos y acondicionamientos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.AyaCodart)
                    .HasMaxLength(15)
                    .HasColumnName("AYA_CODART")
                    .HasComment("Codigo de Articulo");

                entity.Property(e => e.AyaLinea)
                    .HasColumnName("AYA_LINEA")
                    .HasComment("Linea");

                entity.Property(e => e.AyaCant)
                    .HasPrecision(13, 2)
                    .HasColumnName("AYA_CANT")
                    .HasComment("Cantidad");

                entity.Property(e => e.AyaCoddep)
                    .HasColumnName("AYA_CODDEP")
                    .HasComment("Deposito");

                entity.Property(e => e.AyaObserv)
                    .HasMaxLength(50)
                    .HasColumnName("AYA_OBSERV")
                    .HasComment("Observaciones")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.AyaTipo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("AYA_TIPO")
                    .HasComment("Tipo acondiconamiento ROLLO BOBINA")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.AyaUnmed)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("AYA_UNMED")
                    .HasDefaultValueSql("' '")
                    .HasComment("Unidad de medida")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.HasOne(d => d.AyaCodartNavigation)
                    .WithMany(p => p.ArticAconds)
                    .HasForeignKey(d => d.AyaCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_art_acond_articulos");
            });

            modelBuilder.Entity<ArticAct>(entity =>
            {
                entity.HasKey(e => new { e.TmpCodmar, e.TmpCodori })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("artic_act");

                entity.HasComment("Temporario de articulos p/actualizar precios")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TmpCodori, "kf_art_act_articulos_idx");

                entity.Property(e => e.TmpCodmar)
                    .HasMaxLength(15)
                    .HasColumnName("TMP_CODMAR")
                    .HasComment("Codigo de Marca");

                entity.Property(e => e.TmpCodori)
                    .HasMaxLength(20)
                    .HasColumnName("TMP_CODORI")
                    .HasComment("Codigo de Articulo");

                entity.Property(e => e.TmpPrecos)
                    .HasPrecision(13, 2)
                    .HasColumnName("TMP_PRECOS")
                    .HasComment("Precio de costo");

                entity.HasOne(d => d.TmpCodmarNavigation)
                    .WithMany(p => p.ArticActs)
                    .HasForeignKey(d => d.TmpCodmar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_art_act_marcas");
            });

            modelBuilder.Entity<ArticStock>(entity =>
            {
                entity.HasKey(e => new { e.AstCodart, e.AstCoddep })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("artic_stock");

                entity.HasComment("Stock de articulos por deposito")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.AstCodart, "fk_artic_stock_articulos1");

                entity.HasIndex(e => e.AstCoddep, "fk_artic_stock_depositos1");

                entity.Property(e => e.AstCodart)
                    .HasMaxLength(15)
                    .HasColumnName("AST_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.AstCoddep)
                    .HasColumnName("AST_CODDEP")
                    .HasComment("Codigo de Deposito");

                entity.Property(e => e.AstCanped)
                    .HasPrecision(13, 2)
                    .HasColumnName("AST_CANPED")
                    .HasComment("cantidad pedida del deposito");

                entity.Property(e => e.AstObserv)
                    .HasMaxLength(40)
                    .HasColumnName("AST_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.AstStoact)
                    .HasPrecision(13, 2)
                    .HasColumnName("AST_STOACT")
                    .HasComment("Stock actual del dpeosito");

                entity.Property(e => e.AstStocom)
                    .HasPrecision(13, 2)
                    .HasColumnName("AST_STOCOM")
                    .HasComment("Stock comprometido del deposito");

                entity.Property(e => e.AstStomax)
                    .HasPrecision(13, 2)
                    .HasColumnName("AST_STOMAX")
                    .HasComment("Stock maximo del deposito");

                entity.Property(e => e.AstStomin)
                    .HasPrecision(13, 2)
                    .HasColumnName("AST_STOMIN")
                    .HasComment("Stock minimo del deposito");

                entity.HasOne(d => d.AstCodartNavigation)
                    .WithMany(p => p.ArticStocks)
                    .HasForeignKey(d => d.AstCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artic_stock_articulos1");

                entity.HasOne(d => d.AstCoddepNavigation)
                    .WithMany(p => p.ArticStocks)
                    .HasForeignKey(d => d.AstCoddep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artic_stock_depositos1");
            });

            modelBuilder.Entity<ArticTmp>(entity =>
            {
                entity.HasKey(e => new { e.TmpCodori, e.TmpCodpro, e.TmpCodmar })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("artic_tmp");

                entity.HasComment("Temporario de articulos p/actualizar precios")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TmpCodmar, "fk_artic_tmp_marcas_idx");

                entity.HasIndex(e => e.TmpCodpro, "fk_artic_tmp_proveedores_idx");

                entity.Property(e => e.TmpCodori)
                    .HasMaxLength(20)
                    .HasColumnName("TMP_CODORI")
                    .HasComment("Codigo de Articulo");

                entity.Property(e => e.TmpCodpro)
                    .HasColumnName("TMP_CODPRO")
                    .HasComment("Codigo de proveedor");

                entity.Property(e => e.TmpCodmar)
                    .HasMaxLength(15)
                    .HasColumnName("TMP_CODMAR")
                    .HasComment("Codigo de Marca");

                entity.Property(e => e.TmpCodmon)
                    .HasColumnName("TMP_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.TmpDescri)
                    .HasMaxLength(40)
                    .HasColumnName("TMP_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.TmpDtocom)
                    .HasPrecision(5, 2)
                    .HasColumnName("TMP_DTOCOM")
                    .HasComment("Descuento");

                entity.Property(e => e.TmpFecact)
                    .HasColumnType("date")
                    .HasColumnName("TMP_FECACT")
                    .HasComment("Fecha de actualizacion");

                entity.Property(e => e.TmpPrecos)
                    .HasPrecision(13, 2)
                    .HasColumnName("TMP_PRECOS")
                    .HasComment("Precio de costo");

                entity.Property(e => e.TmpTexto1)
                    .HasMaxLength(100)
                    .HasColumnName("TMP_TEXTO1")
                    .HasComment("Informacion adicional");

                entity.Property(e => e.TmpUmcomp)
                    .HasMaxLength(6)
                    .HasColumnName("TMP_UMCOMP");

                entity.Property(e => e.TmpValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("TMP_VALIVA")
                    .HasComment("Valor de Iva");

                entity.HasOne(d => d.TmpCodmarNavigation)
                    .WithMany(p => p.ArticTmps)
                    .HasForeignKey(d => d.TmpCodmar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artic_tmp_marcas");

                entity.HasOne(d => d.TmpCodproNavigation)
                    .WithMany(p => p.ArticTmps)
                    .HasForeignKey(d => d.TmpCodpro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artic_tmp_proveedores");
            });

            modelBuilder.Entity<ArticUbic>(entity =>
            {
                entity.HasKey(e => new { e.AyuCodart, e.AyuCoddep })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("artic_ubic");

                entity.HasComment("Ubicación de los artículos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.AyuCodart, "fk_artic_ubic_articulos1");

                entity.HasIndex(e => e.AyuCoddep, "fk_artic_ubic_depositos1");

                entity.Property(e => e.AyuCodart)
                    .HasMaxLength(15)
                    .HasColumnName("AYU_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.AyuCoddep)
                    .HasColumnName("AYU_CODDEP")
                    .HasComment("Codigo de Deposito");

                entity.Property(e => e.AyuEstant)
                    .HasMaxLength(15)
                    .HasColumnName("AYU_ESTANT")
                    .HasComment("Estanteria");

                entity.Property(e => e.AyuGalpon)
                    .HasMaxLength(15)
                    .HasColumnName("AYU_GALPON")
                    .HasComment("Deposito fisico");

                entity.Property(e => e.AyuNivel)
                    .HasMaxLength(15)
                    .HasColumnName("AYU_NIVEL")
                    .HasComment("Nivel");

                entity.Property(e => e.AyuPasillo)
                    .HasMaxLength(15)
                    .HasColumnName("AYU_PASILLO")
                    .HasComment("Pasillo");

                entity.HasOne(d => d.AyuCodartNavigation)
                    .WithMany(p => p.ArticUbics)
                    .HasForeignKey(d => d.AyuCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artic_ubic_articulos1");

                entity.HasOne(d => d.AyuCoddepNavigation)
                    .WithMany(p => p.ArticUbics)
                    .HasForeignKey(d => d.AyuCoddep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_artic_ubic_depositos1");
            });

            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.ArtCodart)
                    .HasName("PRIMARY");

                entity.ToTable("articulos");

                entity.HasComment("Maestro de Articulos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ArtCodbar, "articulos_01");

                entity.HasIndex(e => new { e.ArtCompue, e.ArtCodcab }, "articulos_02");

                entity.HasIndex(e => e.ArtDescri, "articulos_03");

                entity.HasIndex(e => e.ArtCodlin, "fk_articulos_linea1");

                entity.HasIndex(e => e.ArtCodmar, "fk_articulos_marcas1");

                entity.HasIndex(e => e.ArtCodmon, "fk_articulos_monedas1");

                entity.HasIndex(e => e.ArtCodpro, "fk_articulos_proveedores1");

                entity.HasIndex(e => e.ArtCodrub, "fk_articulos_rubros1");

                entity.HasIndex(e => e.ArtCodsru, "fk_articulos_subrubros1");

                entity.HasIndex(e => e.ArtCodtar, "fk_articulos_tipoart1");

                entity.Property(e => e.ArtCodart)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.ArtAcondi)
                    .HasColumnName("ART_ACONDI")
                    .HasComment("Acondicionamiento");

                entity.Property(e => e.ArtAgrmp1)
                    .HasColumnType("text")
                    .HasColumnName("ART_AGRMP1")
                    .HasComment("Agrupammiento MP1");

                entity.Property(e => e.ArtAgrmp2)
                    .HasColumnType("text")
                    .HasColumnName("ART_AGRMP2")
                    .HasComment("Agrupamiento MP2");

                entity.Property(e => e.ArtAgrmp3)
                    .HasColumnType("text")
                    .HasColumnName("ART_AGRMP3")
                    .HasComment("Agrupamiento MP3");

                entity.Property(e => e.ArtAlto)
                    .HasPrecision(7, 2)
                    .HasColumnName("ART_ALTO")
                    .HasComment("Alto cm");

                entity.Property(e => e.ArtAncho)
                    .HasPrecision(7, 2)
                    .HasColumnName("ART_ANCHO")
                    .HasComment("Ancho cm");

                entity.Property(e => e.ArtCanped)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_CANPED")
                    .HasComment("Cantidad de articulos pedidos");

                entity.Property(e => e.ArtCcocom)
                    .HasMaxLength(10)
                    .HasColumnName("ART_CCOCOM")
                    .HasComment("Centro de costo compras");

                entity.Property(e => e.ArtCcovta)
                    .HasMaxLength(10)
                    .HasColumnName("ART_CCOVTA")
                    .HasComment("Centro de costos venta");

                entity.Property(e => e.ArtCodbar)
                    .HasMaxLength(20)
                    .HasColumnName("ART_CODBAR")
                    .HasComment("Codigo de barras");

                entity.Property(e => e.ArtCodcab)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODCAB")
                    .HasDefaultValueSql("''")
                    .HasComment("Codigo del articulo cabecera...(si ART_COMPUE=2)");

                entity.Property(e => e.ArtCodlin)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("ART_CODLIN")
                    .HasComment("Codigo de linea");

                entity.Property(e => e.ArtCodmar)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODMAR")
                    .HasComment("Codigo de marca");

                entity.Property(e => e.ArtCodmon)
                    .HasColumnName("ART_CODMON")
                    .HasComment("Codigo de  moneda");

                entity.Property(e => e.ArtCodori)
                    .HasMaxLength(20)
                    .HasColumnName("ART_CODORI")
                    .HasComment("Codigo del fabricante");

                entity.Property(e => e.ArtCodpro)
                    .HasColumnName("ART_CODPRO")
                    .HasComment("Cod. de proveedor");

                entity.Property(e => e.ArtCodrub)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODRUB");

                entity.Property(e => e.ArtCodsru)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODSRU")
                    .HasComment("Codigo de subrubro");

                entity.Property(e => e.ArtCodtar)
                    .HasColumnName("ART_CODTAR")
                    .HasComment("Codigo tpo de articulo ");

                entity.Property(e => e.ArtCoefcv)
                    .HasPrecision(11, 2)
                    .HasColumnName("ART_COEFCV")
                    .HasDefaultValueSql("'1.00'")
                    .HasComment("Coeficiente unidad de compra unidad de venta");

                entity.Property(e => e.ArtCompue)
                    .HasColumnName("ART_COMPUE")
                    .HasComment("Articulo Compuesto - 0=SIMPLE/1=CABECERA DE GRUPO/2=INTEGRANTE DE GRUPO/3=KIT-COMBO");

                entity.Property(e => e.ArtComvta)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_COMVTA")
                    .HasComment("Comisión s/ventas");

                entity.Property(e => e.ArtCtacom)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CTACOM")
                    .HasComment("Cuenta contable p compras");

                entity.Property(e => e.ArtCtavta)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CTAVTA")
                    .HasComment("Cuenta contable p ventas");

                entity.Property(e => e.ArtDescri)
                    .HasMaxLength(40)
                    .HasColumnName("ART_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.ArtDescrl)
                    .HasColumnType("text")
                    .HasColumnName("ART_DESCRL")
                    .HasComment("Descripción larga");

                entity.Property(e => e.ArtDestac)
                    .HasColumnName("ART_DESTAC")
                    .HasComment("Articulo destacado");

                entity.Property(e => e.ArtDiscon)
                    .HasColumnName("ART_DISCON")
                    .HasComment("Producto discontinuado");

                entity.Property(e => e.ArtDispon)
                    .IsRequired()
                    .HasColumnName("ART_DISPON")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Art. disponible p/comercialización");

                entity.Property(e => e.ArtDtocom)
                    .HasPrecision(5, 2)
                    .HasColumnName("ART_DTOCOM")
                    .HasComment("Descuento s/precio de lista en compras");

                entity.Property(e => e.ArtDtovta)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_DTOVTA")
                    .HasComment("Descuento p /ventas");

                entity.Property(e => e.ArtEcomp1)
                    .HasColumnName("ART_ECOMP1")
                    .HasComment("Publica en Market Place 1 MLibre");

                entity.Property(e => e.ArtEcomp2)
                    .HasColumnName("ART_ECOMP2")
                    .HasComment("Publica en Market Place 2 Compra Simple");

                entity.Property(e => e.ArtEcomp3)
                    .HasColumnName("ART_ECOMP3")
                    .HasComment("Publica en Market Place 3 XX ");

                entity.Property(e => e.ArtEcopro)
                    .HasColumnName("ART_ECOPRO")
                    .HasComment("Publica en E Commerce propio");

                entity.Property(e => e.ArtEmbala)
                    .HasColumnName("ART_EMBALA")
                    .HasComment("Embalaje");

                entity.Property(e => e.ArtEquiva)
                    .HasColumnName("ART_EQUIVA")
                    .HasComment("articulo con equivalencias: 0=no, 1=si");

                entity.Property(e => e.ArtImagen)
                    .HasMaxLength(60)
                    .HasColumnName("ART_IMAGEN")
                    .HasComment("Dirección de imgen asociada");

                entity.Property(e => e.ArtImaux1)
                    .HasMaxLength(60)
                    .HasColumnName("ART_IMAUX1")
                    .HasComment("Imagen auxiliar 1");

                entity.Property(e => e.ArtImaux2)
                    .HasMaxLength(60)
                    .HasColumnName("ART_IMAUX2")
                    .HasComment("Imagen auxiliar 2");

                entity.Property(e => e.ArtImaux3)
                    .HasMaxLength(60)
                    .HasColumnName("ART_IMAUX3")
                    .HasComment("Imagen auxiliar 3");

                entity.Property(e => e.ArtImaux4)
                    .HasMaxLength(60)
                    .HasColumnName("ART_IMAUX4")
                    .HasComment("Imagen auxiliar 4");

                entity.Property(e => e.ArtImpues)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_IMPUES")
                    .HasComment("Impuesto interno sobre el articulo");

                entity.Property(e => e.ArtObserv)
                    .HasMaxLength(50)
                    .HasColumnName("ART_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.ArtPeso)
                    .HasPrecision(7, 2)
                    .HasColumnName("ART_PESO")
                    .HasComment("Peso kg");

                entity.Property(e => e.ArtPrecos)
                    .HasPrecision(13, 3)
                    .HasColumnName("ART_PRECOS")
                    .HasComment("Precio de costo s/iva");

                entity.Property(e => e.ArtProfun)
                    .HasPrecision(7, 2)
                    .HasColumnName("ART_PROFUN")
                    .HasComment("Profundidad cm");

                entity.Property(e => e.ArtPromoc)
                    .HasColumnName("ART_PROMOC")
                    .HasComment("Articulo en promocion: 0=no, 1=si");

                entity.Property(e => e.ArtStoact)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_STOACT")
                    .HasComment("Cantidad en stock actual");

                entity.Property(e => e.ArtStocom)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_STOCOM")
                    .HasComment("Stock comprometido");

                entity.Property(e => e.ArtStomax)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_STOMAX")
                    .HasComment("Stock maximo");

                entity.Property(e => e.ArtStomin)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_STOMIN")
                    .HasComment("Stock minimo");

                entity.Property(e => e.ArtStover)
                    .HasColumnName("ART_STOVER")
                    .HasComment("Stock verificado");

                entity.Property(e => e.ArtTags)
                    .HasColumnType("text")
                    .HasColumnName("ART_TAGS")
                    .HasComment("Etiquetas p/busqueda en EComerce");

                entity.Property(e => e.ArtTipimp)
                    .HasColumnName("ART_TIPIMP")
                    .HasComment("Tipo de impuesto: 0=importe fijo, 1=porcentual");

                entity.Property(e => e.ArtUltact)
                    .HasColumnType("date")
                    .HasColumnName("ART_ULTACT")
                    .HasComment("Fecha ultima actualización");

                entity.Property(e => e.ArtUltcom)
                    .HasColumnType("date")
                    .HasColumnName("ART_ULTCOM")
                    .HasComment("Fecha ultima compra");

                entity.Property(e => e.ArtUmcomp)
                    .HasMaxLength(6)
                    .HasColumnName("ART_UMCOMP")
                    .HasComment("Unidad de medida p/compra");

                entity.Property(e => e.ArtUmvent)
                    .HasMaxLength(6)
                    .HasColumnName("ART_UMVENT")
                    .HasComment("Unidad de venta");

                entity.Property(e => e.ArtUspart)
                    .HasColumnName("ART_USPART")
                    .HasComment("Usa partida");

                entity.Property(e => e.ArtUsseri)
                    .HasColumnName("ART_USSERI")
                    .HasComment("Usa Nro. de serie");

                entity.Property(e => e.ArtValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("ART_VALIVA")
                    .HasComment("Porcentaje de IVA");

                entity.Property(e => e.ArtVolume)
                    .HasPrecision(7, 2)
                    .HasColumnName("ART_VOLUME")
                    .HasComment("Volumen cc");

                entity.HasOne(d => d.ArtCodlinNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.ArtCodlin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articulos_linea1");

                entity.HasOne(d => d.ArtCodmarNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.ArtCodmar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articulos_marcas1");

                entity.HasOne(d => d.ArtCodmonNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.ArtCodmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articulos_monedas1");

                entity.HasOne(d => d.ArtCodproNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.ArtCodpro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articulos_proveedores1");

                entity.HasOne(d => d.ArtCodrubNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.ArtCodrub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articulos_rubros1");

                entity.HasOne(d => d.ArtCodsruNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.ArtCodsru)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articulos_subrubros1");

                entity.HasOne(d => d.ArtCodtarNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.ArtCodtar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_articulos_tipoart1");
            });

            modelBuilder.Entity<ArticulosH>(entity =>
            {
                entity.HasKey(e => e.IdMovArt)
                    .HasName("PRIMARY");

                entity.ToTable("articulos_h");

                entity.HasComment("Historico de artículos (precios)")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.IdMovArt)
                    .HasColumnName("Id_MovArt")
                    .HasComment("Id Movimiento");

                entity.Property(e => e.AreCodart)
                    .HasMaxLength(15)
                    .HasColumnName("ARE_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.AreCodmon)
                    .HasColumnName("ARE_CODMON")
                    .HasComment("Codigo Moneda");

                entity.Property(e => e.AreFecope)
                    .HasColumnType("timestamp")
                    .HasColumnName("ARE_FECOPE")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Fecha de operacion");

                entity.Property(e => e.AreOperac)
                    .HasMaxLength(3)
                    .HasColumnName("ARE_OPERAC");

                entity.Property(e => e.ArePrecos)
                    .HasPrecision(13, 3)
                    .HasColumnName("ARE_PRECOS")
                    .HasComment("Precio Costo");

                entity.Property(e => e.AreUsuari)
                    .HasMaxLength(30)
                    .HasColumnName("ARE_USUARI")
                    .HasComment("Usuario");
            });

            modelBuilder.Entity<BancContac>(entity =>
            {
                entity.HasKey(e => new { e.BycCodbce, e.BycCodcon })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("banc_contac");

                entity.HasComment("Bancos de la empresa y contactos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.BycCodcon, "fk_table1_contactos1");

                entity.Property(e => e.BycCodbce)
                    .HasColumnName("BYC_CODBCE")
                    .HasComment("Codigo de banco");

                entity.Property(e => e.BycCodcon)
                    .HasPrecision(6)
                    .HasColumnName("BYC_CODCON")
                    .HasComment("Codigo de contacto");

                entity.HasOne(d => d.BycCodbceNavigation)
                    .WithMany(p => p.BancContacs)
                    .HasForeignKey(d => d.BycCodbce)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_banc_contac_bancos");

                entity.HasOne(d => d.BycCodconNavigation)
                    .WithMany(p => p.BancContacs)
                    .HasForeignKey(d => d.BycCodcon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_banc_contac_contactos");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.BanCodban)
                    .HasName("PRIMARY");

                entity.ToTable("bancos");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.BanCodban)
                    .ValueGeneratedNever()
                    .HasColumnName("BAN_CODBAN")
                    .HasComment("Codigo de banco");

                entity.Property(e => e.BanAbrevi)
                    .HasMaxLength(6)
                    .HasColumnName("BAN_ABREVI")
                    .HasComment("Abreviatura");

                entity.Property(e => e.BanDesban)
                    .HasMaxLength(30)
                    .HasColumnName("BAN_DESBAN")
                    .HasComment("Descripcion banco");
            });

            modelBuilder.Entity<BcosCbancEmp>(entity =>
            {
                entity.HasKey(e => e.BceCodbce)
                    .HasName("PRIMARY");

                entity.ToTable("bcos_cbanc_emp");

                entity.HasComment("Cuentas bancarias de la empresa")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.BceCodciv, "fk_proveedores_condiva1");

                entity.HasIndex(e => e.BceCodloc, "fk_proveedores_localidad1");

                entity.HasIndex(e => e.BceCodprv, "fk_proveedores_provincia1");

                entity.Property(e => e.BceCodbce)
                    .HasPrecision(6)
                    .HasColumnName("BCE_CODBCE");

                entity.Property(e => e.BceCbucta)
                    .HasMaxLength(22)
                    .HasColumnName("BCE_CBUCTA")
                    .HasComment("CBU");

                entity.Property(e => e.BceCodciv)
                    .HasColumnName("BCE_CODCIV")
                    .HasComment("Codigo Condicion frente al iva");

                entity.Property(e => e.BceCodcuc)
                    .HasColumnName("BCE_CODCUC")
                    .HasComment("Codigo de cuenta contable");

                entity.Property(e => e.BceCodloc)
                    .HasPrecision(5)
                    .HasColumnName("BCE_CODLOC");

                entity.Property(e => e.BceCodmon)
                    .HasColumnName("BCE_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.BceCodprv)
                    .HasPrecision(3)
                    .HasColumnName("BCE_CODPRV");

                entity.Property(e => e.BceCuit)
                    .HasMaxLength(13)
                    .HasColumnName("BCE_CUIT")
                    .HasComment("Cuit");

                entity.Property(e => e.BceDesban)
                    .HasMaxLength(40)
                    .HasColumnName("BCE_DESBAN")
                    .HasComment("Nombre-denominacion");

                entity.Property(e => e.BceDescta)
                    .HasMaxLength(30)
                    .HasColumnName("BCE_DESCTA")
                    .HasComment("Descripcion de la cuenta");

                entity.Property(e => e.BceDescub)
                    .HasPrecision(13, 2)
                    .HasColumnName("BCE_DESCUB")
                    .HasComment("Descubierto");

                entity.Property(e => e.BceDirecc)
                    .HasMaxLength(40)
                    .HasColumnName("BCE_DIRECC")
                    .HasComment("dirección");

                entity.Property(e => e.BceFax)
                    .HasMaxLength(20)
                    .HasColumnName("BCE_FAX")
                    .HasComment("Fax ");

                entity.Property(e => e.BceFecalt)
                    .HasColumnType("date")
                    .HasColumnName("BCE_FECALT")
                    .HasComment("fecha de alta");

                entity.Property(e => e.BceIngbru)
                    .HasMaxLength(15)
                    .HasColumnName("BCE_INGBRU")
                    .HasComment("nro. ingresos brutos");

                entity.Property(e => e.BceMail)
                    .HasMaxLength(45)
                    .HasColumnName("BCE_MAIL")
                    .HasComment("mail ");

                entity.Property(e => e.BceNrocta)
                    .HasMaxLength(15)
                    .HasColumnName("BCE_NROCTA")
                    .HasComment("Nro de cuenta");

                entity.Property(e => e.BceObserv)
                    .HasColumnName("BCE_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.BceSaldo)
                    .HasColumnName("BCE_SALDO")
                    .HasComment("saldo ");

                entity.Property(e => e.BceSuccta)
                    .HasMaxLength(6)
                    .HasColumnName("BCE_SUCCTA")
                    .HasComment("Codigo de sucursal");

                entity.Property(e => e.BceTele1)
                    .HasMaxLength(20)
                    .HasColumnName("BCE_TELE1")
                    .HasComment("telefono 1 ");

                entity.Property(e => e.BceTele2)
                    .HasMaxLength(20)
                    .HasColumnName("BCE_TELE2")
                    .HasComment("Telefono 2 ");

                entity.Property(e => e.BceTipcue)
                    .HasMaxLength(20)
                    .HasColumnName("BCE_TIPCUE")
                    .HasComment("Tipo de cuenta: cuenta corriente, caja de ahorro");

                entity.Property(e => e.BceWeb)
                    .HasMaxLength(45)
                    .HasColumnName("BCE_WEB")
                    .HasComment("web ");

                entity.HasOne(d => d.BceCodcivNavigation)
                    .WithMany(p => p.BcosCbancEmps)
                    .HasForeignKey(d => d.BceCodciv)
                    .HasConstraintName("fk_proveedores_condiva1000");

                entity.HasOne(d => d.BceCodlocNavigation)
                    .WithMany(p => p.BcosCbancEmps)
                    .HasForeignKey(d => d.BceCodloc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_localidad1000");

                entity.HasOne(d => d.BceCodprvNavigation)
                    .WithMany(p => p.BcosCbancEmps)
                    .HasForeignKey(d => d.BceCodprv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_provincia1000");
            });

            modelBuilder.Entity<Caja>(entity =>
            {
                entity.HasKey(e => e.CajCodcaj)
                    .HasName("PRIMARY");

                entity.ToTable("cajas");

                entity.HasComment("Cajas")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CajCodcaj)
                    .ValueGeneratedNever()
                    .HasColumnName("CAJ_CODCAJ")
                    .HasComment("Codigo de caja");

                entity.Property(e => e.CajDescri)
                    .HasMaxLength(30)
                    .HasColumnName("CAJ_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.CajObserv)
                    .HasMaxLength(45)
                    .HasColumnName("CAJ_OBSERV")
                    .HasComment("observaciones");
            });

            modelBuilder.Entity<CajasAyc>(entity =>
            {
                entity.HasKey(e => new { e.AycNumses, e.AycFecmov })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("cajas_ayc");

                entity.HasComment("Aperturas y cierres de caja")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.AycNumses)
                    .HasColumnName("AYC_NUMSES")
                    .HasComment("Nro. de sesion");

                entity.Property(e => e.AycFecmov)
                    .HasColumnType("date")
                    .HasColumnName("AYC_FECMOV")
                    .HasComment("Fecha de movimiento");

                entity.Property(e => e.AycFecaper)
                    .HasColumnType("date")
                    .HasColumnName("AYC_FECAPER")
                    .HasComment("Fecha de apertura");

                entity.Property(e => e.AycFeccie)
                    .HasColumnType("date")
                    .HasColumnName("AYC_FECCIE")
                    .HasComment("Fecha de cierre");

                entity.Property(e => e.AycRecche)
                    .HasPrecision(13, 2)
                    .HasColumnName("AYC_RECCHE")
                    .HasComment("recaudacion de cheques");

                entity.Property(e => e.AycRecdep)
                    .HasPrecision(13, 2)
                    .HasColumnName("AYC_RECDEP")
                    .HasComment("recaudacion de depositos transferencias");

                entity.Property(e => e.AycRecefe)
                    .HasPrecision(13, 2)
                    .HasColumnName("AYC_RECEFE")
                    .HasComment("recaudacion de efectivo");

                entity.Property(e => e.AycRectar)
                    .HasPrecision(13, 2)
                    .HasColumnName("AYC_RECTAR")
                    .HasComment("recaudacion de tarjetas");

                entity.Property(e => e.AycRectot)
                    .HasPrecision(13, 2)
                    .HasColumnName("AYC_RECTOT")
                    .HasComment("recaudacion total");

                entity.Property(e => e.AycUsuaper)
                    .HasMaxLength(10)
                    .HasColumnName("AYC_USUAPER")
                    .HasComment("Usuario que abre");

                entity.Property(e => e.AycUsucie)
                    .HasMaxLength(10)
                    .HasColumnName("AYC_USUCIE")
                    .HasComment("Usuario de cierre");
            });

            modelBuilder.Entity<Carrito>(entity =>
            {
                entity.HasKey(e => e.CarId)
                    .HasName("PRIMARY");

                entity.ToTable("carrito");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CarId)
                    .HasColumnName("CAR_ID")
                    .HasComment("Id carrito");

                entity.Property(e => e.CarFecha)
                    .HasColumnType("date")
                    .HasColumnName("CAR_FECHA")
                    .HasComment("Fecha");
            });

            modelBuilder.Entity<CarritoDet>(entity =>
            {
                entity.HasKey(e => e.CadId)
                    .HasName("PRIMARY");

                entity.ToTable("carrito_det");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CadCodart, "fk_carrito_det_articulos_idx");

                entity.HasIndex(e => e.CadCarid, "fk_carrito_det_carrito1");

                entity.Property(e => e.CadId)
                    .HasColumnName("CAD_ID")
                    .HasComment("Id detalle");

                entity.Property(e => e.CadCantid)
                    .HasColumnName("CAD_CANTID")
                    .HasComment("Cantidad");

                entity.Property(e => e.CadCarid)
                    .HasColumnName("CAD_CARID")
                    .HasComment("Id Cabecera");

                entity.Property(e => e.CadCodart)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("CAD_CODART")
                    .HasDefaultValueSql("''")
                    .HasComment("Codigo artículo");

                entity.HasOne(d => d.CadCar)
                    .WithMany(p => p.CarritoDets)
                    .HasForeignKey(d => d.CadCarid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_carrito_det_carrito1");

                entity.HasOne(d => d.CadCodartNavigation)
                    .WithMany(p => p.CarritoDets)
                    .HasForeignKey(d => d.CadCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_carrito_det_articulos");
            });

            modelBuilder.Entity<CasillasCorreo>(entity =>
            {
                entity.HasKey(e => e.CasCodcas)
                    .HasName("PRIMARY");

                entity.ToTable("casillas_correo");

                entity.HasComment("Casillas de correo salientes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CasCodcas)
                    .ValueGeneratedNever()
                    .HasColumnName("CAS_CODCAS");

                entity.Property(e => e.CasAutent)
                    .HasColumnName("CAS_AUTENT")
                    .HasComment("Autenticacion");

                entity.Property(e => e.CasCodifi)
                    .HasMaxLength(20)
                    .HasColumnName("CAS_CODIFI")
                    .HasComment("Codificacion");

                entity.Property(e => e.CasContra)
                    .HasMaxLength(10)
                    .HasColumnName("CAS_CONTRA")
                    .HasComment("Contrasena");

                entity.Property(e => e.CasNombre)
                    .HasMaxLength(30)
                    .HasColumnName("CAS_NOMBRE");

                entity.Property(e => e.CasPriori)
                    .HasMaxLength(20)
                    .HasColumnName("CAS_PRIORI")
                    .HasComment("Prioridad");

                entity.Property(e => e.CasSmtpcs)
                    .HasMaxLength(50)
                    .HasColumnName("CAS_SMTPCS")
                    .HasComment("Correo saliente SMTP HOST");

                entity.Property(e => e.CasSmtppu)
                    .HasColumnName("CAS_SMTPPU")
                    .HasComment("Puerto - Correo saliente");

                entity.Property(e => e.CasUsuari)
                    .HasMaxLength(50)
                    .HasColumnName("CAS_USUARI")
                    .HasComment("usuario");
            });

            modelBuilder.Entity<Catclient>(entity =>
            {
                entity.HasKey(e => e.CacCodcac)
                    .HasName("PRIMARY");

                entity.ToTable("catclient");

                entity.HasComment("Categorias de clientes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CacCodcac)
                    .HasColumnName("CAC_CODCAC")
                    .HasComment("Codigo");

                entity.Property(e => e.CacAbrevi)
                    .HasMaxLength(3)
                    .HasColumnName("CAC_ABREVI")
                    .HasComment("Abreviatura");

                entity.Property(e => e.CacDescri)
                    .HasMaxLength(20)
                    .HasColumnName("CAC_DESCRI")
                    .HasComment("Descripcion");
            });

            modelBuilder.Entity<Ccosto>(entity =>
            {
                entity.HasKey(e => e.CcoCodcco)
                    .HasName("PRIMARY");

                entity.ToTable("ccostos");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CcoCodcco)
                    .ValueGeneratedNever()
                    .HasColumnName("CCO_CODCCO")
                    .HasComment("Codigo Centro de costo");

                entity.Property(e => e.CcoAbrevi)
                    .HasMaxLength(3)
                    .HasColumnName("CCO_ABREVI")
                    .HasComment("Abreviatura");

                entity.Property(e => e.CcoDescri)
                    .HasMaxLength(40)
                    .HasColumnName("CCO_DESCRI")
                    .HasComment("Descripción");
            });

            modelBuilder.Entity<CeCabecera>(entity =>
            {
                entity.HasKey(e => new { e.CelCodcom, e.CelNrocom })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ce_cabecera");

                entity.HasComment("Comprobantes electronicos - Cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CelCodcom)
                    .HasColumnName("CEL_CODCOM")
                    .HasComment("Codigo de comrprobante");

                entity.Property(e => e.CelNrocom)
                    .HasPrecision(12)
                    .HasColumnName("CEL_NROCOM")
                    .HasComment("Nro de comprobante");

                entity.Property(e => e.CelCodcli)
                    .HasPrecision(6)
                    .HasColumnName("CEL_CODCLI");

                entity.Property(e => e.CelConcep)
                    .HasColumnName("CEL_CONCEP")
                    .HasComment("Concepto 1 Producto 2 Serv. 3 Prod y Serv");

                entity.Property(e => e.CelErrmsg)
                    .HasMaxLength(255)
                    .HasColumnName("CEL_ERRMSG");

                entity.Property(e => e.CelFeccom)
                    .HasMaxLength(8)
                    .HasColumnName("CEL_FECCOM")
                    .HasComment("Fecha yyyymmdd - 5 días para Concepto 1 5 dias ant o post");

                entity.Property(e => e.CelFecven)
                    .HasMaxLength(8)
                    .HasColumnName("CEL_FECVEN")
                    .HasComment("Fecha vencimiento pago Servicio");

                entity.Property(e => e.CelFserde)
                    .HasMaxLength(8)
                    .HasColumnName("CEL_FSERDE")
                    .HasComment("Fecha Inicio Abono p/Servicio");

                entity.Property(e => e.CelFserha)
                    .HasMaxLength(8)
                    .HasColumnName("CEL_FSERHA")
                    .HasComment("Fecha fin abono p/ servicio");

                entity.Property(e => e.CelImpcon)
                    .HasPrecision(13, 2)
                    .HasColumnName("CEL_IMPCON")
                    .HasComment("Importe Neto No gravado");

                entity.Property(e => e.CelImpexe)
                    .HasPrecision(13, 2)
                    .HasColumnName("CEL_IMPEXE")
                    .HasComment("Importe exento");

                entity.Property(e => e.CelImpiva)
                    .HasPrecision(13, 2)
                    .HasColumnName("CEL_IMPIVA")
                    .HasComment("Importe IVA");

                entity.Property(e => e.CelImpnet)
                    .HasPrecision(13, 2)
                    .HasColumnName("CEL_IMPNET")
                    .HasComment("Importe Neto gravado");

                entity.Property(e => e.CelImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("CEL_IMPTOT")
                    .HasComment("Importe Total");

                entity.Property(e => e.CelImptri)
                    .HasPrecision(13, 2)
                    .HasColumnName("CEL_IMPTRI")
                    .HasComment("Suma Importes Array de Tributos");

                entity.Property(e => e.CelMoncot)
                    .HasPrecision(10, 6)
                    .HasColumnName("CEL_MONCOT")
                    .HasComment("Cotización de la moneda 1 para pesos");

                entity.Property(e => e.CelMoneid)
                    .HasMaxLength(3)
                    .HasColumnName("CEL_MONEID")
                    .HasComment("codigo Moneda AFIP");

                entity.Property(e => e.CelNrocae)
                    .HasMaxLength(45)
                    .HasColumnName("CEL_NROCAE");

                entity.Property(e => e.CelNrodes)
                    .HasPrecision(8)
                    .HasColumnName("CEL_NRODES")
                    .HasComment("Nro de Comprobante Desde");

                entity.Property(e => e.CelNrodoc)
                    .HasPrecision(11)
                    .HasColumnName("CEL_NRODOC")
                    .HasComment("Numero de Documento");

                entity.Property(e => e.CelNrohas)
                    .HasPrecision(8)
                    .HasColumnName("CEL_NROHAS")
                    .HasComment("Nro Comprobante Hasta");

                entity.Property(e => e.CelObserv)
                    .HasMaxLength(255)
                    .HasColumnName("CEL_OBSERV");

                entity.Property(e => e.CelPtovta)
                    .HasPrecision(4)
                    .HasColumnName("CEL_PTOVTA")
                    .HasComment("Punto de Venta");

                entity.Property(e => e.CelReproc)
                    .HasMaxLength(1)
                    .HasColumnName("CEL_REPROC");

                entity.Property(e => e.CelResult)
                    .HasMaxLength(1)
                    .HasColumnName("CEL_RESULT");

                entity.Property(e => e.CelTipcom)
                    .HasMaxLength(2)
                    .HasColumnName("CEL_TIPCOM")
                    .HasComment("Tipo de Comprobante AFIP");

                entity.Property(e => e.CelTipdoc)
                    .HasColumnName("CEL_TIPDOC")
                    .HasComment("Tipo Doc AFIP");

                entity.Property(e => e.CelVencae)
                    .HasMaxLength(8)
                    .HasColumnName("CEL_VENCAE");
            });

            modelBuilder.Entity<CeCbesAsoc>(entity =>
            {
                entity.HasKey(e => new { e.CasCodcom, e.CasNrocom, e.CasLinea })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("ce_cbes_asoc");

                entity.HasComment("Comprobantes electronicos - Comprobantes asociados")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.CasCodcom, e.CasNrocom }, "fk_ce_cbes_asoc_ce_cabecera1");

                entity.Property(e => e.CasCodcom).HasColumnName("CAS_CODCOM");

                entity.Property(e => e.CasNrocom)
                    .HasPrecision(12)
                    .HasColumnName("CAS_NROCOM");

                entity.Property(e => e.CasLinea)
                    .HasColumnName("CAS_LINEA")
                    .HasComment("Linea");

                entity.Property(e => e.CasNrocas)
                    .HasPrecision(8)
                    .HasColumnName("CAS_NROCAS")
                    .HasComment("Nro comprobante asociado");

                entity.Property(e => e.CasPtovta)
                    .HasPrecision(4)
                    .HasColumnName("CAS_PTOVTA")
                    .HasComment("Pto de Vta. comp. asociado");

                entity.Property(e => e.CasTipcom)
                    .HasColumnName("CAS_TIPCOM")
                    .HasComment("Id Tipo de comprobante asociado");

                entity.HasOne(d => d.Cas)
                    .WithMany(p => p.CeCbesAsocs)
                    .HasForeignKey(d => new { d.CasCodcom, d.CasNrocom })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ce_cbes_asoc_ce_cabecera1");
            });

            modelBuilder.Entity<CeIva>(entity =>
            {
                entity.HasKey(e => new { e.IvaCodcom, e.IvaNrocom, e.IvaLinea })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("ce_iva");

                entity.HasComment("Comprobantes electronicos - IVA")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.IvaCodcom, e.IvaNrocom }, "fk_ce_iva_ce_cabecera1");

                entity.Property(e => e.IvaCodcom).HasColumnName("IVA_CODCOM");

                entity.Property(e => e.IvaNrocom)
                    .HasPrecision(12)
                    .HasColumnName("IVA_NROCOM");

                entity.Property(e => e.IvaLinea)
                    .HasColumnName("IVA_LINEA")
                    .HasComment("Linea");

                entity.Property(e => e.IvaBasimp)
                    .HasPrecision(13, 2)
                    .HasColumnName("IVA_BASIMP")
                    .HasComment("Base Imponible ");

                entity.Property(e => e.IvaCodiva)
                    .HasColumnName("IVA_CODIVA")
                    .HasComment("Id Tipo de IVA");

                entity.Property(e => e.IvaImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("IVA_IMPORT")
                    .HasComment("Importe ");

                entity.HasOne(d => d.Iva)
                    .WithMany(p => p.CeIvas)
                    .HasForeignKey(d => new { d.IvaCodcom, d.IvaNrocom })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ce_iva_ce_cabecera1");
            });

            modelBuilder.Entity<CeTiqueAcceso>(entity =>
            {
                entity.HasKey(e => e.CetPrefij)
                    .HasName("PRIMARY");

                entity.ToTable("ce_tique_acceso");

                entity.HasComment("Factura Electronica - Tique de Acceso")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CetPrefij)
                    .HasPrecision(4)
                    .HasColumnName("CET_PREFIJ");

                entity.Property(e => e.CetCerdig)
                    .HasMaxLength(100)
                    .HasColumnName("CET_CERDIG")
                    .HasDefaultValueSql("''")
                    .HasComment("Certificado Digital");

                entity.Property(e => e.CetGrabac)
                    .HasColumnType("datetime")
                    .HasColumnName("CET_GRABAC")
                    .HasComment("Fecha hora grabacion");

                entity.Property(e => e.CetSign)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("CET_SIGN")
                    .HasDefaultValueSql("' '")
                    .HasComment("'Sign recibido'");

                entity.Property(e => e.CetToken)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("CET_TOKEN")
                    .HasDefaultValueSql("' '")
                    .HasComment("'Token recibido'");

                entity.Property(e => e.CetValido)
                    .HasColumnType("datetime")
                    .HasColumnName("CET_VALIDO")
                    .HasComment("Fecha hora validez");
            });

            modelBuilder.Entity<CeTributo>(entity =>
            {
                entity.HasKey(e => new { e.TriCodcom, e.TriNrocom, e.TriLinea })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("ce_tributos");

                entity.HasComment("Comprobantes electronicos -Tributos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.TriCodcom, e.TriNrocom }, "fk_ce_tributos_ce_cabecera1");

                entity.Property(e => e.TriCodcom).HasColumnName("TRI_CODCOM");

                entity.Property(e => e.TriNrocom)
                    .HasPrecision(12)
                    .HasColumnName("TRI_NROCOM");

                entity.Property(e => e.TriLinea)
                    .HasColumnName("TRI_LINEA")
                    .HasComment("Linea");

                entity.Property(e => e.TriAlicuo)
                    .HasPrecision(5, 2)
                    .HasColumnName("TRI_ALICUO")
                    .HasComment("Alicuta del tributo");

                entity.Property(e => e.TriBasimp)
                    .HasPrecision(13, 2)
                    .HasColumnName("TRI_BASIMP")
                    .HasComment("Base Imponible p/ tributo");

                entity.Property(e => e.TriCodtri)
                    .HasColumnName("TRI_CODTRI")
                    .HasComment("Id Tributo");

                entity.Property(e => e.TriDescri)
                    .HasMaxLength(80)
                    .HasColumnName("TRI_DESCRI")
                    .HasComment("Pto de Vta. comp. asociado");

                entity.Property(e => e.TriImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("TRI_IMPORT")
                    .HasComment("Importe del tributo");

                entity.HasOne(d => d.Tri)
                    .WithMany(p => p.CeTributos)
                    .HasForeignKey(d => new { d.TriCodcom, d.TriNrocom })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ce_tributos_ce_cabecera1");
            });

            modelBuilder.Entity<CheqEmit>(entity =>
            {
                entity.HasKey(e => e.CheIdcheq)
                    .HasName("PRIMARY");

                entity.ToTable("cheq_emit");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CheIdcheq).HasColumnName("CHE_IDCHEQ");

                entity.Property(e => e.CheCodban)
                    .HasColumnName("CHE_CODBAN")
                    .HasComment("Codigo de banco");

                entity.Property(e => e.CheCodloc)
                    .HasColumnName("CHE_CODLOC")
                    .HasComment("Codigo de localidad");

                entity.Property(e => e.CheCodpro)
                    .HasColumnName("CHE_CODPRO")
                    .HasComment("Cod. cliente que entrega");

                entity.Property(e => e.CheDespro)
                    .HasMaxLength(40)
                    .HasColumnName("CHE_DESPRO")
                    .HasComment("Descripcion cliente");

                entity.Property(e => e.CheEstado)
                    .HasMaxLength(12)
                    .HasColumnName("CHE_ESTADO")
                    .HasComment("Estado");

                entity.Property(e => e.CheFeccob)
                    .HasColumnType("date")
                    .HasColumnName("CHE_FECCOB")
                    .HasComment("Fecha de cobro");

                entity.Property(e => e.CheFecemi)
                    .HasColumnType("date")
                    .HasColumnName("CHE_FECEMI")
                    .HasComment("Fecha de emision");

                entity.Property(e => e.CheFecent)
                    .HasColumnType("date")
                    .HasColumnName("CHE_FECENT")
                    .HasComment("Fecha de entrega");

                entity.Property(e => e.CheImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("CHE_IMPORT")
                    .HasComment("Importe del cheque	");

                entity.Property(e => e.CheNumche)
                    .HasColumnName("CHE_NUMCHE")
                    .HasComment("Numero de cheque");

                entity.Property(e => e.CheObserv)
                    .HasMaxLength(40)
                    .HasColumnName("CHE_OBSERV");
            });

            modelBuilder.Entity<Cheqrec>(entity =>
            {
                entity.HasKey(e => e.ChrIdcheq)
                    .HasName("PRIMARY");

                entity.ToTable("cheqrec");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.ChrNumche, e.ChrCodban, e.ChrCodloc, e.ChrFecemi }, "Index_2")
                    .IsUnique();

                entity.Property(e => e.ChrIdcheq).HasColumnName("CHR_IDCHEQ");

                entity.Property(e => e.ChrCodban)
                    .HasColumnName("CHR_CODBAN")
                    .HasComment("Codigo de banco");

                entity.Property(e => e.ChrCodcli)
                    .HasColumnName("CHR_CODCLI")
                    .HasComment("Cod. cliente que entrega");

                entity.Property(e => e.ChrCodloc)
                    .HasColumnName("CHR_CODLOC")
                    .HasComment("Codigo de localidad Sucursal");

                entity.Property(e => e.ChrCodpro)
                    .HasColumnName("CHR_CODPRO")
                    .HasComment("Codigo de proveedor al que se entrega");

                entity.Property(e => e.ChrDescli)
                    .HasMaxLength(40)
                    .HasColumnName("CHR_DESCLI")
                    .HasComment("Descripcion cliente");

                entity.Property(e => e.ChrDespro)
                    .HasMaxLength(40)
                    .HasColumnName("CHR_DESPRO")
                    .HasComment("descripcion proveedor");

                entity.Property(e => e.ChrEstado)
                    .HasMaxLength(12)
                    .HasColumnName("CHR_ESTADO")
                    .HasComment("Estado");

                entity.Property(e => e.ChrFeccob)
                    .HasColumnType("date")
                    .HasColumnName("CHR_FECCOB")
                    .HasComment("Fecha de cobro");

                entity.Property(e => e.ChrFecemi)
                    .HasColumnType("date")
                    .HasColumnName("CHR_FECEMI")
                    .HasComment("Fecha de emision");

                entity.Property(e => e.ChrFecent)
                    .HasColumnType("date")
                    .HasColumnName("CHR_FECENT")
                    .HasComment("Fecha de entrega");

                entity.Property(e => e.ChrFecrec)
                    .HasColumnType("datetime")
                    .HasColumnName("CHR_FECREC")
                    .HasComment("Fecha de recepcion");

                entity.Property(e => e.ChrImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("CHR_IMPORT")
                    .HasComment("Importe del cheque	");

                entity.Property(e => e.ChrLibrad)
                    .HasMaxLength(40)
                    .HasColumnName("CHR_LIBRAD")
                    .HasComment("Librador");

                entity.Property(e => e.ChrNumche)
                    .HasColumnName("CHR_NUMCHE")
                    .HasComment("Numero de cheque");

                entity.Property(e => e.ChrObserv)
                    .HasMaxLength(40)
                    .HasColumnName("CHR_OBSERV");

                entity.Property(e => e.ChrRespon)
                    .HasMaxLength(40)
                    .HasColumnName("CHR_RESPON")
                    .HasComment("Responsable");
            });

            modelBuilder.Entity<Chequera>(entity =>
            {
                entity.HasKey(e => e.ChqCodchq)
                    .HasName("PRIMARY");

                entity.ToTable("chequeras");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ChqCodbce, "fk_chequeras_banco_idx");

                entity.Property(e => e.ChqCodchq)
                    .ValueGeneratedNever()
                    .HasColumnName("CHQ_CODCHQ")
                    .HasComment("Codigo de chequera");

                entity.Property(e => e.ChqActiva)
                    .HasColumnName("CHQ_ACTIVA")
                    .HasComment("Si esta activa");

                entity.Property(e => e.ChqCodbce).HasColumnName("CHQ_CODBCE");

                entity.Property(e => e.ChqDesnum)
                    .HasPrecision(11)
                    .HasColumnName("CHQ_DESNUM")
                    .HasComment("Primer numero");

                entity.Property(e => e.ChqHasnum)
                    .HasPrecision(11)
                    .HasColumnName("CHQ_HASNUM")
                    .HasComment("ultimo numero");

                entity.Property(e => e.ChqTipche)
                    .HasMaxLength(10)
                    .HasColumnName("CHQ_TIPCHE")
                    .HasComment("Tipo de cheque: diferido, al dia");

                entity.Property(e => e.ChqUltnum)
                    .HasPrecision(11)
                    .HasColumnName("CHQ_ULTNUM")
                    .HasComment("ultimo cheque emitido");

                entity.HasOne(d => d.ChqCodbceNavigation)
                    .WithMany(p => p.Chequeras)
                    .HasForeignKey(d => d.ChqCodbce)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_chequeras_banco");
            });

            modelBuilder.Entity<ClienContac>(entity =>
            {
                entity.HasKey(e => new { e.CycCodcli, e.CycCodcon })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("clien_contac");

                entity.HasComment("Clientes y contactos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CycCodcli, "fk_clien_contac_clientes1");

                entity.HasIndex(e => e.CycCodcon, "fk_table1_contactos1");

                entity.Property(e => e.CycCodcli)
                    .HasPrecision(6)
                    .HasColumnName("CYC_CODCLI");

                entity.Property(e => e.CycCodcon)
                    .HasPrecision(6)
                    .HasColumnName("CYC_CODCON")
                    .HasComment("Codigo de contacto");

                entity.HasOne(d => d.CycCodcliNavigation)
                    .WithMany(p => p.ClienContacs)
                    .HasForeignKey(d => d.CycCodcli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_clien_contac_clientes1");

                entity.HasOne(d => d.CycCodconNavigation)
                    .WithMany(p => p.ClienContacs)
                    .HasForeignKey(d => d.CycCodcon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_table1_contactos1");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CliCodcli)
                    .HasName("PRIMARY");

                entity.ToTable("clientes");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.CliCodciv, e.CliCuit }, "Ak_CIvaCuit")
                    .IsUnique();

                entity.HasIndex(e => e.CliCodcac, "fk_clientes_catclient1");

                entity.HasIndex(e => e.CliCodcob, "fk_clientes_cobradores_idx");

                entity.HasIndex(e => e.CliCodcpa, "fk_clientes_condpago1");

                entity.HasIndex(e => e.CliCodlis, "fk_clientes_listapre_idx");

                entity.HasIndex(e => e.CliCodmon, "fk_clientes_moneda_idx");

                entity.HasIndex(e => e.CliCodtdo, "fk_clientes_tipoDoc_idx");

                entity.HasIndex(e => e.CliCodven, "fk_clientes_vendedores_idx");

                entity.HasIndex(e => e.CliCodciv, "fk_proveedores_condiva1");

                entity.HasIndex(e => e.CliCodloc, "fk_proveedores_localidad1");

                entity.HasIndex(e => e.CliCodprv, "fk_proveedores_provincia1");

                entity.Property(e => e.CliCodcli)
                    .HasPrecision(6)
                    .HasColumnName("CLI_CODCLI");

                entity.Property(e => e.CliBlofac)
                    .HasColumnName("CLI_BLOFAC")
                    .HasComment("bloquea facturacion por deuda");

                entity.Property(e => e.CliCodcac)
                    .HasColumnName("CLI_CODCAC")
                    .HasComment("Codigo categoria cliente");

                entity.Property(e => e.CliCodciv)
                    .HasColumnName("CLI_CODCIV")
                    .HasComment("Codigo Condicion frente al iva");

                entity.Property(e => e.CliCodcob)
                    .HasColumnName("CLI_CODCOB")
                    .HasComment("Codigo de cobrador");

                entity.Property(e => e.CliCodcpa)
                    .HasColumnName("CLI_CODCPA")
                    .HasComment("condicion de pago habitual");

                entity.Property(e => e.CliCodcuc)
                    .HasColumnName("CLI_CODCUC")
                    .HasComment("Codigo de cuenta contable");

                entity.Property(e => e.CliCodgru)
                    .HasColumnName("CLI_CODGRU")
                    .HasComment("Ver clasificacion, mayoristas, minoristas (distintos niveles..???");

                entity.Property(e => e.CliCodlis)
                    .HasColumnName("CLI_CODLIS")
                    .HasComment("Codigo de lista de precios");

                entity.Property(e => e.CliCodloc)
                    .HasPrecision(5)
                    .HasColumnName("CLI_CODLOC");

                entity.Property(e => e.CliCodmon)
                    .HasColumnName("CLI_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.CliCodpos)
                    .HasMaxLength(8)
                    .HasColumnName("CLI_CODPOS")
                    .HasComment("Código Postal");

                entity.Property(e => e.CliCodprv)
                    .HasPrecision(3)
                    .HasColumnName("CLI_CODPRV");

                entity.Property(e => e.CliCodtdo)
                    .HasColumnName("CLI_CODTDO")
                    .HasComment("Id. Tipo Documento");

                entity.Property(e => e.CliCodtra).HasColumnName("CLI_CODTRA");

                entity.Property(e => e.CliCodven)
                    .HasColumnName("CLI_CODVEN")
                    .HasComment("Codigo de vendedor");

                entity.Property(e => e.CliCtacte)
                    .HasColumnName("CLI_CTACTE")
                    .HasComment("Habilitado cta cte");

                entity.Property(e => e.CliCuit)
                    .HasMaxLength(13)
                    .HasColumnName("CLI_CUIT")
                    .HasComment("Cuit");

                entity.Property(e => e.CliDescri)
                    .HasMaxLength(40)
                    .HasColumnName("CLI_DESCRI")
                    .HasComment("Nombre-denominacion");

                entity.Property(e => e.CliDirecc)
                    .HasMaxLength(40)
                    .HasColumnName("CLI_DIRECC")
                    .HasComment("dirección");

                entity.Property(e => e.CliEstado)
                    .HasMaxLength(10)
                    .HasColumnName("CLI_ESTADO")
                    .HasComment("Ver ACTIVO, SUSPENDIDO, POTENCIAL, NO CTACTE");

                entity.Property(e => e.CliFax)
                    .HasMaxLength(20)
                    .HasColumnName("CLI_FAX")
                    .HasComment("Fax empresa");

                entity.Property(e => e.CliFecalt)
                    .HasColumnType("date")
                    .HasColumnName("CLI_FECALT")
                    .HasComment("fecha de alta");

                entity.Property(e => e.CliFecnac)
                    .HasColumnType("date")
                    .HasColumnName("CLI_FECNAC")
                    .HasComment("Fecha de nacimiento");

                entity.Property(e => e.CliFecufa)
                    .HasColumnType("date")
                    .HasColumnName("CLI_FECUFA")
                    .HasComment("Fecha ultima factura");

                entity.Property(e => e.CliFecure)
                    .HasColumnType("date")
                    .HasColumnName("CLI_FECURE")
                    .HasComment("Fecha ultimo recibo");

                entity.Property(e => e.CliFecvig)
                    .HasColumnType("date")
                    .HasColumnName("CLI_FECVIG")
                    .HasComment("Fecha de vigencia del cliente");

                entity.Property(e => e.CliIngbru)
                    .HasMaxLength(15)
                    .HasColumnName("CLI_INGBRU")
                    .HasComment("nro. ingresos brutos");

                entity.Property(e => e.CliLimcre)
                    .HasPrecision(13, 2)
                    .HasColumnName("CLI_LIMCRE")
                    .HasComment("Limite de credito");

                entity.Property(e => e.CliMail)
                    .HasMaxLength(45)
                    .HasColumnName("CLI_MAIL")
                    .HasComment("mail empresa");

                entity.Property(e => e.CliObserv)
                    .HasColumnName("CLI_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.CliRemito)
                    .HasColumnName("CLI_REMITO")
                    .HasComment("Habilitado para imprimir remitos..(Si CTACTE esta habilitada) 0=NO 1=SI");

                entity.Property(e => e.CliSaldo)
                    .HasPrecision(13, 2)
                    .HasColumnName("CLI_SALDO")
                    .HasComment("saldo ");

                entity.Property(e => e.CliTele1)
                    .HasMaxLength(20)
                    .HasColumnName("CLI_TELE1")
                    .HasComment("telefono 1 empresa");

                entity.Property(e => e.CliTele2)
                    .HasMaxLength(20)
                    .HasColumnName("CLI_TELE2")
                    .HasComment("Telefono 2 empresa");

                entity.Property(e => e.CliWeb)
                    .HasMaxLength(45)
                    .HasColumnName("CLI_WEB")
                    .HasComment("web empresa");

                entity.HasOne(d => d.CliCodcacNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodcac)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_clientes_catclient1");

                entity.HasOne(d => d.CliCodcivNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodciv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_condiva10");

                entity.HasOne(d => d.CliCodcobNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodcob)
                    .HasConstraintName("fk_clientes_cobradores");

                entity.HasOne(d => d.CliCodcpaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodcpa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_clientes_condpago1");

                entity.HasOne(d => d.CliCodlisNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodlis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_clientes_listapre");

                entity.HasOne(d => d.CliCodlocNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodloc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_localidad10");

                entity.HasOne(d => d.CliCodmonNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodmon)
                    .HasConstraintName("fk_clientes_moneda");

                entity.HasOne(d => d.CliCodprvNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodprv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_provincia10");

                entity.HasOne(d => d.CliCodtdoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodtdo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_clientes_tipoDoc");

                entity.HasOne(d => d.CliCodvenNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CliCodven)
                    .HasConstraintName("fk_clientes_vendedores");
            });

            modelBuilder.Entity<ClientesVie>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("clientes_vie");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Condiiva)
                    .HasMaxLength(11)
                    .HasColumnName("CONDIIVA");

                entity.Property(e => e.Copostal)
                    .HasColumnType("double(15,5)")
                    .HasColumnName("COPOSTAL");

                entity.Property(e => e.Domicili)
                    .HasMaxLength(30)
                    .HasColumnName("DOMICILI");

                entity.Property(e => e.Fechaalt)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAALT");

                entity.Property(e => e.Fechault)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHAULT");

                entity.Property(e => e.Incobra).HasColumnName("INCOBRA");

                entity.Property(e => e.Limitecr)
                    .HasColumnType("double(15,5)")
                    .HasColumnName("LIMITECR");

                entity.Property(e => e.Localida)
                    .HasMaxLength(15)
                    .HasColumnName("LOCALIDA");

                entity.Property(e => e.Ltrabajo)
                    .HasMaxLength(12)
                    .HasColumnName("LTRABAJO");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .HasColumnName("MAIL");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(75)
                    .HasColumnName("MENSAJE");

                entity.Property(e => e.Muesmsg).HasColumnName("MUESMSG");

                entity.Property(e => e.Nomclien)
                    .HasMaxLength(30)
                    .HasColumnName("NOMCLIEN");

                entity.Property(e => e.Numclien)
                    .HasColumnType("double(15,5)")
                    .HasColumnName("NUMCLIEN");

                entity.Property(e => e.Numecuit)
                    .HasMaxLength(13)
                    .HasColumnName("NUMECUIT");

                entity.Property(e => e.Numedocu)
                    .HasMaxLength(8)
                    .HasColumnName("NUMEDOCU");

                entity.Property(e => e.Observac)
                    .HasMaxLength(150)
                    .HasColumnName("OBSERVAC");

                entity.Property(e => e.Porcent)
                    .HasColumnType("double(15,5)")
                    .HasColumnName("PORCENT");

                entity.Property(e => e.Saldocli)
                    .HasColumnType("double(15,5)")
                    .HasColumnName("SALDOCLI");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(11)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Tipodocu)
                    .HasMaxLength(3)
                    .HasColumnName("TIPODOCU");
            });

            modelBuilder.Entity<Cobradore>(entity =>
            {
                entity.HasKey(e => e.CobCodcob)
                    .HasName("PRIMARY");

                entity.ToTable("cobradores");

                entity.HasComment("Cobradores")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CobCodcob)
                    .HasColumnName("COB_CODCOB")
                    .HasComment("Codigo de comprador");

                entity.Property(e => e.CobComisi)
                    .HasPrecision(5, 2)
                    .HasColumnName("COB_COMISI")
                    .HasComment("Porcent. comision");

                entity.Property(e => e.CobCuil)
                    .HasMaxLength(13)
                    .HasColumnName("COB_CUIL")
                    .HasComment("CUIL");

                entity.Property(e => e.CobDescri)
                    .HasMaxLength(40)
                    .HasColumnName("COB_DESCRI")
                    .HasComment("Nombre");

                entity.Property(e => e.CobFingre)
                    .HasColumnType("date")
                    .HasColumnName("COB_FINGRE")
                    .HasComment("Fecha de ingreso");

                entity.Property(e => e.CobNlegaj)
                    .HasPrecision(10)
                    .HasColumnName("COB_NLEGAJ")
                    .HasComment("Nro. de legajo");

                entity.Property(e => e.CobNtarje)
                    .HasPrecision(10)
                    .HasColumnName("COB_NTARJE")
                    .HasComment("Nro. de tarjeta");

                entity.Property(e => e.CobObserv)
                    .HasMaxLength(45)
                    .HasColumnName("COB_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<CobranzasCliente>(entity =>
            {
                entity.HasKey(e => e.CobCodcob)
                    .HasName("PRIMARY");

                entity.ToTable("cobranzas_clientes");

                entity.HasComment("Novedades para clientes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CobCodcli, "fk_novedades_cli_clientes1");

                entity.Property(e => e.CobCodcob)
                    .HasColumnName("COB_CODCOB")
                    .HasComment("Id cobranza");

                entity.Property(e => e.CobCodcli)
                    .HasPrecision(6)
                    .HasColumnName("COB_CODCLI")
                    .HasComment("Codigo de cliente");

                entity.Property(e => e.CobDescri)
                    .HasMaxLength(100)
                    .HasColumnName("COB_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.CobEstado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("COB_ESTADO")
                    .HasDefaultValueSql("'0'")
                    .HasComment("ABIERTO, CERRADO");

                entity.Property(e => e.CobFeccon)
                    .HasColumnType("date")
                    .HasColumnName("COB_FECCON")
                    .HasComment("Fecha de contacto");

                entity.Property(e => e.CobFenvoc)
                    .HasColumnType("date")
                    .HasColumnName("COB_FENVOC")
                    .HasComment("Fecha nuevo contacto");

                entity.Property(e => e.CobTipcon)
                    .HasMaxLength(12)
                    .HasColumnName("COB_TIPCON")
                    .HasComment("Tipo de contacto");

                entity.HasOne(d => d.CobCodcliNavigation)
                    .WithMany(p => p.CobranzasClientes)
                    .HasForeignKey(d => d.CobCodcli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_novedade_cli_clientes10");
            });

            modelBuilder.Entity<CompConfigNo>(entity =>
            {
                entity.HasKey(e => e.CocCodcom)
                    .HasName("PRIMARY");

                entity.ToTable("comp_config_no");

                entity.HasComment("Configuración de comprobantes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CocCodcom)
                    .HasColumnName("COC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.CocCopias)
                    .HasColumnName("COC_COPIAS")
                    .HasComment("Cantidad de copias");

                entity.Property(e => e.CocDescom)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("COC_DESCOM")
                    .HasComment("Descripcion de comprobante");

                entity.Property(e => e.CocMaxlin)
                    .HasColumnName("COC_MAXLIN")
                    .HasComment("Maximo de lineas");

                entity.Property(e => e.CocObserv)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("COC_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.CocReport)
                    .HasMaxLength(20)
                    .HasColumnName("COC_REPORT")
                    .HasComment("Nombre del reporte");
            });

            modelBuilder.Entity<ComprobNumero>(entity =>
            {
                entity.HasKey(e => new { e.CynCodcom, e.CynPrefij })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("comprob_numeros");

                entity.HasComment("Comprobantes y Numeros	")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CynCodcom, "fk_comprob_numeros_comprobantes1");

                entity.Property(e => e.CynCodcom)
                    .HasColumnName("CYN_CODCOM")
                    .HasComment("codigo de comprobante");

                entity.Property(e => e.CynPrefij)
                    .HasColumnName("CYN_PREFIJ")
                    .HasComment("Prefijo");

                entity.Property(e => e.CynGruact)
                    .HasColumnName("CYN_GRUACT")
                    .HasComment("Grupo de actualización");

                entity.Property(e => e.CynNumero)
                    .HasPrecision(12)
                    .HasColumnName("CYN_NUMERO")
                    .HasComment("Numero");

                entity.Property(e => e.CynObserv)
                    .HasMaxLength(45)
                    .HasColumnName("CYN_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.CynCodcomNavigation)
                    .WithMany(p => p.ComprobNumeros)
                    .HasForeignKey(d => d.CynCodcom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_comprob_numeros_comprobantes1");
            });

            modelBuilder.Entity<Comprobante>(entity =>
            {
                entity.HasKey(e => e.ComCodcom)
                    .HasName("PRIMARY");

                entity.ToTable("comprobantes");

                entity.HasComment("Comprobantes y Numeros	")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.ComCodcom)
                    .ValueGeneratedNever()
                    .HasColumnName("COM_CODCOM")
                    .HasComment("Codigo");

                entity.Property(e => e.ComAbrev1)
                    .HasMaxLength(15)
                    .HasColumnName("COM_ABREV1")
                    .HasComment("Abreviatura 1");

                entity.Property(e => e.ComAbrevia)
                    .HasMaxLength(3)
                    .HasColumnName("COM_ABREVIA");

                entity.Property(e => e.ComActivo)
                    .HasColumnName("COM_ACTIVO")
                    .HasComment("Indica si el comprob. esta activo");

                entity.Property(e => e.ComCodafi)
                    .HasColumnName("COM_CODAFI")
                    .HasComment("Codigo comprobante s/tabla AFIP");

                entity.Property(e => e.ComCodcit)
                    .HasMaxLength(2)
                    .HasColumnName("COM_CODCIT")
                    .HasComment("Codigo para CITI ventas");

                entity.Property(e => e.ComCoddiv)
                    .HasColumnName("COM_CODDIV")
                    .HasComment("Codigo de division");

                entity.Property(e => e.ComCopias)
                    .HasColumnName("COM_COPIAS")
                    .HasComment("Cantidad de copias");

                entity.Property(e => e.ComDescri)
                    .HasMaxLength(30)
                    .HasColumnName("COM_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.ComGruact).HasColumnName("COM_GRUACT");

                entity.Property(e => e.ComGrupo)
                    .HasMaxLength(30)
                    .HasColumnName("COM_GRUPO")
                    .HasComment("Grupo al que pertenecen");

                entity.Property(e => e.ComLetra)
                    .HasMaxLength(1)
                    .HasColumnName("COM_LETRA")
                    .HasComment("Letra");

                entity.Property(e => e.ComMaxlin)
                    .HasColumnName("COM_MAXLIN")
                    .HasComment("Maximo de lineas");

                entity.Property(e => e.ComNumero)
                    .HasPrecision(12)
                    .HasColumnName("COM_NUMERO")
                    .HasComment("Numero");

                entity.Property(e => e.ComObserv)
                    .HasMaxLength(45)
                    .HasColumnName("COM_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<Concepto>(entity =>
            {
                entity.HasKey(e => e.CoeCodcop)
                    .HasName("PRIMARY");

                entity.ToTable("conceptos");

                entity.HasComment("Conceptos de entrada-salida")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CoeCodcop)
                    .ValueGeneratedNever()
                    .HasColumnName("COE_CODCOP")
                    .HasComment("Codigo de concepto");

                entity.Property(e => e.CoeDescri)
                    .HasMaxLength(40)
                    .HasColumnName("COE_DESCRI");

                entity.Property(e => e.CoeEntsal)
                    .HasMaxLength(1)
                    .HasColumnName("COE_ENTSAL")
                    .HasComment("ENTRADA-SALIDA E-S");

                entity.Property(e => e.CoeModulo)
                    .HasMaxLength(15)
                    .HasColumnName("COE_MODULO");

                entity.Property(e => e.CoeObserv)
                    .HasMaxLength(40)
                    .HasColumnName("COE_OBSERV");
            });

            modelBuilder.Entity<Condiva>(entity =>
            {
                entity.HasKey(e => e.CoiCodciv)
                    .HasName("PRIMARY");

                entity.ToTable("condiva");

                entity.HasComment("Condicion frente al iva")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CoiAbrevi, "COI_ABREVI_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CoiCodciv)
                    .ValueGeneratedNever()
                    .HasColumnName("COI_CODCIV")
                    .HasComment("Codigo condicion de iva");

                entity.Property(e => e.CoiAbrevi)
                    .HasMaxLength(3)
                    .HasColumnName("COI_ABREVI")
                    .HasComment("Abreviatura");

                entity.Property(e => e.CoiDescri)
                    .HasMaxLength(30)
                    .HasColumnName("COI_DESCRI")
                    .HasComment("Descripcion condicion de iva");

                entity.Property(e => e.CoiLetrac)
                    .HasMaxLength(1)
                    .HasColumnName("COI_LETRAC")
                    .HasComment("Letra de Comprobante");

                entity.Property(e => e.CoiTasdif)
                    .HasMaxLength(1)
                    .HasColumnName("COI_TASDIF")
                    .HasComment("Tasa diferencial");
            });

            modelBuilder.Entity<Condpago>(entity =>
            {
                entity.HasKey(e => e.CopCodcpa)
                    .HasName("PRIMARY");

                entity.ToTable("condpago");

                entity.HasComment("Condiciones de venta")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CopCodlis, "fk_condpago_listaprecios_idx");

                entity.Property(e => e.CopCodcpa)
                    .HasColumnName("COP_CODCPA")
                    .HasComment("Codigo: VENTAS 1a 50 (Contado) - 51-99 (Cta.Cte) COMPRAS: 101 A 150");

                entity.Property(e => e.CopCodlis)
                    .HasColumnName("COP_CODLIS")
                    .HasComment("Codigo de lista de precios");

                entity.Property(e => e.CopCuotas)
                    .HasColumnName("COP_CUOTAS")
                    .HasComment("cantidad de cuotas");

                entity.Property(e => e.CopDescri)
                    .HasMaxLength(30)
                    .HasColumnName("COP_DESCRI")
                    .HasComment("descripcion");

                entity.Property(e => e.CopDiacuo)
                    .HasColumnName("COP_DIACUO")
                    .HasComment("Cantidad de dias entre cuotas (30 en gral)");

                entity.Property(e => e.CopDias1vto)
                    .HasColumnName("COP_DIAS1VTO")
                    .HasComment("Dias 1er. venc");

                entity.Property(e => e.CopDiasuvto)
                    .HasColumnName("COP_DIASUVTO")
                    .HasComment("dias ultimo vencimiento");

                entity.Property(e => e.CopDto1)
                    .HasPrecision(5, 2)
                    .HasColumnName("COP_DTO1")
                    .HasComment("descuento 1");

                entity.Property(e => e.CopDto2)
                    .HasPrecision(5, 2)
                    .HasColumnName("COP_DTO2")
                    .HasComment("descuento 2");

                entity.Property(e => e.CopDto3)
                    .HasPrecision(5, 2)
                    .HasColumnName("COP_DTO3")
                    .HasComment("descuento 3");

                entity.Property(e => e.CopModulo)
                    .HasMaxLength(10)
                    .HasColumnName("COP_MODULO")
                    .HasComment("Modulo a que corresponde: COMPRAS-VENTAS");

                entity.Property(e => e.CopPartic)
                    .HasColumnName("COP_PARTIC")
                    .HasComment("Porcentaje de participación de c/ cuota");

                entity.Property(e => e.CopRec1)
                    .HasPrecision(5, 2)
                    .HasColumnName("COP_REC1")
                    .HasComment("recargo 1");

                entity.HasOne(d => d.CopCodlisNavigation)
                    .WithMany(p => p.Condpagos)
                    .HasForeignKey(d => d.CopCodlis)
                    .HasConstraintName("fk_condpago_listaprecios");
            });

            modelBuilder.Entity<CondpagoAnt>(entity =>
            {
                entity.HasKey(e => e.Codcpgo)
                    .HasName("PRIMARY");

                entity.ToTable("condpago_ant");

                entity.HasComment("Condiciones de venta")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Codcpgo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODCPGO")
                    .HasComment("Codigo");

                entity.Property(e => e.Codlis)
                    .HasMaxLength(45)
                    .HasColumnName("CODLIS")
                    .HasComment("Codigo de lista");

                entity.Property(e => e.Descri)
                    .HasMaxLength(30)
                    .HasColumnName("DESCRI")
                    .HasComment("descripcion");

                entity.Property(e => e.Dias1)
                    .HasColumnName("DIAS1")
                    .HasComment("Dias 1er. venc");

                entity.Property(e => e.Dias10).HasColumnName("DIAS10");

                entity.Property(e => e.Dias2)
                    .HasColumnName("DIAS2")
                    .HasComment("dias 2do. venc");

                entity.Property(e => e.Dias3)
                    .HasColumnName("DIAS3")
                    .HasComment("diar 3er. venc");

                entity.Property(e => e.Dias4)
                    .HasColumnName("DIAS4")
                    .HasComment("dias 4to. venc");

                entity.Property(e => e.Dias5)
                    .HasColumnName("DIAS5")
                    .HasComment("dias 5to. venc");

                entity.Property(e => e.Dias6)
                    .HasColumnName("DIAS6")
                    .HasComment("dias 6to. venc");

                entity.Property(e => e.Dias7)
                    .HasColumnName("DIAS7")
                    .HasComment("dias 7mo venc");

                entity.Property(e => e.Dias8)
                    .HasColumnName("DIAS8")
                    .HasComment("dias 8vo venc");

                entity.Property(e => e.Dias9)
                    .HasColumnName("DIAS9")
                    .HasComment("dias 10mo. venc");

                entity.Property(e => e.Dto1)
                    .HasPrecision(5, 2)
                    .HasColumnName("DTO1")
                    .HasComment("descuento 1");

                entity.Property(e => e.Dto2)
                    .HasPrecision(5, 2)
                    .HasColumnName("DTO2")
                    .HasComment("descuento 2");

                entity.Property(e => e.Dto3)
                    .HasPrecision(5, 2)
                    .HasColumnName("DTO3")
                    .HasComment("descuento 3");

                entity.Property(e => e.Rec1)
                    .HasPrecision(5, 2)
                    .HasColumnName("REC1")
                    .HasComment("recargo 1");
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.HasKey(e => e.ConCodcon)
                    .HasName("PRIMARY");

                entity.ToTable("contactos");

                entity.HasComment("Clientes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.ConCodcon)
                    .HasPrecision(6)
                    .HasColumnName("CON_CODCON")
                    .HasComment("Codigo de contacto");

                entity.Property(e => e.ConCargo)
                    .HasMaxLength(20)
                    .HasColumnName("CON_CARGO")
                    .HasComment("Cargo");

                entity.Property(e => e.ConEnviaf).HasColumnName("CON_ENVIAF");

                entity.Property(e => e.ConFax)
                    .HasMaxLength(20)
                    .HasColumnName("CON_FAX");

                entity.Property(e => e.ConFecnac)
                    .HasColumnType("date")
                    .HasColumnName("CON_FECNAC")
                    .HasComment("Fecha de nacimiento");

                entity.Property(e => e.ConHorari)
                    .HasMaxLength(20)
                    .HasColumnName("CON_HORARI")
                    .HasComment("Horario de trabajo");

                entity.Property(e => e.ConIntern)
                    .HasMaxLength(6)
                    .HasColumnName("CON_INTERN")
                    .HasComment("Interno");

                entity.Property(e => e.ConMail)
                    .HasMaxLength(45)
                    .HasColumnName("CON_MAIL")
                    .HasComment("mail contacto");

                entity.Property(e => e.ConNombre)
                    .HasMaxLength(40)
                    .HasColumnName("CON_NOMBRE")
                    .HasComment("Nombre de  contacto");

                entity.Property(e => e.ConObserv)
                    .HasMaxLength(45)
                    .HasColumnName("CON_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.ConTelcel)
                    .HasMaxLength(20)
                    .HasColumnName("CON_TELCEL")
                    .HasComment("Nro Tel Celular");

                entity.Property(e => e.ConTelef1)
                    .HasMaxLength(20)
                    .HasColumnName("CON_TELEF1")
                    .HasComment("Telefono 1");

                entity.Property(e => e.ConTelef2)
                    .HasMaxLength(20)
                    .HasColumnName("CON_TELEF2")
                    .HasComment("Telefono 2");
            });

            modelBuilder.Entity<ContrFiscal>(entity =>
            {
                entity.HasKey(e => e.CofCodcon)
                    .HasName("PRIMARY");

                entity.ToTable("contr_fiscal");

                entity.HasComment("Parametros controlador Fiscal")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CofCodcon)
                    .ValueGeneratedNever()
                    .HasColumnName("COF_CODCON")
                    .HasComment("Codigo de controlador");

                entity.Property(e => e.CofEnuso)
                    .HasColumnName("COF_ENUSO")
                    .HasComment("En uso: 0=NO 1=SI");

                entity.Property(e => e.CofIpspoo)
                    .HasMaxLength(15)
                    .HasColumnName("COF_IPSPOO")
                    .HasComment("IP Servidor que esta conectado el spooler");

                entity.Property(e => e.CofModelo)
                    .HasMaxLength(30)
                    .HasColumnName("COF_MODELO")
                    .HasComment("Modelo");

                entity.Property(e => e.CofPueblo)
                    .HasColumnName("COF_PUEBLO")
                    .HasComment("Puesto que esta bloqueando");

                entity.Property(e => e.CofPuerto)
                    .HasColumnName("COF_PUERTO")
                    .HasComment("Puerto donde escucha el servidor");
            });

            modelBuilder.Entity<Coperacion>(entity =>
            {
                entity.HasKey(e => e.CoeCodcop)
                    .HasName("PRIMARY");

                entity.ToTable("coperacion");

                entity.HasComment("Conceptos de operacion")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.CoeCodcop)
                    .ValueGeneratedNever()
                    .HasColumnName("COE_CODCOP")
                    .HasComment("Codigo de concepto");

                entity.Property(e => e.CoeDescri)
                    .HasMaxLength(40)
                    .HasColumnName("COE_DESCRI");

                entity.Property(e => e.CoeModulo)
                    .HasMaxLength(15)
                    .HasColumnName("COE_MODULO");
            });

            modelBuilder.Entity<Ctasbanc>(entity =>
            {
                entity.HasKey(e => e.CbaCodctb)
                    .HasName("PRIMARY");

                entity.ToTable("ctasbanc");

                entity.HasComment("Cuentas bancarias de la empresa")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CbaCodban, "fk_ctasbanc_bancos_idx");

                entity.HasIndex(e => e.CbaCodmon, "fk_ctasbanc_monedas_idx");

                entity.Property(e => e.CbaCodctb)
                    .ValueGeneratedNever()
                    .HasColumnName("CBA_CODCTB")
                    .HasComment("Codigo de cuenta");

                entity.Property(e => e.CbaCbuctb)
                    .HasMaxLength(22)
                    .HasColumnName("CBA_CBUCTB")
                    .HasComment("CBU");

                entity.Property(e => e.CbaCodban)
                    .HasColumnName("CBA_CODBAN")
                    .HasComment("Codigo de banco");

                entity.Property(e => e.CbaCodcuc)
                    .HasColumnName("CBA_CODCUC")
                    .HasComment("Codigo de cuenta contable");

                entity.Property(e => e.CbaCodmon)
                    .HasColumnName("CBA_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.CbaDesctb)
                    .HasMaxLength(40)
                    .HasColumnName("CBA_DESCTB")
                    .HasComment("Nombre-denominacion cta");

                entity.Property(e => e.CbaDescub)
                    .HasPrecision(13, 2)
                    .HasColumnName("CBA_DESCUB")
                    .HasComment("Descubierto");

                entity.Property(e => e.CbaFecalt)
                    .HasColumnType("date")
                    .HasColumnName("CBA_FECALT")
                    .HasComment("fecha de alta");

                entity.Property(e => e.CbaNroctb)
                    .HasMaxLength(15)
                    .HasColumnName("CBA_NROCTB")
                    .HasComment("Nro de cuenta");

                entity.Property(e => e.CbaObserv)
                    .HasColumnName("CBA_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.CbaSaldo)
                    .HasColumnName("CBA_SALDO")
                    .HasComment("saldo ");

                entity.Property(e => e.CbaSuccta)
                    .HasMaxLength(6)
                    .HasColumnName("CBA_SUCCTA")
                    .HasComment("Codigo de sucursal");

                entity.Property(e => e.CbaTipctb)
                    .HasMaxLength(20)
                    .HasColumnName("CBA_TIPCTB")
                    .HasComment("Tipo de cuenta: cuenta corriente, caja de ahorro");

                entity.HasOne(d => d.CbaCodbanNavigation)
                    .WithMany(p => p.Ctasbancs)
                    .HasForeignKey(d => d.CbaCodban)
                    .HasConstraintName("fk_ctasbanc_bancos");

                entity.HasOne(d => d.CbaCodmonNavigation)
                    .WithMany(p => p.Ctasbancs)
                    .HasForeignKey(d => d.CbaCodmon)
                    .HasConstraintName("fk_ctasbanc_monedas");
            });

            modelBuilder.Entity<CtasbancPro>(entity =>
            {
                entity.HasKey(e => new { e.CbpCodpro, e.CbpNrocta })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ctasbanc_pro");

                entity.HasComment("Cuentas Bancarias Proveedores")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CbpCodmon, "fk_ctasbanc_pro_monedas_idx");

                entity.Property(e => e.CbpCodpro).HasColumnName("CBP_CODPRO");

                entity.Property(e => e.CbpNrocta)
                    .HasMaxLength(25)
                    .HasColumnName("CBP_NROCTA")
                    .HasDefaultValueSql("'\"\"'")
                    .HasComment("Cuentas bancarias proveedores");

                entity.Property(e => e.CbpBanco)
                    .HasMaxLength(15)
                    .HasColumnName("CBP_BANCO");

                entity.Property(e => e.CbpCodmon).HasColumnName("CBP_CODMON");

                entity.Property(e => e.CbpNrocbu)
                    .HasMaxLength(22)
                    .HasColumnName("CBP_NROCBU")
                    .HasComment("Nro. de CBU");

                entity.Property(e => e.CbpObserv)
                    .HasMaxLength(30)
                    .HasColumnName("CBP_OBSERV");

                entity.Property(e => e.CbpSucurs)
                    .HasMaxLength(15)
                    .HasColumnName("CBP_SUCURS");

                entity.Property(e => e.CbpTipcta)
                    .HasMaxLength(15)
                    .HasColumnName("CBP_TIPCTA");

                entity.Property(e => e.CbpTitula)
                    .HasMaxLength(45)
                    .HasColumnName("CBP_TITULA")
                    .HasComment("Titular de la cuenta");
            });

            modelBuilder.Entity<Ctasctesc>(entity =>
            {
                entity.HasKey(e => new { e.CccCodcom, e.CccNrocom, e.CccCodpro })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("ctasctesc");

                entity.HasComment("Ctas. Ctes. proveedores  - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CccCodcob, "fk_ctasctesc_cobradores_idx");

                entity.HasIndex(e => e.CccCodcop, "fk_ctasctesc_condpago_idx");

                entity.HasIndex(e => e.CccCodlis, "fk_ctasctesc_listapre_idx");

                entity.HasIndex(e => e.CccCodmon, "fk_ctasctesc_monedas_idx");

                entity.Property(e => e.CccCodcom)
                    .HasColumnName("CCC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.CccNrocom)
                    .HasPrecision(12)
                    .HasColumnName("CCC_NROCOM")
                    .HasComment("Numero de Comprobante");

                entity.Property(e => e.CccCodpro)
                    .HasPrecision(6)
                    .HasColumnName("CCC_CODPRO")
                    .HasComment("Cod. de proveedor");

                entity.Property(e => e.CccCodcob)
                    .HasColumnName("CCC_CODCOB")
                    .HasComment("Codigo de cobrador");

                entity.Property(e => e.CccCodcop)
                    .HasColumnName("CCC_CODCOP")
                    .HasComment("Codigo condicion de pago");

                entity.Property(e => e.CccCodlis)
                    .HasColumnName("CCC_CODLIS")
                    .HasComment("Codigo de lista de precios");

                entity.Property(e => e.CccCodmon)
                    .HasColumnName("CCC_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.CccEstado)
                    .HasMaxLength(10)
                    .HasColumnName("CCC_ESTADO")
                    .HasComment("Estado del comprob. PENDIENTE,P.PARCIAL,SALDADO");

                entity.Property(e => e.CccFeccom)
                    .HasColumnType("date")
                    .HasColumnName("CCC_FECCOM")
                    .HasComment("Fecha de comprobante");

                entity.Property(e => e.CccFecpve)
                    .HasColumnType("date")
                    .HasColumnName("CCC_FECPVE")
                    .HasComment("Fecha proximo vencimiento");

                entity.Property(e => e.CccFecuve)
                    .HasColumnType("date")
                    .HasColumnName("CCC_FECUVE")
                    .HasComment("Fecha ultimo vencimiento");

                entity.Property(e => e.CccImpdeb)
                    .HasPrecision(13, 2)
                    .HasColumnName("CCC_IMPDEB")
                    .HasComment("Importe DEBE");

                entity.Property(e => e.CccImphab)
                    .HasPrecision(13, 2)
                    .HasColumnName("CCC_IMPHAB")
                    .HasComment("Importe HABER");

                entity.Property(e => e.CccImpsal)
                    .HasPrecision(13, 2)
                    .HasColumnName("CCC_IMPSAL")
                    .HasComment("Saldo del comprobante");

                entity.Property(e => e.CccLetra)
                    .HasMaxLength(1)
                    .HasColumnName("CCC_LETRA")
                    .HasComment("Letra de comprobante");

                entity.Property(e => e.CccNrocta)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("CCC_NROCTA")
                    .HasDefaultValueSql("''")
                    .HasComment("Nro de cuenta bancaria... para ordenes de pago");

                entity.Property(e => e.CccObserv)
                    .HasMaxLength(45)
                    .HasColumnName("CCC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<CtasctescDet>(entity =>
            {
                entity.HasKey(e => new { e.CdcCodcom, e.CdcNrocom, e.CdcCodpro, e.CdcNrocuo })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("ctasctesc_det");

                entity.HasComment("Fac_NC_ND proveedores  - detalle")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.CdcCodcom, e.CdcNrocom, e.CdcCodpro }, "fk_ctasctesc_det_ctasctesc1");

                entity.Property(e => e.CdcCodcom).HasColumnName("CDC_CODCOM");

                entity.Property(e => e.CdcNrocom)
                    .HasPrecision(12)
                    .HasColumnName("CDC_NROCOM");

                entity.Property(e => e.CdcCodpro)
                    .HasPrecision(6)
                    .HasColumnName("CDC_CODPRO");

                entity.Property(e => e.CdcNrocuo)
                    .HasColumnName("CDC_NROCUO")
                    .HasComment("Nro de cuota");

                entity.Property(e => e.CdcCodcoa)
                    .HasColumnName("CDC_CODCOA")
                    .HasComment("Codigo comprobante que aplica");

                entity.Property(e => e.CdcEstado)
                    .HasMaxLength(10)
                    .HasColumnName("CDC_ESTADO")
                    .HasComment("Estado de la cuota: PENDIENTE - PAGO PARCIAL - SALDADA");

                entity.Property(e => e.CdcFecven)
                    .HasColumnType("date")
                    .HasColumnName("CDC_FECVEN")
                    .HasComment("Fecha vencimiento cuota");

                entity.Property(e => e.CdcImpcuo)
                    .HasPrecision(13, 2)
                    .HasColumnName("CDC_IMPCUO")
                    .HasComment("Importe CUOTA");

                entity.Property(e => e.CdcImpsal)
                    .HasPrecision(13, 2)
                    .HasColumnName("CDC_IMPSAL")
                    .HasComment("Importe saldo de la cuota");

                entity.Property(e => e.CdcNrocoa)
                    .HasPrecision(12)
                    .HasColumnName("CDC_NROCOA")
                    .HasComment("Nro comprobante que aplica");

                entity.Property(e => e.CdcNrocua)
                    .HasColumnName("CDC_NROCUA")
                    .HasComment("Nro cuota que aplica");

                entity.Property(e => e.CdcObserv)
                    .HasMaxLength(45)
                    .HasColumnName("CDC_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.Cdc)
                    .WithMany(p => p.CtasctescDets)
                    .HasForeignKey(d => new { d.CdcCodcom, d.CdcNrocom, d.CdcCodpro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ctasctesc_det_ctasctesc1");
            });

            modelBuilder.Entity<Ctasctesv>(entity =>
            {
                entity.HasKey(e => new { e.CcvNrocom, e.CcvCodcom })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ctasctesv");

                entity.HasComment("Fac_NC_ND de venta  - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.CcvCodcob, "fk_ctasctesv_cobradores_idx");

                entity.Property(e => e.CcvNrocom)
                    .HasPrecision(12)
                    .HasColumnName("CCV_NROCOM")
                    .HasComment("Numero de Comprobante");

                entity.Property(e => e.CcvCodcom)
                    .HasColumnName("CCV_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.CcvCodcli)
                    .HasPrecision(6)
                    .HasColumnName("CCV_CODCLI")
                    .HasComment("Cod. de cliente");

                entity.Property(e => e.CcvCodcob)
                    .HasColumnName("CCV_CODCOB")
                    .HasComment("Codigo de cobrador");

                entity.Property(e => e.CcvCodcop)
                    .HasColumnName("CCV_CODCOP")
                    .HasComment("Codigo condicion de pago");

                entity.Property(e => e.CcvCodlis)
                    .HasColumnName("CCV_CODLIS")
                    .HasComment("Codigo de lista de precios");

                entity.Property(e => e.CcvCodmon)
                    .HasColumnName("CCV_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.CcvEstado)
                    .HasMaxLength(10)
                    .HasColumnName("CCV_ESTADO")
                    .HasComment("Estado del comprob. PENDIENTE,P.PARCIAL,SALDADO");

                entity.Property(e => e.CcvFeccom)
                    .HasColumnType("date")
                    .HasColumnName("CCV_FECCOM")
                    .HasComment("Fecha de comprobante");

                entity.Property(e => e.CcvFecpve)
                    .HasColumnType("date")
                    .HasColumnName("CCV_FECPVE")
                    .HasComment("Fecha proximo vencimiento");

                entity.Property(e => e.CcvFecuve)
                    .HasColumnType("date")
                    .HasColumnName("CCV_FECUVE")
                    .HasComment("Fecha ultimo vencimiento");

                entity.Property(e => e.CcvImpdeb)
                    .HasPrecision(13, 2)
                    .HasColumnName("CCV_IMPDEB")
                    .HasComment("Importe DEBE");

                entity.Property(e => e.CcvImphab)
                    .HasPrecision(13, 2)
                    .HasColumnName("CCV_IMPHAB")
                    .HasComment("Importe HABER");

                entity.Property(e => e.CcvImpsal)
                    .HasPrecision(13, 2)
                    .HasColumnName("CCV_IMPSAL")
                    .HasComment("Saldo del comprobante");

                entity.Property(e => e.CcvLetra)
                    .HasMaxLength(1)
                    .HasColumnName("CCV_LETRA")
                    .HasComment("Letra de comprobante");

                entity.Property(e => e.CcvObserv)
                    .HasMaxLength(45)
                    .HasColumnName("CCV_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.CcvSalcli)
                    .HasPrecision(13, 2)
                    .HasColumnName("CCV_SALCLI")
                    .HasComment("Saldo del cliente luego de la confección del recibo.");
            });

            modelBuilder.Entity<CtasctesvDet>(entity =>
            {
                entity.HasKey(e => new { e.CdvCodcom, e.CdvNrocom, e.CdvNrocuo })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("ctasctesv_det");

                entity.HasComment("Fac_NC_ND de venta  - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.CdvNrocom, e.CdvCodcom }, "CtasCtesV_FK");

                entity.Property(e => e.CdvCodcom)
                    .HasColumnName("CDV_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.CdvNrocom)
                    .HasPrecision(12)
                    .HasColumnName("CDV_NROCOM")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.CdvNrocuo)
                    .HasColumnName("CDV_NROCUO")
                    .HasComment("Nro de cuota");

                entity.Property(e => e.CdvCodcoa)
                    .HasColumnName("CDV_CODCOA")
                    .HasComment("Codigo comprobante que aplica");

                entity.Property(e => e.CdvEstado)
                    .HasMaxLength(10)
                    .HasColumnName("CDV_ESTADO")
                    .HasComment("Estado de la cuota: PENDIENTE - PAGO PARCIAL - SALDADA");

                entity.Property(e => e.CdvFecven)
                    .HasColumnType("date")
                    .HasColumnName("CDV_FECVEN")
                    .HasComment("Fecha vencimiento cuota");

                entity.Property(e => e.CdvImpcuo)
                    .HasPrecision(13, 2)
                    .HasColumnName("CDV_IMPCUO")
                    .HasComment("Importe CUOTA");

                entity.Property(e => e.CdvImpsal)
                    .HasPrecision(13, 2)
                    .HasColumnName("CDV_IMPSAL")
                    .HasComment("Importe saldo de la cuota");

                entity.Property(e => e.CdvNrocoa)
                    .HasPrecision(12)
                    .HasColumnName("CDV_NROCOA")
                    .HasComment("Nro comprobante que aplica");

                entity.Property(e => e.CdvNrocua)
                    .HasColumnName("CDV_NROCUA")
                    .HasComment("Nro cuota que aplica");

                entity.Property(e => e.CdvObserv)
                    .HasMaxLength(45)
                    .HasColumnName("CDV_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.Cdv)
                    .WithMany(p => p.CtasctesvDets)
                    .HasForeignKey(d => new { d.CdvNrocom, d.CdvCodcom })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ctasctesv_det_ctasctesv1");
            });

            modelBuilder.Entity<DepbancCli>(entity =>
            {
                entity.HasKey(e => e.DecIdmovi)
                    .HasName("PRIMARY");

                entity.ToTable("depbanc_cli");

                entity.HasComment("Depositos y tansferencias  de clientes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.DecCodcli, "fk_decbanc_cli_clientes_idx");

                entity.Property(e => e.DecIdmovi)
                    .HasColumnName("DEC_IDMOVI")
                    .HasComment("Id Movimiento (autoincremental)");

                entity.Property(e => e.DecCodcli)
                    .HasPrecision(6)
                    .HasColumnName("DEC_CODCLI")
                    .HasComment("Codigo de cliente");

                entity.Property(e => e.DecCodcta)
                    .HasColumnName("DEC_CODCTA")
                    .HasComment("Codigo cuenta bancaria");

                entity.Property(e => e.DecDescli)
                    .HasMaxLength(45)
                    .HasColumnName("DEC_DESCLI")
                    .HasComment("Descripcion de cliente");

                entity.Property(e => e.DecFecdep)
                    .HasColumnType("date")
                    .HasColumnName("DEC_FECDEP")
                    .HasComment("Fecha deposito");

                entity.Property(e => e.DecImpdep)
                    .HasPrecision(13, 2)
                    .HasColumnName("DEC_IMPDEP")
                    .HasComment("Importe depositado");

                entity.Property(e => e.DecNromov)
                    .HasMaxLength(20)
                    .HasColumnName("DEC_NROMOV")
                    .HasComment("Nro de movimiento/autorizacion		");

                entity.Property(e => e.DecObserv)
                    .HasMaxLength(40)
                    .HasColumnName("DEC_OBSERV");
            });

            modelBuilder.Entity<DepbancPro>(entity =>
            {
                entity.HasKey(e => e.DepIdmovi)
                    .HasName("PRIMARY");

                entity.ToTable("depbanc_pro");

                entity.HasComment("Depositos y tansferencias a proveedores")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.DepCodpro, "fk_depbanc_pro_proveedores_idx");

                entity.Property(e => e.DepIdmovi)
                    .HasColumnName("DEP_IDMOVI")
                    .HasComment("Id Movimiento (autoincremental)");

                entity.Property(e => e.DepCodcta)
                    .HasColumnName("DEP_CODCTA")
                    .HasComment("Codigo cuenta bancaria");

                entity.Property(e => e.DepCodpro)
                    .HasColumnName("DEP_CODPRO")
                    .HasComment("Codigo de proveedor");

                entity.Property(e => e.DepDespro)
                    .HasMaxLength(45)
                    .HasColumnName("DEP_DESPRO")
                    .HasComment("Descripcion de proveedor");

                entity.Property(e => e.DepFecdep)
                    .HasColumnType("date")
                    .HasColumnName("DEP_FECDEP")
                    .HasComment("Fecha deposito");

                entity.Property(e => e.DepImpdep)
                    .HasPrecision(13, 2)
                    .HasColumnName("DEP_IMPDEP")
                    .HasComment("Importe depositado");

                entity.Property(e => e.DepNromov)
                    .HasMaxLength(20)
                    .HasColumnName("DEP_NROMOV")
                    .HasComment("Nro de movimiento/autorizacion		");

                entity.Property(e => e.DepObserv)
                    .HasMaxLength(40)
                    .HasColumnName("DEP_OBSERV");

                entity.HasOne(d => d.DepCodproNavigation)
                    .WithMany(p => p.DepbancPros)
                    .HasForeignKey(d => d.DepCodpro)
                    .HasConstraintName("fk_depbanc_pro_proveedores");
            });

            modelBuilder.Entity<Deposito>(entity =>
            {
                entity.HasKey(e => e.DepCoddep)
                    .HasName("PRIMARY");

                entity.ToTable("depositos");

                entity.HasComment("Depósitos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.DepCoddep)
                    .ValueGeneratedNever()
                    .HasColumnName("DEP_CODDEP")
                    .HasComment("Codigo de depósito");

                entity.Property(e => e.DepDescri)
                    .HasMaxLength(45)
                    .HasColumnName("DEP_DESCRI")
                    .HasComment("Descripción");
            });

            modelBuilder.Entity<DevolucMot>(entity =>
            {
                entity.HasKey(e => e.DemCoddev)
                    .HasName("PRIMARY");

                entity.ToTable("devoluc_mot");

                entity.HasComment("Motivos de devolución")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.DemCoddev)
                    .ValueGeneratedNever()
                    .HasColumnName("DEM_CODDEV")
                    .HasComment("Codigo motivo devolucion");

                entity.Property(e => e.DemDescri)
                    .HasMaxLength(30)
                    .HasColumnName("DEM_DESCRI")
                    .HasComment("Descripción motivo");
            });

            modelBuilder.Entity<Devolucione>(entity =>
            {
                entity.HasKey(e => e.DevNrodev)
                    .HasName("PRIMARY");

                entity.ToTable("devoluciones");

                entity.HasComment("material devuelto")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.DevCoddev, "fk_devoluciones_devoluc_mot1");

                entity.Property(e => e.DevNrodev)
                    .ValueGeneratedNever()
                    .HasColumnName("DEV_NRODEV")
                    .HasComment("Numero de devolución");

                entity.Property(e => e.DevCandev)
                    .HasPrecision(11, 2)
                    .HasColumnName("DEV_CANDEV")
                    .HasComment("Cantidad devuelta");

                entity.Property(e => e.DevCodart)
                    .HasMaxLength(15)
                    .HasColumnName("DEV_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.DevCoddev)
                    .HasColumnName("DEV_CODDEV")
                    .HasComment("Codigo de devolución");

                entity.Property(e => e.DevCodrem)
                    .HasColumnName("DEV_CODREM")
                    .HasComment("Nro. de remito");

                entity.Property(e => e.DevDescri)
                    .HasMaxLength(40)
                    .HasColumnName("DEV_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.DevFecdev)
                    .HasColumnType("date")
                    .HasColumnName("DEV_FECDEV")
                    .HasComment("Fecha devolución");

                entity.Property(e => e.DevLinrem)
                    .HasColumnName("DEV_LINREM")
                    .HasComment("Nro. de linea");

                entity.Property(e => e.DevUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("DEV_UNIMED")
                    .HasComment("Unidad de medida");

                entity.HasOne(d => d.DevCoddevNavigation)
                    .WithMany(p => p.Devoluciones)
                    .HasForeignKey(d => d.DevCoddev)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_devoluciones_devoluc_mot1");
            });

            modelBuilder.Entity<Divisione>(entity =>
            {
                entity.HasKey(e => e.DivCoddiv)
                    .HasName("PRIMARY");

                entity.ToTable("divisiones");

                entity.HasComment("Divisiones de la empresa")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.DivCoddiv)
                    .ValueGeneratedNever()
                    .HasColumnName("DIV_CODDIV")
                    .HasComment("Codigo de division");

                entity.Property(e => e.DivAbrevi)
                    .HasMaxLength(3)
                    .HasColumnName("DIV_ABREVI")
                    .HasComment("Abreviatura");

                entity.Property(e => e.DivDescri)
                    .HasMaxLength(40)
                    .HasColumnName("DIV_DESCRI")
                    .HasComment("Descripcion");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.EmpCodemp)
                    .HasName("PRIMARY");

                entity.ToTable("empresa");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.EmpCodemp)
                    .ValueGeneratedNever()
                    .HasColumnName("EMP_CODEMP")
                    .HasComment("Id empresa");

                entity.Property(e => e.EmpActiv1)
                    .HasMaxLength(40)
                    .HasColumnName("EMP_ACTIV1")
                    .HasComment("Actividad 1");

                entity.Property(e => e.EmpActiv2)
                    .HasMaxLength(40)
                    .HasColumnName("EMP_ACTIV2")
                    .HasComment("Actividad 2");

                entity.Property(e => e.EmpCiudad)
                    .HasMaxLength(30)
                    .HasColumnName("EMP_CIUDAD")
                    .HasComment("Localidad");

                entity.Property(e => e.EmpCuit)
                    .HasMaxLength(11)
                    .HasColumnName("EMP_CUIT")
                    .HasComment("Número de CUIT");

                entity.Property(e => e.EmpDirecc)
                    .HasMaxLength(40)
                    .HasColumnName("EMP_DIRECC")
                    .HasComment("Dirección");

                entity.Property(e => e.EmpFax)
                    .HasMaxLength(45)
                    .HasColumnName("EMP_FAX");

                entity.Property(e => e.EmpIngbru)
                    .HasMaxLength(15)
                    .HasColumnName("EMP_INGBRU")
                    .HasComment("Número de Ingr. Brutos");

                entity.Property(e => e.EmpIniact)
                    .HasColumnType("date")
                    .HasColumnName("EMP_INIACT")
                    .HasComment("Inicio de actividades");

                entity.Property(e => e.EmpIva)
                    .HasMaxLength(30)
                    .HasColumnName("EMP_IVA")
                    .HasComment("Tipo de IVA");

                entity.Property(e => e.EmpMail)
                    .HasMaxLength(45)
                    .HasColumnName("EMP_MAIL")
                    .HasComment("Mail");

                entity.Property(e => e.EmpProvin)
                    .HasMaxLength(30)
                    .HasColumnName("EMP_PROVIN")
                    .HasComment("Provincia");

                entity.Property(e => e.EmpRazsoc)
                    .HasMaxLength(40)
                    .HasColumnName("EMP_RAZSOC")
                    .HasComment("Razón Social");

                entity.Property(e => e.EmpTelefo)
                    .HasMaxLength(45)
                    .HasColumnName("EMP_TELEFO")
                    .HasComment("Telefonos");

                entity.Property(e => e.EmpWeb)
                    .HasMaxLength(45)
                    .HasColumnName("EMP_WEB")
                    .HasComment("Web");
            });

            modelBuilder.Entity<Equivalencia>(entity =>
            {
                entity.HasKey(e => e.EquCodart)
                    .HasName("PRIMARY");

                entity.ToTable("equivalencias");

                entity.HasComment("Articulos equivalentes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.EquCodart)
                    .HasMaxLength(15)
                    .HasColumnName("EQU_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.EquCodequ)
                    .HasMaxLength(15)
                    .HasColumnName("EQU_CODEQU")
                    .HasComment("Codigo");

                entity.Property(e => e.EquObserv)
                    .HasMaxLength(15)
                    .HasColumnName("EQU_OBSERV");

                entity.HasOne(d => d.EquCodartNavigation)
                    .WithOne(p => p.Equivalencia)
                    .HasForeignKey<Equivalencia>(d => d.EquCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_equivalencias_articulos");
            });

            modelBuilder.Entity<Errore>(entity =>
            {
                entity.HasKey(e => e.ErrId)
                    .HasName("PRIMARY");

                entity.ToTable("errores");

                entity.HasComment("Log de errores")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ErrId, "XPKDI_ERR_M")
                    .IsUnique();

                entity.Property(e => e.ErrId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("ERR_ID");

                entity.Property(e => e.ErrAplica)
                    .HasMaxLength(30)
                    .HasColumnName("ERR_APLICA");

                entity.Property(e => e.ErrCodigo)
                    .HasPrecision(15)
                    .HasColumnName("ERR_CODIGO");

                entity.Property(e => e.ErrDescri)
                    .HasMaxLength(255)
                    .HasColumnName("ERR_DESCRI");

                entity.Property(e => e.ErrFechor)
                    .HasColumnType("timestamp")
                    .HasColumnName("ERR_FECHOR")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.ErrFormul)
                    .HasMaxLength(40)
                    .HasColumnName("ERR_FORMUL");

                entity.Property(e => e.ErrPuesto)
                    .HasMaxLength(30)
                    .HasColumnName("ERR_PUESTO");

                entity.Property(e => e.ErrUsuari)
                    .HasMaxLength(10)
                    .HasColumnName("ERR_USUARI");
            });

            modelBuilder.Entity<Facturasc>(entity =>
            {
                entity.HasKey(e => new { e.FccCodcom, e.FccNrofac, e.FccCodpro, e.FccCoddep, e.FccCodtra })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

                entity.ToTable("facturasc");

                entity.HasComment("Fac_NC_ND de compra - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.FccCodcop, "fk_facturasc_conceptos1");

                entity.HasIndex(e => e.FccCodcpa, "fk_facturasc_condpago_idx");

                entity.HasIndex(e => e.FccCoddep, "fk_facturasc_depositos");

                entity.HasIndex(e => e.FccCodusu, "fk_facturasc_usuarios_idx");

                entity.Property(e => e.FccCodcom)
                    .HasColumnName("FCC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.FccNrofac)
                    .HasPrecision(12)
                    .HasColumnName("FCC_NROFAC")
                    .HasComment("Numero de Comrobante");

                entity.Property(e => e.FccCodpro)
                    .HasPrecision(6)
                    .HasColumnName("FCC_CODPRO")
                    .HasComment("Cod. de proveedor");

                entity.Property(e => e.FccCoddep)
                    .HasColumnName("FCC_CODDEP")
                    .HasComment("Codigo de deposito");

                entity.Property(e => e.FccCodtra)
                    .HasColumnName("FCC_CODTRA")
                    .HasComment("Codigo de transportista");

                entity.Property(e => e.FccBonif1)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_BONIF1")
                    .HasComment("Bonificacion 1");

                entity.Property(e => e.FccBonif2)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_BONIF2")
                    .HasComment("bonificacion 2");

                entity.Property(e => e.FccCmoori)
                    .HasColumnName("FCC_CMOORI")
                    .HasComment("codigo de moneda original");

                entity.Property(e => e.FccCodcop)
                    .HasColumnName("FCC_CODCOP")
                    .HasComment("Código de Concepto");

                entity.Property(e => e.FccCodcpa)
                    .HasColumnName("FCC_CODCPA")
                    .HasComment("Codigo condicion de pago");

                entity.Property(e => e.FccCodlis)
                    .HasColumnName("FCC_CODLIS")
                    .HasComment("Codigo de lista de precios");

                entity.Property(e => e.FccCodmon)
                    .HasColumnName("FCC_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.FccCodusu)
                    .HasColumnName("FCC_CODUSU")
                    .HasComment("id usuario");

                entity.Property(e => e.FccDtogen)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_DTOGEN")
                    .HasComment("Importe dto. gral comprobante");

                entity.Property(e => e.FccDtogep)
                    .HasPrecision(5, 2)
                    .HasColumnName("FCC_DTOGEP")
                    .HasComment("Porcentaje dto. gral.");

                entity.Property(e => e.FccEstado)
                    .HasMaxLength(10)
                    .HasColumnName("FCC_ESTADO")
                    .HasComment("Estado del comprobante : ABIERTO, CERRADO, ANULADO,CONTABILIZ");

                entity.Property(e => e.FccFecfac)
                    .HasColumnType("date")
                    .HasColumnName("FCC_FECFAC")
                    .HasComment("Fecha de comprobante");

                entity.Property(e => e.FccFecreg)
                    .HasColumnType("date")
                    .HasColumnName("FCC_FECREG")
                    .HasComment("Fecha de registracion para libro de iva... (tomar mes  y ano). Guardar dia 1.");

                entity.Property(e => e.FccImpiin)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPIIN")
                    .HasComment("Impuestos Internos");

                entity.Property(e => e.FccImpiva)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPIVA")
                    .HasComment("Importe IVA ampliado");

                entity.Property(e => e.FccImpivg)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPIVG")
                    .HasComment("Importe iva general");

                entity.Property(e => e.FccImpivr)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPIVR")
                    .HasComment("Importe iva reducido");

                entity.Property(e => e.FccImpnea)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPNEA")
                    .HasComment("Importe Neto IVA ampliado");

                entity.Property(e => e.FccImpneg)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPNEG")
                    .HasComment("Importe neto iva general");

                entity.Property(e => e.FccImpner)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPNER")
                    .HasComment("Importe Neto IVA reducido");

                entity.Property(e => e.FccImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPORT")
                    .HasComment("Importe antes de bonificaciones SIN IVA SIEMPRE");

                entity.Property(e => e.FccImpper)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPPER")
                    .HasComment("Percepciones");

                entity.Property(e => e.FccImpret)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPRET")
                    .HasComment("Retenciones");

                entity.Property(e => e.FccImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("FCC_IMPTOT")
                    .HasComment("Importe total");

                entity.Property(e => e.FccLetra)
                    .HasMaxLength(1)
                    .HasColumnName("FCC_LETRA")
                    .HasComment("Letra de comprobante");

                entity.Property(e => e.FccLeyend)
                    .HasMaxLength(100)
                    .HasColumnName("FCC_LEYEND");

                entity.Property(e => e.FccLugent)
                    .HasMaxLength(45)
                    .HasColumnName("FCC_LUGENT")
                    .HasComment("lugar de entrega");

                entity.Property(e => e.FccNrocai)
                    .HasMaxLength(14)
                    .HasColumnName("FCC_NROCAI")
                    .HasComment("Nro. de CAI");

                entity.Property(e => e.FccNroped)
                    .HasPrecision(12)
                    .HasColumnName("FCC_NROPED")
                    .HasComment("Nro de pedido");

                entity.Property(e => e.FccNropre)
                    .HasPrecision(12)
                    .HasColumnName("FCC_NROPRE")
                    .HasComment("Nro de presupuesto");

                entity.Property(e => e.FccNrorem)
                    .HasPrecision(12)
                    .HasColumnName("FCC_NROREM")
                    .HasComment("Nro de factura");

                entity.Property(e => e.FccObserv)
                    .HasMaxLength(45)
                    .HasColumnName("FCC_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.FccOrdlib)
                    .HasColumnName("FCC_ORDLIB")
                    .HasComment("Orden en Listado p/Archivo");

                entity.Property(e => e.FccValmon)
                    .HasPrecision(6, 3)
                    .HasColumnName("FCC_VALMON")
                    .HasComment("Valor de moneda original");

                entity.Property(e => e.FccVencai)
                    .HasColumnType("date")
                    .HasColumnName("FCC_VENCAI")
                    .HasComment("Vencimiento CAI");

                entity.Property(e => e.FvcNrooco)
                    .HasMaxLength(12)
                    .HasColumnName("FVC_NROOCO")
                    .HasComment("Nro orden de compra");

                entity.HasOne(d => d.FccCodcopNavigation)
                    .WithMany(p => p.Facturascs)
                    .HasForeignKey(d => d.FccCodcop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_facturasc_conceptos1");

                entity.HasOne(d => d.FccCodcpaNavigation)
                    .WithMany(p => p.Facturascs)
                    .HasForeignKey(d => d.FccCodcpa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_facturasc_condpago");

                entity.HasOne(d => d.FccCoddepNavigation)
                    .WithMany(p => p.Facturascs)
                    .HasForeignKey(d => d.FccCoddep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_facturasc_depositos");
            });

            modelBuilder.Entity<FacturascDet>(entity =>
            {
                entity.HasKey(e => new { e.FcdCodcom, e.FcdNrofac, e.FcdCodpro, e.FcdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("facturasc_det");

                entity.HasComment("FAC_NC_ND de vta.  - detalle")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.FcdCodpro, "fk_facturasc_de_tproveedores_idx");

                entity.HasIndex(e => new { e.FcdCodcom, e.FcdNrofac, e.FcdCodpro }, "fk_facturasc_det_facturasc1");

                entity.Property(e => e.FcdCodcom).HasColumnName("FCD_CODCOM");

                entity.Property(e => e.FcdNrofac)
                    .HasPrecision(12)
                    .HasColumnName("FCD_NROFAC");

                entity.Property(e => e.FcdCodpro).HasColumnName("FCD_CODPRO");

                entity.Property(e => e.FcdNrolin)
                    .HasColumnName("FCD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.FcdBonif1)
                    .HasPrecision(11, 2)
                    .HasColumnName("FCD_BONIF1")
                    .HasComment("% Bonificacion 1");

                entity.Property(e => e.FcdBonif2)
                    .HasPrecision(11, 2)
                    .HasColumnName("FCD_BONIF2")
                    .HasComment("% Bonificacion 2");

                entity.Property(e => e.FcdCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("FCD_CANTID")
                    .HasComment("Cantidad ");

                entity.Property(e => e.FcdCodart)
                    .HasMaxLength(15)
                    .HasColumnName("FCD_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.FcdCodori)
                    .HasMaxLength(20)
                    .HasColumnName("FCD_CODORI")
                    .HasComment("Codigo original del articulo");

                entity.Property(e => e.FcdDescri)
                    .HasMaxLength(40)
                    .HasColumnName("FCD_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.FcdEstado)
                    .HasMaxLength(10)
                    .HasColumnName("FCD_ESTADO")
                    .HasComment("Estado de la linea, ABIERTO,CERRADO,ANULADO");

                entity.Property(e => e.FcdImpivg)
                    .HasPrecision(11, 2)
                    .HasColumnName("FCD_IMPIVG")
                    .HasComment("Importe Iva general");

                entity.Property(e => e.FcdImpivr)
                    .HasPrecision(11, 2)
                    .HasColumnName("FCD_IMPIVR")
                    .HasComment("Importe Iva reducido");

                entity.Property(e => e.FcdImpnet)
                    .HasPrecision(11, 2)
                    .HasColumnName("FCD_IMPNET")
                    .HasComment("Importe neto unitario");

                entity.Property(e => e.FcdImptot)
                    .HasPrecision(11, 2)
                    .HasColumnName("FCD_IMPTOT")
                    .HasComment("Importe total unitario");

                entity.Property(e => e.FcdNrolpe)
                    .HasColumnName("FCD_NROLPE")
                    .HasComment("Nro linea de pedido");

                entity.Property(e => e.FcdNrolre)
                    .HasColumnName("FCD_NROLRE")
                    .HasComment("Nro. de linea remito");

                entity.Property(e => e.FcdNroped)
                    .HasPrecision(12)
                    .HasColumnName("FCD_NROPED")
                    .HasComment("Nro. de pedido");

                entity.Property(e => e.FcdNropre)
                    .HasPrecision(12)
                    .HasColumnName("FCD_NROPRE")
                    .HasComment("Nro de presupuesto");

                entity.Property(e => e.FcdNrorem)
                    .HasPrecision(12)
                    .HasColumnName("FCD_NROREM")
                    .HasComment("Nro. de remito");

                entity.Property(e => e.FcdObserv)
                    .HasMaxLength(45)
                    .HasColumnName("FCD_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.FcdPrecio)
                    .HasPrecision(11, 2)
                    .HasColumnName("FCD_PRECIO")
                    .HasComment("Precio unitario");

                entity.Property(e => e.FcdUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("FCD_UNIMED")
                    .HasComment("Unidad de medida");

                entity.Property(e => e.FcdValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("FCD_VALIVA")
                    .HasComment("Alicuota IVA");
            });

            modelBuilder.Entity<Facturasv>(entity =>
            {
                entity.HasKey(e => new { e.FvcCodcom, e.FvcNrofac, e.FvcCoddep, e.FvcCodven, e.FvcCodtra })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

                entity.ToTable("facturasv");

                entity.HasComment("Fac_NC_ND de venta  - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.FvcCodcom)
                    .HasColumnName("FVC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.FvcNrofac)
                    .HasPrecision(12)
                    .HasColumnName("FVC_NROFAC")
                    .HasComment("Numero de Comrobante");

                entity.Property(e => e.FvcCoddep)
                    .HasColumnName("FVC_CODDEP")
                    .HasComment("Codigo de deposito");

                entity.Property(e => e.FvcCodven)
                    .HasColumnName("FVC_CODVEN")
                    .HasComment("Codigo de vendedor");

                entity.Property(e => e.FvcCodtra)
                    .HasColumnName("FVC_CODTRA")
                    .HasComment("Codigo de transportista");

                entity.Property(e => e.FvcAcopio)
                    .HasColumnName("FVC_ACOPIO")
                    .HasComment("Factura de Acopio: 0=NO, 1=Acopio de Dinero, 2:Acopio de mercaderías.");

                entity.Property(e => e.FvcBonif1)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_BONIF1")
                    .HasComment("Bonificacion 1");

                entity.Property(e => e.FvcBonif2)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_BONIF2")
                    .HasComment("bonificacion 2");

                entity.Property(e => e.FvcCodcli)
                    .HasPrecision(6)
                    .HasColumnName("FVC_CODCLI")
                    .HasComment("Cod. de cliente");

                entity.Property(e => e.FvcCodcpa)
                    .HasColumnName("FVC_CODCPA")
                    .HasComment("Codigo condicion de pago");

                entity.Property(e => e.FvcCodlis)
                    .HasColumnName("FVC_CODLIS")
                    .HasComment("Codigo de lista de precios");

                entity.Property(e => e.FvcCodmon)
                    .HasColumnName("FVC_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.FvcCodusu)
                    .HasColumnName("FVC_CODUSU")
                    .HasComment("Codigo de Usuario");

                entity.Property(e => e.FvcDtogen)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_DTOGEN")
                    .HasComment("Importe dto. gral comprobante");

                entity.Property(e => e.FvcDtogep)
                    .HasPrecision(5, 2)
                    .HasColumnName("FVC_DTOGEP")
                    .HasComment("Porcentaje dto. gral.");

                entity.Property(e => e.FvcEstado)
                    .HasMaxLength(10)
                    .HasColumnName("FVC_ESTADO")
                    .HasComment("Estado del pedido ABIERTO, CERRADO, ANULADO,CONTABILIZ");

                entity.Property(e => e.FvcFecfac)
                    .HasColumnType("date")
                    .HasColumnName("FVC_FECFAC")
                    .HasComment("Fecha de comprobante");

                entity.Property(e => e.FvcImpivg)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_IMPIVG")
                    .HasComment("Importe iva general");

                entity.Property(e => e.FvcImpivr)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_IMPIVR")
                    .HasComment("Importe iva reducido");

                entity.Property(e => e.FvcImpneg)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_IMPNEG")
                    .HasComment("Importe neto iva GRAL");

                entity.Property(e => e.FvcImpner)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_IMPNER")
                    .HasComment("Importe neto iva REDUCIDO");

                entity.Property(e => e.FvcImpnog)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_IMPNOG")
                    .HasComment("Importe No Gravado");

                entity.Property(e => e.FvcImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_IMPORT")
                    .HasComment("Importe antes de bonificaciones");

                entity.Property(e => e.FvcImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("FVC_IMPTOT")
                    .HasComment("Importe total");

                entity.Property(e => e.FvcLetra)
                    .HasMaxLength(1)
                    .HasColumnName("FVC_LETRA")
                    .HasComment("Letra de comprobante");

                entity.Property(e => e.FvcLeyend)
                    .HasMaxLength(100)
                    .HasColumnName("FVC_LEYEND");

                entity.Property(e => e.FvcLugent)
                    .HasMaxLength(45)
                    .HasColumnName("FVC_LUGENT")
                    .HasComment("lugar de entrega");

                entity.Property(e => e.FvcNrooco)
                    .HasMaxLength(20)
                    .HasColumnName("FVC_NROOCO")
                    .HasComment("Nro orden de compra");

                entity.Property(e => e.FvcNroped)
                    .HasPrecision(12)
                    .HasColumnName("FVC_NROPED")
                    .HasComment("Nro de pedido");

                entity.Property(e => e.FvcNropre)
                    .HasPrecision(12)
                    .HasColumnName("FVC_NROPRE")
                    .HasComment("Nro de presupuesto");

                entity.Property(e => e.FvcNrorem)
                    .HasPrecision(12)
                    .HasColumnName("FVC_NROREM")
                    .HasComment("Nro de factura");

                entity.Property(e => e.FvcObserv)
                    .HasMaxLength(45)
                    .HasColumnName("FVC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<FacturasvDet>(entity =>
            {
                entity.HasKey(e => new { e.FvdCodcom, e.FvdNrofac, e.FvdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("facturasv_det");

                entity.HasComment("FAC_NC_ND de vta.  - detalle")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.FvdCodcom, e.FvdNrofac }, "fk_facturasv_det_facturasv1");

                entity.Property(e => e.FvdCodcom)
                    .HasColumnName("FVD_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.FvdNrofac)
                    .HasPrecision(12)
                    .HasColumnName("FVD_NROFAC")
                    .HasComment("Nro de factura");

                entity.Property(e => e.FvdNrolin)
                    .HasColumnName("FVD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.FvdBonif1)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_BONIF1")
                    .HasComment("% Bonificacion 1");

                entity.Property(e => e.FvdBonif2)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_BONIF2")
                    .HasComment("% Bonificacion 2");

                entity.Property(e => e.FvdCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_CANTID")
                    .HasComment("Cantidad ");

                entity.Property(e => e.FvdCodart)
                    .HasMaxLength(15)
                    .HasColumnName("FVD_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.FvdDescri)
                    .HasMaxLength(40)
                    .HasColumnName("FVD_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.FvdEstado)
                    .HasMaxLength(10)
                    .HasColumnName("FVD_ESTADO")
                    .HasComment("Estado de la linea, ABIERTO,CERRADO,ANULADO");

                entity.Property(e => e.FvdImpivg)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_IMPIVG")
                    .HasComment("Importe Iva general");

                entity.Property(e => e.FvdImpivr)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_IMPIVR")
                    .HasComment("Importe Iva reducido");

                entity.Property(e => e.FvdImpnet)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_IMPNET")
                    .HasComment("Importe neto unitario");

                entity.Property(e => e.FvdImpnog)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_IMPNOG")
                    .HasComment("Importe No Gravado");

                entity.Property(e => e.FvdImptot)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_IMPTOT")
                    .HasComment("Importe total unitario");

                entity.Property(e => e.FvdLinaco)
                    .HasColumnName("FVD_LINACO")
                    .HasComment("Linea del acondicionamiento");

                entity.Property(e => e.FvdNrolpe)
                    .HasColumnName("FVD_NROLPE")
                    .HasComment("Nro linea de pedido");

                entity.Property(e => e.FvdNrolre)
                    .HasColumnName("FVD_NROLRE")
                    .HasComment("Nro. de linea remito");

                entity.Property(e => e.FvdNroped)
                    .HasPrecision(12)
                    .HasColumnName("FVD_NROPED")
                    .HasComment("Nro. de pedido");

                entity.Property(e => e.FvdNropre)
                    .HasPrecision(12)
                    .HasColumnName("FVD_NROPRE")
                    .HasComment("Nro de presupuesto");

                entity.Property(e => e.FvdNrorem)
                    .HasPrecision(12)
                    .HasColumnName("FVD_NROREM")
                    .HasComment("Nro. de remito");

                entity.Property(e => e.FvdObserv)
                    .HasMaxLength(45)
                    .HasColumnName("FVD_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.FvdPrecio)
                    .HasPrecision(11, 2)
                    .HasColumnName("FVD_PRECIO")
                    .HasComment("Precio unitario");

                entity.Property(e => e.FvdUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("FVD_UNIMED")
                    .HasComment("Unidad de medida");

                entity.Property(e => e.FvdValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("FVD_VALIVA")
                    .HasComment("Alicuota de IVA");
            });

            modelBuilder.Entity<Familia>(entity =>
            {
                entity.HasKey(e => e.FamCodfam)
                    .HasName("PRIMARY");

                entity.ToTable("familias");

                entity.HasComment("Familias p/art. desplegables")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.FamCodfam)
                    .ValueGeneratedNever()
                    .HasColumnName("FAM_CODFAM")
                    .HasComment("Codigo de grupo");

                entity.Property(e => e.FamDescri)
                    .HasMaxLength(30)
                    .HasColumnName("FAM_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.FamObserv)
                    .HasMaxLength(45)
                    .HasColumnName("FAM_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<FamiliasDet>(entity =>
            {
                entity.HasKey(e => new { e.FadCodfam, e.FadCoddet })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("familias_det");

                entity.HasComment("Detalle de familias")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.FadCodfam, "fk_grupos_det_grupos1_idx");

                entity.Property(e => e.FadCodfam)
                    .HasColumnName("FAD_CODFAM")
                    .HasComment("Codigo de grupo");

                entity.Property(e => e.FadCoddet)
                    .HasMaxLength(3)
                    .HasColumnName("FAD_CODDET")
                    .HasDefaultValueSql("''")
                    .HasComment("Codigo detalle grupo (se agrega a ART_CODART)");

                entity.Property(e => e.FadDesabr)
                    .HasMaxLength(6)
                    .HasColumnName("FAD_DESABR")
                    .HasComment("Descripción abreviada");

                entity.Property(e => e.FadDescri)
                    .HasMaxLength(20)
                    .HasColumnName("FAD_DESCRI")
                    .HasComment("Descripción de detalle");

                entity.Property(e => e.FadIdweb)
                    .HasColumnName("FAD_IDWEB")
                    .HasComment("id Color E Commerce");

                entity.Property(e => e.FadObserv)
                    .HasMaxLength(45)
                    .HasColumnName("FAD_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.FadCodfamNavigation)
                    .WithMany(p => p.FamiliasDets)
                    .HasForeignKey(d => d.FadCodfam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_grupos_det_grupos1");
            });

            modelBuilder.Entity<ImprComp>(entity =>
            {
                entity.HasKey(e => new { e.IycCodpue, e.IycCodcom })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("impr_comp");

                entity.HasComment("Impresion de comprobantes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.IycCodcom, "fk_impresion_comprobantes1");

                entity.HasIndex(e => e.IycCodpue, "fk_impresion_puestos1");

                entity.Property(e => e.IycCodpue)
                    .HasColumnName("IYC_CODPUE")
                    .HasComment("Codigo de puesto");

                entity.Property(e => e.IycCodcom)
                    .HasColumnName("IYC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.IycCopiasNo)
                    .HasColumnName("IYC_COPIAS_NO")
                    .HasComment("Cantidad de copias");

                entity.Property(e => e.IycDesimp)
                    .HasMaxLength(50)
                    .HasColumnName("IYC_DESIMP")
                    .HasComment("Descripción de la impresora");

                entity.Property(e => e.IycReport)
                    .HasMaxLength(15)
                    .HasColumnName("IYC_REPORT")
                    .HasComment("Nombre del reporte (si tengo diseños distintos para un comprobante, puedo indicarlo aca)");

                entity.HasOne(d => d.IycCodcomNavigation)
                    .WithMany(p => p.ImprComps)
                    .HasForeignKey(d => d.IycCodcom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_impresion_comprobantes1");

                entity.HasOne(d => d.IycCodpueNavigation)
                    .WithMany(p => p.ImprComps)
                    .HasForeignKey(d => d.IycCodpue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_impresion_puestos1");
            });

            modelBuilder.Entity<ImpresorasNo>(entity =>
            {
                entity.HasKey(e => e.ImpCodimp)
                    .HasName("PRIMARY");

                entity.ToTable("impresoras_no");

                entity.HasComment("Impresora y Puestos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.ImpCodimp)
                    .ValueGeneratedNever()
                    .HasColumnName("IMP_CODIMP")
                    .HasComment("Codigo de impresora");

                entity.Property(e => e.ImpDesimp)
                    .HasMaxLength(30)
                    .HasColumnName("IMP_DESIMP")
                    .HasComment("Descripcion impresora");

                entity.Property(e => e.ImpUrlimp)
                    .HasMaxLength(60)
                    .HasColumnName("IMP_URLIMP")
                    .HasComment("Direccion de la impresora en la red");
            });

            modelBuilder.Entity<Iva>(entity =>
            {
                entity.HasKey(e => e.IvaCodiva)
                    .HasName("PRIMARY");

                entity.ToTable("iva");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.IvaCodiva)
                    .ValueGeneratedNever()
                    .HasColumnName("IVA_CODIVA")
                    .HasComment("Id iva");

                entity.Property(e => e.IvaDescri)
                    .HasMaxLength(30)
                    .HasColumnName("IVA_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.IvaValiva)
                    .HasPrecision(4, 2)
                    .HasColumnName("IVA_VALIVA")
                    .HasComment("Porcentaje iva");
            });

            modelBuilder.Entity<Linea>(entity =>
            {
                entity.HasKey(e => e.LinCodlin)
                    .HasName("PRIMARY");

                entity.ToTable("lineas");

                entity.HasComment("Lineas de artículos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.LinCodlin)
                    .HasMaxLength(4)
                    .HasColumnName("LIN_CODLIN")
                    .HasComment("Codigo de línea");

                entity.Property(e => e.LinActiva)
                    .HasColumnName("LIN_ACTIVA")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Activo");

                entity.Property(e => e.LinDescri)
                    .HasMaxLength(30)
                    .HasColumnName("LIN_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.LinDivweb)
                    .HasColumnName("LIN_DIVWEB")
                    .HasComment("Division Web 1 Electricidad - 2 Iluminacion");

                entity.Property(e => e.LinObserv)
                    .HasMaxLength(45)
                    .HasColumnName("LIN_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<Listapre>(entity =>
            {
                entity.HasKey(e => e.LipCodlis)
                    .HasName("PRIMARY");

                entity.ToTable("listapre");

                entity.HasComment("Listas de precios")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.LipCodmon, "fk_precios_c_monedas1");

                entity.Property(e => e.LipCodlis)
                    .ValueGeneratedNever()
                    .HasColumnName("LIP_CODLIS")
                    .HasComment("Codigo de lista");

                entity.Property(e => e.LipCodmon)
                    .HasColumnName("LIP_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.LipContimp)
                    .HasColumnName("LIP_CONTIMP")
                    .HasComment("Contiene impuestos");

                entity.Property(e => e.LipContiva)
                    .HasColumnName("LIP_CONTIVA")
                    .HasComment("Contiene IVA");

                entity.Property(e => e.LipFdesde)
                    .HasColumnType("date")
                    .HasColumnName("LIP_FDESDE")
                    .HasComment("Fecha desde");

                entity.Property(e => e.LipFhasta)
                    .HasColumnType("date")
                    .HasColumnName("LIP_FHASTA")
                    .HasComment("Fecha hasta");

                entity.Property(e => e.LipNombre)
                    .HasMaxLength(45)
                    .HasColumnName("LIP_NOMBRE")
                    .HasComment("Nombre");

                entity.Property(e => e.LipVigente)
                    .HasColumnName("LIP_VIGENTE")
                    .HasComment("Vigente");

                entity.HasOne(d => d.LipCodmonNavigation)
                    .WithMany(p => p.Listapres)
                    .HasForeignKey(d => d.LipCodmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_precios_c_monedas1");
            });

            modelBuilder.Entity<Lisyreg>(entity =>
            {
                entity.HasKey(e => new { e.LyrCodlis, e.LyrCodreg })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("lisyreg");

                entity.HasComment("Listas y Reglas de precios (relacion)")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.LyrCodreg, "fk_LISYREG_REGLAPRE1");

                entity.Property(e => e.LyrCodlis).HasColumnName("LYR_CODLIS");

                entity.Property(e => e.LyrCodreg).HasColumnName("LYR_CODREG");

                entity.HasOne(d => d.LyrCodlisNavigation)
                    .WithMany(p => p.Lisyregs)
                    .HasForeignKey(d => d.LyrCodlis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_LISYREG_LISTAPRE1");

                entity.HasOne(d => d.LyrCodregNavigation)
                    .WithMany(p => p.Lisyregs)
                    .HasForeignKey(d => d.LyrCodreg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_LISYREG_REGLAPRE1");
            });

            modelBuilder.Entity<Localidade>(entity =>
            {
                entity.HasKey(e => e.LocCodloc)
                    .HasName("PRIMARY");

                entity.ToTable("localidades");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.LocCodloc, "localid_pk")
                    .IsUnique();

                entity.Property(e => e.LocCodloc)
                    .HasPrecision(5)
                    .HasColumnName("LOC_CODLOC");

                entity.Property(e => e.LocCodpos)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("LOC_CODPOS");

                entity.Property(e => e.LocCodprv)
                    .HasPrecision(3)
                    .HasColumnName("LOC_CODPRV");

                entity.Property(e => e.LocDescri)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("LOC_DESCRI");

                entity.Property(e => e.LocObserv)
                    .HasMaxLength(50)
                    .HasColumnName("LOC_OBSERV");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.MarCodmar)
                    .HasName("PRIMARY");

                entity.ToTable("marcas");

                entity.HasComment("Marcas")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.MarIdweb, "IdWeb")
                    .IsUnique();

                entity.Property(e => e.MarCodmar)
                    .HasMaxLength(15)
                    .HasColumnName("MAR_CODMAR")
                    .HasComment("Codigo de marca");

                entity.Property(e => e.MarActivo)
                    .HasColumnName("MAR_ACTIVO")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Activo");

                entity.Property(e => e.MarDescri)
                    .HasMaxLength(30)
                    .HasColumnName("MAR_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.MarIdweb)
                    .HasColumnName("MAR_IDWEB")
                    .HasComment("Id Web");

                entity.Property(e => e.MarObserv)
                    .HasMaxLength(45)
                    .HasColumnName("MAR_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<Mediopago>(entity =>
            {
                entity.HasKey(e => e.MpaCodmpa)
                    .HasName("PRIMARY");

                entity.ToTable("mediopago");

                entity.HasComment("Medios de pago")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.MpaCodmpa)
                    .ValueGeneratedNever()
                    .HasColumnName("MPA_CODMPA");

                entity.Property(e => e.MpaAbrevi)
                    .HasMaxLength(8)
                    .HasColumnName("MPA_ABREVI");

                entity.Property(e => e.MpaCodmon)
                    .HasColumnName("MPA_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.MpaCuenta)
                    .HasMaxLength(15)
                    .HasColumnName("MPA_CUENTA")
                    .HasComment("Cuenta Contable");

                entity.Property(e => e.MpaDescri)
                    .HasMaxLength(30)
                    .HasColumnName("MPA_DESCRI");

                entity.Property(e => e.MpaTipo)
                    .HasMaxLength(10)
                    .HasColumnName("MPA_TIPO")
                    .HasComment("Ingreso,egreso,ambos");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.MenCodmen)
                    .HasName("PRIMARY");

                entity.ToTable("menu");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.MenCodmen)
                    .HasColumnName("MEN_CODMEN")
                    .HasComment("Id Menu");

                entity.Property(e => e.MenFormul)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_FORMUL")
                    .HasComment("Formulario que llama");

                entity.Property(e => e.MenMenord)
                    .HasColumnName("MEN_MENORD")
                    .HasComment("Orden Menu");

                entity.Property(e => e.MenMenu)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_MENU")
                    .HasComment("Nombre Menu");

                entity.Property(e => e.MenObserv)
                    .HasColumnName("MEN_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.MenSbmord)
                    .HasColumnName("MEN_SBMORD")
                    .HasComment("Orden Submenu");

                entity.Property(e => e.MenSsbmen)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_SSBMEN")
                    .HasComment("Nombre Sub Submenu");

                entity.Property(e => e.MenSsbord)
                    .HasColumnName("MEN_SSBORD")
                    .HasComment("Orden Sub Submenu");

                entity.Property(e => e.MenSubmen)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_SUBMEN")
                    .HasComment("Nombre Submenu");
                
                entity.Property(e => e.MenController)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_CONTROLLER")
                    .HasComment("Nombre de Controlador");
                
                entity.Property(e => e.MenAction)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_ACTION")
                    .HasComment("Nombre Nombre de Action");
            });

            modelBuilder.Entity<MenuBak>(entity =>
            {
                entity.HasKey(e => e.MenCodmen)
                    .HasName("PRIMARY");

                entity.ToTable("menu_bak");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.MenCodmen)
                    .HasColumnName("MEN_CODMEN")
                    .HasComment("Id Menu");

                entity.Property(e => e.MenFormul)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_FORMUL")
                    .HasComment("Formulario que llama");

                entity.Property(e => e.MenMenord)
                    .HasColumnName("MEN_MENORD")
                    .HasComment("Orden Menu");

                entity.Property(e => e.MenMenu)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_MENU")
                    .HasComment("Nombre Menu");

                entity.Property(e => e.MenObserv)
                    .HasColumnName("MEN_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.MenSbmord)
                    .HasColumnName("MEN_SBMORD")
                    .HasComment("Orden Submenu");

                entity.Property(e => e.MenSsbmen)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_SSBMEN")
                    .HasComment("Nombre Sub Submenu");

                entity.Property(e => e.MenSsbord)
                    .HasColumnName("MEN_SSBORD")
                    .HasComment("Orden Sub Submenu");

                entity.Property(e => e.MenSubmen)
                    .HasMaxLength(45)
                    .HasColumnName("MEN_SUBMEN")
                    .HasComment("Nombre Submenu");
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.HasKey(e => e.MonCodmon)
                    .HasName("PRIMARY");

                entity.ToTable("monedas");

                entity.HasComment("Monedas")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.MonCodmon)
                    .ValueGeneratedNever()
                    .HasColumnName("MON_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.MonCodafi)
                    .HasMaxLength(3)
                    .HasColumnName("MON_CODAFI")
                    .HasComment("Codigo Afip");

                entity.Property(e => e.MonDescri)
                    .HasMaxLength(15)
                    .HasColumnName("MON_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.MonSigmon)
                    .HasMaxLength(3)
                    .HasColumnName("MON_SIGMON")
                    .HasComment("Signo de la moneda");

                entity.Property(e => e.MonValmon)
                    .HasPrecision(5, 2)
                    .HasColumnName("MON_VALMON")
                    .HasComment("Valor");
            });

            modelBuilder.Entity<MonedasH>(entity =>
            {
                entity.ToTable("monedas_h");

                entity.HasComment("Historico de monedas")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Id de la operacion");

                entity.Property(e => e.MonCodafi)
                    .HasMaxLength(3)
                    .HasColumnName("MON_CODAFI")
                    .HasComment("Codigo Afip");

                entity.Property(e => e.MonCodmon)
                    .HasColumnName("MON_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.MonFecope)
                    .HasColumnType("timestamp")
                    .HasColumnName("MON_FECOPE")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Fecha de la operación");

                entity.Property(e => e.MonNomusu)
                    .HasMaxLength(15)
                    .HasColumnName("MON_NOMUSU")
                    .HasComment("Usuario");

                entity.Property(e => e.MonOperac)
                    .HasMaxLength(3)
                    .HasColumnName("MON_OPERAC")
                    .HasComment("Tipo de operación");

                entity.Property(e => e.MonValmon)
                    .HasPrecision(5, 2)
                    .HasColumnName("MON_VALMON")
                    .HasComment("Valor");
            });

            modelBuilder.Entity<MovCaja>(entity =>
            {
                entity.HasKey(e => e.MocId)
                    .HasName("PRIMARY");

                entity.ToTable("mov_caja");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.MocCodcaj, "fk_mov_caja");

                entity.Property(e => e.MocId)
                    .HasColumnName("MOC_ID")
                    .HasComment("Id movimiento");

                entity.Property(e => e.MocCodcaj).HasColumnName("MOC_CODCAJ");

                entity.Property(e => e.MocFecmov)
                    .HasColumnType("date")
                    .HasColumnName("MOC_FECMOV")
                    .HasComment("Fecha del movimiento");

                entity.Property(e => e.MocFehoap)
                    .HasColumnType("datetime")
                    .HasColumnName("MOC_FEHOAP")
                    .HasComment("Fecha hora de apertura");

                entity.Property(e => e.MocFehoci)
                    .HasColumnType("datetime")
                    .HasColumnName("MOC_FEHOCI")
                    .HasComment("Fecha hora de cierre");

                entity.Property(e => e.MocObserv)
                    .HasMaxLength(45)
                    .HasColumnName("MOC_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.MocSalfin)
                    .HasPrecision(13, 2)
                    .HasColumnName("MOC_SALFIN")
                    .HasComment("Saldo final (de arrastre)");

                entity.Property(e => e.MocSalini)
                    .HasPrecision(13, 2)
                    .HasColumnName("MOC_SALINI")
                    .HasComment("Saldo inicial (de arrastre)");

                entity.Property(e => e.MocUsuape)
                    .HasMaxLength(10)
                    .HasColumnName("MOC_USUAPE")
                    .HasComment("usuario apertura");

                entity.Property(e => e.MocUsucie)
                    .HasMaxLength(10)
                    .HasColumnName("MOC_USUCIE")
                    .HasComment("Usuario cierre");

                entity.HasOne(d => d.MocCodcajNavigation)
                    .WithMany(p => p.MovCajas)
                    .HasForeignKey(d => d.MocCodcaj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mov_caja_cajas1");
            });

            modelBuilder.Entity<MovCajadet>(entity =>
            {
                entity.HasKey(e => e.ModId)
                    .HasName("PRIMARY");

                entity.ToTable("mov_cajadet");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ModMocid, "fk_mov_cajadet");

                entity.HasIndex(e => e.ModCodcop, "fk_mov_cajadet1");

                entity.Property(e => e.ModId)
                    .HasColumnName("MOD_ID")
                    .HasComment("Id Movimiento");

                entity.Property(e => e.ModCodcop)
                    .HasColumnName("MOD_CODCOP")
                    .HasComment("Codigo de concepto de movimiento");

                entity.Property(e => e.ModDebe)
                    .HasPrecision(13, 2)
                    .HasColumnName("MOD_DEBE")
                    .HasComment("Debe - Ingresos");

                entity.Property(e => e.ModDescri)
                    .HasMaxLength(45)
                    .HasColumnName("MOD_DESCRI")
                    .HasComment("Descripción del movimiento");

                entity.Property(e => e.ModFehomo)
                    .HasColumnType("timestamp")
                    .HasColumnName("MOD_FEHOMO")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Fecha Hora del movimiento");

                entity.Property(e => e.ModHaber)
                    .HasPrecision(13, 2)
                    .HasColumnName("MOD_HABER")
                    .HasComment("Haber - egresos");

                entity.Property(e => e.ModMocid)
                    .HasColumnName("MOD_MOCID")
                    .HasComment("Id cabecera");

                entity.Property(e => e.ModObserv)
                    .HasMaxLength(45)
                    .HasColumnName("MOD_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.ModCodcopNavigation)
                    .WithMany(p => p.MovCajadets)
                    .HasForeignKey(d => d.ModCodcop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mov_cajadet_conceptos1");

                entity.HasOne(d => d.ModMoc)
                    .WithMany(p => p.MovCajadets)
                    .HasForeignKey(d => d.ModMocid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mov_cajadet_mov_caja1");
            });

            modelBuilder.Entity<Movstock>(entity =>
            {
                entity.HasKey(e => e.MosCodmov)
                    .HasName("PRIMARY");

                entity.ToTable("movstock");

                entity.HasComment("Movimientos de stock")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.MosCodmov)
                    .ValueGeneratedNever()
                    .HasColumnName("MOS_CODMOV")
                    .HasComment("codigo de movimiento");

                entity.Property(e => e.MosConcep)
                    .HasMaxLength(1)
                    .HasColumnName("MOS_CONCEP")
                    .HasComment("Concepto: E=entrada, S=salida");

                entity.Property(e => e.MosDescri)
                    .HasMaxLength(30)
                    .HasColumnName("MOS_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.MosObserv)
                    .HasMaxLength(30)
                    .HasColumnName("MOS_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.MosTipmov)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("MOS_TIPMOV")
                    .HasDefaultValueSql("'A'")
                    .HasComment("Tipo de movimiento M=manual o A=automatico");
            });

            modelBuilder.Entity<NovedadesCliente>(entity =>
            {
                entity.HasKey(e => e.NovCodnov)
                    .HasName("PRIMARY");

                entity.ToTable("novedades_clientes");

                entity.HasComment("Novedades para clientes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.NovCodcli, "fk_novedades_cli_clientes1");

                entity.Property(e => e.NovCodnov)
                    .HasColumnName("NOV_CODNOV")
                    .HasComment("Id novedad");

                entity.Property(e => e.NovActiva)
                    .HasColumnName("NOV_ACTIVA")
                    .HasComment("Si esta activa...0=NO,1=SI");

                entity.Property(e => e.NovCodcli)
                    .HasPrecision(6)
                    .HasColumnName("NOV_CODCLI")
                    .HasComment("Codigo de cliente");

                entity.Property(e => e.NovDescri)
                    .HasMaxLength(100)
                    .HasColumnName("NOV_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.NovFecnot)
                    .HasColumnType("date")
                    .HasColumnName("NOV_FECNOT")
                    .HasComment("Fecha de notificacion");

                entity.Property(e => e.NovFecnov)
                    .HasColumnType("date")
                    .HasColumnName("NOV_FECNOV")
                    .HasComment("Fecha de carga");

                entity.HasOne(d => d.NovCodcliNavigation)
                    .WithMany(p => p.NovedadesClientes)
                    .HasForeignKey(d => d.NovCodcli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_novedade_cli_clientes1");
            });

            modelBuilder.Entity<NovedadesProveed>(entity =>
            {
                entity.HasKey(e => e.NovCodnov)
                    .HasName("PRIMARY");

                entity.ToTable("novedades_proveed");

                entity.HasComment("Novedades para clientes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.NovCodpro, "fk_novedades_proveed1");

                entity.Property(e => e.NovCodnov)
                    .HasColumnName("NOV_CODNOV")
                    .HasComment("Id novedad");

                entity.Property(e => e.NovActiva)
                    .HasColumnName("NOV_ACTIVA")
                    .HasComment("Si esta activa...0=NO,1=SI");

                entity.Property(e => e.NovCodpro)
                    .HasColumnName("NOV_CODPRO")
                    .HasComment("Id. Proveedor");

                entity.Property(e => e.NovDescri)
                    .HasMaxLength(100)
                    .HasColumnName("NOV_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.NovFecnot)
                    .HasColumnType("date")
                    .HasColumnName("NOV_FECNOT")
                    .HasComment("Fecha de notificacion");

                entity.Property(e => e.NovFecnov)
                    .HasColumnType("date")
                    .HasColumnName("NOV_FECNOV")
                    .HasComment("Fecha de carga");

                entity.HasOne(d => d.NovCodproNavigation)
                    .WithMany(p => p.NovedadesProveeds)
                    .HasForeignKey(d => d.NovCodpro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_novedades_proveed_proveedores1");
            });

            modelBuilder.Entity<Pagosccc>(entity =>
            {
                entity.HasKey(e => new { e.PfcCodcom, e.PfcNrorec, e.PfcCodpro })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("pagosccc");

                entity.HasComment("Cabecera de pagos cta cte")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PfcCodcom)
                    .HasColumnName("PFC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.PfcNrorec)
                    .HasPrecision(12)
                    .HasColumnName("PFC_NROREC")
                    .HasComment("Nro de recibo");

                entity.Property(e => e.PfcCodpro)
                    .HasPrecision(6)
                    .HasColumnName("PFC_CODPRO");

                entity.Property(e => e.PfcEstado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PFC_ESTADO")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PfcFecimp)
                    .HasColumnType("date")
                    .HasColumnName("PFC_FECIMP")
                    .HasComment("Fecha de imputacion de caja");

                entity.Property(e => e.PfcFecpag)
                    .HasColumnType("date")
                    .HasColumnName("PFC_FECPAG")
                    .HasComment("Fecha de pago");

                entity.Property(e => e.PfcImpche)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPCHE")
                    .HasComment("Importe Cheques");

                entity.Property(e => e.PfcImpefe)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPEFE")
                    .HasComment("Importe efectivo");

                entity.Property(e => e.PfcImpret)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPRET")
                    .HasComment("Importe retenciones");

                entity.Property(e => e.PfcImptar)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPTAR")
                    .HasComment("Importe tarjeta");

                entity.Property(e => e.PfcImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPTOT");

                entity.Property(e => e.PfcImptra)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPTRA")
                    .HasComment("Importe Transferencia");

                entity.Property(e => e.PfcNrocuo)
                    .HasColumnName("PFC_NROCUO")
                    .HasComment("Nro cuota");

                entity.Property(e => e.PfcNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PFC_NROFAC")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.PfcObserv)
                    .HasMaxLength(50)
                    .HasColumnName("PFC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<PagoscccDet>(entity =>
            {
                entity.HasKey(e => new { e.PfdCodcom, e.PfdNrorec, e.PfdCodpro, e.PfdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("pagosccc_det");

                entity.HasComment("Detalle de pago cuenta corriente")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.PfdCodcom, e.PfdNrorec, e.PfdCodpro }, "fk_pagosccc_det_pagosccc1");

                entity.Property(e => e.PfdCodcom).HasColumnName("PFD_CODCOM");

                entity.Property(e => e.PfdNrorec)
                    .HasPrecision(12)
                    .HasColumnName("PFD_NROREC");

                entity.Property(e => e.PfdCodpro)
                    .HasPrecision(6)
                    .HasColumnName("PFD_CODPRO");

                entity.Property(e => e.PfdNrolin)
                    .HasColumnName("PFD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.PfdAgrupa)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("PFD_AGRUPA")
                    .HasDefaultValueSql("''")
                    .HasComment("Agrupamiento (para ordenes de pago)");

                entity.Property(e => e.PfdCodmpa)
                    .HasColumnName("PFD_CODMPA")
                    .HasComment("Codigo de medio de pago");

                entity.Property(e => e.PfdDescri)
                    .HasMaxLength(50)
                    .HasColumnName("PFD_DESCRI");

                entity.Property(e => e.PfdFecimp)
                    .HasColumnType("date")
                    .HasColumnName("PFD_FECIMP")
                    .HasComment("Fecha de imputacion de caja");

                entity.Property(e => e.PfdFecpag)
                    .HasColumnType("date")
                    .HasColumnName("PFD_FECPAG")
                    .HasComment("Fecha de pago");

                entity.Property(e => e.PfdImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFD_IMPORT")
                    .HasComment("Importe");

                entity.Property(e => e.PfdNrocom)
                    .HasPrecision(12)
                    .HasColumnName("PFD_NROCOM")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.PfdObserv)
                    .HasMaxLength(50)
                    .HasColumnName("PFD_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.Pfd)
                    .WithMany(p => p.PagoscccDets)
                    .HasForeignKey(d => new { d.PfdCodcom, d.PfdNrorec, d.PfdCodpro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pagosccc_det_pagosccc1");
            });

            modelBuilder.Entity<Pagosccv>(entity =>
            {
                entity.HasKey(e => new { e.PfcCodcom, e.PfcNrorec })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pagosccv");

                entity.HasComment("Cabecera de pagos cta cte")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PfcCodcom)
                    .HasColumnName("PFC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.PfcNrorec)
                    .HasPrecision(12)
                    .HasColumnName("PFC_NROREC")
                    .HasComment("Nro de recibo");

                entity.Property(e => e.PfcCodcli)
                    .HasPrecision(6)
                    .HasColumnName("PFC_CODCLI");

                entity.Property(e => e.PfcCodusu)
                    .HasColumnName("PFC_CODUSU")
                    .HasComment("Codigo Operador");

                entity.Property(e => e.PfcEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PFC_ESTADO")
                    .HasComment("ANULADO o VACIO");

                entity.Property(e => e.PfcFecimp)
                    .HasColumnType("date")
                    .HasColumnName("PFC_FECIMP")
                    .HasComment("Fecha de imputacion de caja");

                entity.Property(e => e.PfcFecpag)
                    .HasColumnType("date")
                    .HasColumnName("PFC_FECPAG")
                    .HasComment("Fecha de pago");

                entity.Property(e => e.PfcImpche)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPCHE")
                    .HasComment("Importe Cheques");

                entity.Property(e => e.PfcImpefe)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPEFE")
                    .HasComment("Importe efectivo");

                entity.Property(e => e.PfcImpret)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPRET")
                    .HasComment("Importe retenciones");

                entity.Property(e => e.PfcImptar)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPTAR")
                    .HasComment("Importe tarjeta");

                entity.Property(e => e.PfcImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPTOT");

                entity.Property(e => e.PfcImptra)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFC_IMPTRA")
                    .HasComment("Importe Transferencia");

                entity.Property(e => e.PfcIngcaj)
                    .HasColumnName("PFC_INGCAJ")
                    .HasComment("Ingreso en caja");

                entity.Property(e => e.PfcNrocuo)
                    .HasColumnName("PFC_NROCUO")
                    .HasComment("Nro cuota");

                entity.Property(e => e.PfcNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PFC_NROFAC")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.PfcObserv)
                    .HasMaxLength(50)
                    .HasColumnName("PFC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<PagosccvDet>(entity =>
            {
                entity.HasKey(e => new { e.PfdCodcom, e.PfdNrorec, e.PfdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("pagosccv_det");

                entity.HasComment("Detalle de pago cuenta corriente")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.PfdCodcom, e.PfdNrorec }, "fk_pagosccv_det_pagosccv1");

                entity.Property(e => e.PfdCodcom).HasColumnName("PFD_CODCOM");

                entity.Property(e => e.PfdNrorec)
                    .HasPrecision(12)
                    .HasColumnName("PFD_NROREC");

                entity.Property(e => e.PfdNrolin)
                    .HasColumnName("PFD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.PfdCodmpa)
                    .HasColumnName("PFD_CODMPA")
                    .HasComment("Codigo de medio de pago");

                entity.Property(e => e.PfdDescri)
                    .HasMaxLength(50)
                    .HasColumnName("PFD_DESCRI");

                entity.Property(e => e.PfdFecimp)
                    .HasColumnType("date")
                    .HasColumnName("PFD_FECIMP")
                    .HasComment("Fecha de imputacion de caja");

                entity.Property(e => e.PfdFecpag)
                    .HasColumnType("date")
                    .HasColumnName("PFD_FECPAG")
                    .HasComment("Fecha de pago");

                entity.Property(e => e.PfdImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("PFD_IMPORT")
                    .HasComment("Importe");

                entity.Property(e => e.PfdNrocom)
                    .HasPrecision(12)
                    .HasColumnName("PFD_NROCOM")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.PfdObserv)
                    .HasMaxLength(50)
                    .HasColumnName("PFD_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.Pfd)
                    .WithMany(p => p.PagosccvDets)
                    .HasForeignKey(d => new { d.PfdCodcom, d.PfdNrorec })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pagosccv_det_pagosccv1");
            });

            modelBuilder.Entity<Pagoscoc>(entity =>
            {
                entity.HasKey(e => new { e.PccCodcom, e.PccNrofac, e.PccCodpro })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("pagoscoc");

                entity.HasComment("Cabecera de pagos contado compras\n")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PccCodcom)
                    .HasColumnName("PCC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.PccNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PCC_NROFAC")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.PccCodpro)
                    .HasPrecision(6)
                    .HasColumnName("PCC_CODPRO");

                entity.Property(e => e.PccEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PCC_ESTADO");

                entity.Property(e => e.PccFecimp)
                    .HasColumnType("date")
                    .HasColumnName("PCC_FECIMP")
                    .HasComment("Fecha de imputacion de caja");

                entity.Property(e => e.PccFecpag)
                    .HasColumnType("date")
                    .HasColumnName("PCC_FECPAG")
                    .HasComment("Fecha de pago");

                entity.Property(e => e.PccImpche)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPCHE")
                    .HasComment("Importe Cheques");

                entity.Property(e => e.PccImpefe)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPEFE")
                    .HasComment("Importe efectivo");

                entity.Property(e => e.PccImpret)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPRET")
                    .HasComment("Importe retenciones");

                entity.Property(e => e.PccImptar)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPTAR")
                    .HasComment("Importe tarjeta");

                entity.Property(e => e.PccImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPTOT");

                entity.Property(e => e.PccImptra)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPTRA")
                    .HasComment("Importe Transferencia");

                entity.Property(e => e.PccObserv)
                    .HasMaxLength(50)
                    .HasColumnName("PCC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<PagoscocDet>(entity =>
            {
                entity.HasKey(e => new { e.PcdCodcom, e.PcdNrofac, e.PcdCodpro, e.PcdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("pagoscoc_det");

                entity.HasComment("Detalle de medios de pago")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.PcdCodcom, e.PcdNrofac, e.PcdCodpro }, "fk_pagoscoc_det_pagoscoc1");

                entity.Property(e => e.PcdCodcom).HasColumnName("PCD_CODCOM");

                entity.Property(e => e.PcdNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PCD_NROFAC");

                entity.Property(e => e.PcdCodpro)
                    .HasPrecision(6)
                    .HasColumnName("PCD_CODPRO");

                entity.Property(e => e.PcdNrolin)
                    .HasColumnName("PCD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.PcdCodmpa)
                    .HasColumnName("PCD_CODMPA")
                    .HasComment("Codigo de medio de pago");

                entity.Property(e => e.PcdDescri)
                    .HasMaxLength(50)
                    .HasColumnName("PCD_DESCRI");

                entity.Property(e => e.PcdFecimp)
                    .HasColumnType("date")
                    .HasColumnName("PCD_FECIMP")
                    .HasComment("Fecha de imputacion de caja");

                entity.Property(e => e.PcdFecpag)
                    .HasColumnType("date")
                    .HasColumnName("PCD_FECPAG")
                    .HasComment("Fecha de pago");

                entity.Property(e => e.PcdImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCD_IMPORT")
                    .HasComment("Importe");

                entity.Property(e => e.PcdNrocom)
                    .HasPrecision(15)
                    .HasColumnName("PCD_NROCOM")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.PcdObserv)
                    .HasMaxLength(50)
                    .HasColumnName("PCD_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.Pcd)
                    .WithMany(p => p.PagoscocDets)
                    .HasForeignKey(d => new { d.PcdCodcom, d.PcdNrofac, d.PcdCodpro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pagoscoc_det_pagoscoc1");
            });

            modelBuilder.Entity<Pagoscov>(entity =>
            {
                entity.HasKey(e => new { e.PccCodcom, e.PccNrofac })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pagoscov");

                entity.HasComment("Cabecera de pagos contado")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PccCodcom)
                    .HasColumnName("PCC_CODCOM")
                    .HasComment("Codigo de comprobante");

                entity.Property(e => e.PccNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PCC_NROFAC")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.PccCodusu)
                    .HasColumnName("PCC_CODUSU")
                    .HasComment("Codigo Operador");

                entity.Property(e => e.PccEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PCC_ESTADO");

                entity.Property(e => e.PccFecimp)
                    .HasColumnType("date")
                    .HasColumnName("PCC_FECIMP")
                    .HasComment("Fecha de imputacion de caja");

                entity.Property(e => e.PccFecpag)
                    .HasColumnType("date")
                    .HasColumnName("PCC_FECPAG")
                    .HasComment("Fecha de pago");

                entity.Property(e => e.PccImpche)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPCHE")
                    .HasComment("Importe Cheques");

                entity.Property(e => e.PccImpefe)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPEFE")
                    .HasComment("Importe efectivo");

                entity.Property(e => e.PccImpret)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPRET")
                    .HasComment("Importe retenciones");

                entity.Property(e => e.PccImptar)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPTAR")
                    .HasComment("Importe tarjeta");

                entity.Property(e => e.PccImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPTOT");

                entity.Property(e => e.PccImptra)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPTRA")
                    .HasComment("Importe Transferencia");

                entity.Property(e => e.PccIngcaj)
                    .HasColumnName("PCC_INGCAJ")
                    .HasComment("Ingreso en caja");

                entity.Property(e => e.PccObserv)
                    .HasMaxLength(50)
                    .HasColumnName("PCC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<PagoscovDet>(entity =>
            {
                entity.HasKey(e => new { e.PcdCodcom, e.PcdNrofac, e.PcdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("pagoscov_det");

                entity.HasComment("Detalle de medios de pago")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.PcdCodcom, e.PcdNrofac }, "fk_pagoscov_det_pagoscov1");

                entity.Property(e => e.PcdCodcom).HasColumnName("PCD_CODCOM");

                entity.Property(e => e.PcdNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PCD_NROFAC");

                entity.Property(e => e.PcdNrolin)
                    .HasColumnName("PCD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.PcdCodmpa)
                    .HasColumnName("PCD_CODMPA")
                    .HasComment("Codigo de medio de pago");

                entity.Property(e => e.PcdDescri)
                    .HasMaxLength(50)
                    .HasColumnName("PCD_DESCRI");

                entity.Property(e => e.PcdFecimp)
                    .HasColumnType("date")
                    .HasColumnName("PCD_FECIMP")
                    .HasComment("Fecha de imputacion de caja");

                entity.Property(e => e.PcdFecpag)
                    .HasColumnType("date")
                    .HasColumnName("PCD_FECPAG")
                    .HasComment("Fecha de pago");

                entity.Property(e => e.PcdImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCD_IMPORT")
                    .HasComment("Importe");

                entity.Property(e => e.PcdNrocom)
                    .HasPrecision(12)
                    .HasColumnName("PCD_NROCOM")
                    .HasComment("Nro de Comprobante");

                entity.Property(e => e.PcdObserv)
                    .HasMaxLength(50)
                    .HasColumnName("PCD_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.Pcd)
                    .WithMany(p => p.PagoscovDets)
                    .HasForeignKey(d => new { d.PcdCodcom, d.PcdNrofac })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pagoscov_det_pagoscov1");
            });

            modelBuilder.Entity<Paise>(entity =>
            {
                entity.HasKey(e => e.PaiCodpai)
                    .HasName("PRIMARY");

                entity.ToTable("paises");

                entity.HasComment("Paises")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PaiCodpai)
                    .ValueGeneratedNever()
                    .HasColumnName("PAI_CODPAI");

                entity.Property(e => e.PaiCodiso)
                    .HasMaxLength(3)
                    .HasColumnName("PAI_CODISO");

                entity.Property(e => e.PaiDescri)
                    .HasMaxLength(40)
                    .HasColumnName("PAI_DESCRI");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.HasKey(e => e.ParCodpar)
                    .HasName("PRIMARY");

                entity.ToTable("parametros");

                entity.HasComment("Parametros generales del sistema")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ParAbrevi, "CODIGO");

                entity.Property(e => e.ParCodpar)
                    .HasColumnName("PAR_CODPAR")
                    .HasComment("Id parametro");

                entity.Property(e => e.ParAbrevi)
                    .HasMaxLength(10)
                    .HasColumnName("PAR_ABREVI");

                entity.Property(e => e.ParDescri)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("PAR_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.ParObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PAR_OBSERV");

                entity.Property(e => e.ParValor).HasColumnName("PAR_VALOR");
            });

            modelBuilder.Entity<Pedidosc>(entity =>
            {
                entity.HasKey(e => e.PccNroped)
                    .HasName("PRIMARY");

                entity.ToTable("pedidosc");

                entity.HasComment("Pedidos de compra - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PccNroped)
                    .HasPrecision(12)
                    .HasColumnName("PCC_NROPED")
                    .HasComment("Numero de pedido");

                entity.Property(e => e.PccAcopio)
                    .HasColumnName("PCC_ACOPIO")
                    .HasComment("Pedido de Acopio: 0=NO, 1=Acopio de Dinero, 2:Acopio de mercaderias.");

                entity.Property(e => e.PccBonif1)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_BONIF1")
                    .HasComment("bonfiicacion 1");

                entity.Property(e => e.PccBonif2)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_BONIF2")
                    .HasComment("bonificacion 2");

                entity.Property(e => e.PccCodcpa)
                    .HasColumnName("PCC_CODCPA")
                    .HasComment("Codigo condicion de pago");

                entity.Property(e => e.PccCoddep)
                    .HasColumnName("PCC_CODDEP")
                    .HasComment("Codigo de deposito");

                entity.Property(e => e.PccCodlis)
                    .HasColumnName("PCC_CODLIS")
                    .HasComment("Codigo de lista de precios utilizada");

                entity.Property(e => e.PccCodpro)
                    .HasPrecision(6)
                    .HasColumnName("PCC_CODPRO")
                    .HasComment("Cod. de proveedor");

                entity.Property(e => e.PccCodtra).HasColumnName("PCC_CODTRA");

                entity.Property(e => e.PccCodusu)
                    .HasColumnName("PCC_CODUSU")
                    .HasComment("id usuario");

                entity.Property(e => e.PccCodven).HasColumnName("PCC_CODVEN");

                entity.Property(e => e.PccDescri)
                    .HasMaxLength(50)
                    .HasColumnName("PCC_DESCRI")
                    .HasComment("Titulo del Pedido");

                entity.Property(e => e.PccDtogen)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_DTOGEN")
                    .HasComment("Importe dto. gral del comprobante");

                entity.Property(e => e.PccDtogep)
                    .HasPrecision(5, 2)
                    .HasColumnName("PCC_DTOGEP")
                    .HasComment("Porcentaje de descuento gral.");

                entity.Property(e => e.PccEntpar)
                    .HasMaxLength(1)
                    .HasColumnName("PCC_ENTPAR")
                    .HasComment("Entrega parcia S/N");

                entity.Property(e => e.PccEnvio)
                    .HasMaxLength(100)
                    .HasColumnName("PCC_ENVIO")
                    .HasComment("Datos envio del pedido");

                entity.Property(e => e.PccEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PCC_ESTADO")
                    .HasComment("Estado del pedido ABIERTO, CERRADO, ANULADO, ENVIADO");

                entity.Property(e => e.PccFecent)
                    .HasColumnType("date")
                    .HasColumnName("PCC_FECENT")
                    .HasComment("Fecha de entrega (mas larga del detalle)");

                entity.Property(e => e.PccFecped)
                    .HasColumnType("date")
                    .HasColumnName("PCC_FECPED")
                    .HasComment("Fecha de pedido");

                entity.Property(e => e.PccImpivg)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPIVG")
                    .HasComment("Importe iva general");

                entity.Property(e => e.PccImpivr)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPIVR")
                    .HasComment("Importe iva reducido");

                entity.Property(e => e.PccImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_IMPORT")
                    .HasComment("Importe antes de bonif.");

                entity.Property(e => e.PccLeyend)
                    .HasMaxLength(100)
                    .HasColumnName("PCC_LEYEND")
                    .HasComment("Leyenda adicional");

                entity.Property(e => e.PccLugent)
                    .HasMaxLength(45)
                    .HasColumnName("PCC_LUGENT");

                entity.Property(e => e.PccMail)
                    .HasMaxLength(50)
                    .HasColumnName("PCC_MAIL")
                    .HasComment("Mail para avisar ingreso");

                entity.Property(e => e.PccNeto)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_NETO")
                    .HasComment("Importe neto ");

                entity.Property(e => e.PccNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PCC_NROFAC");

                entity.Property(e => e.PccNrooco)
                    .HasMaxLength(12)
                    .HasColumnName("PCC_NROOCO")
                    .HasComment("Nro orden de compra");

                entity.Property(e => e.PccNropre)
                    .HasPrecision(12)
                    .HasColumnName("PCC_NROPRE")
                    .HasComment("Nro de presupuesto");

                entity.Property(e => e.PccNrorem)
                    .HasPrecision(12)
                    .HasColumnName("PCC_NROREM")
                    .HasComment("Nro de remito (aca o en detalle..?)");

                entity.Property(e => e.PccObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PCC_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.PccTotal)
                    .HasPrecision(13, 2)
                    .HasColumnName("PCC_TOTAL")
                    .HasComment("Importe total ");
            });

            modelBuilder.Entity<PedidoscDet>(entity =>
            {
                entity.HasKey(e => new { e.PcdNroped, e.PcdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pedidosc_det");

                entity.HasComment("Pedidos de compra - detalle")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PcdNroped, "fk_pedidosc_detalle_pedidosc");

                entity.Property(e => e.PcdNroped)
                    .HasPrecision(12)
                    .HasColumnName("PCD_NROPED")
                    .HasComment("Numero");

                entity.Property(e => e.PcdNrolin)
                    .HasColumnName("PCD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.PcdBonif1)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_BONIF1")
                    .HasComment("Porc. Bonificacion 1");

                entity.Property(e => e.PcdBonif2)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_BONIF2")
                    .HasComment("Porc. Bonificacion 2");

                entity.Property(e => e.PcdCanent)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_CANENT")
                    .HasComment("Cantidad entregada");

                entity.Property(e => e.PcdCanped)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_CANPED")
                    .HasComment("Cantidad pedida");

                entity.Property(e => e.PcdCodart)
                    .HasMaxLength(15)
                    .HasColumnName("PCD_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.PcdCodmon)
                    .HasColumnName("PCD_CODMON")
                    .HasComment("codigo de moneda");

                entity.Property(e => e.PcdCodori)
                    .HasMaxLength(20)
                    .HasColumnName("PCD_CODORI")
                    .HasComment("Codigo original del articulo");

                entity.Property(e => e.PcdDescri)
                    .HasMaxLength(40)
                    .HasColumnName("PCD_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.PcdEspeci)
                    .HasMaxLength(254)
                    .HasColumnName("PCD_ESPECI")
                    .HasComment("Especificaciones particulares");

                entity.Property(e => e.PcdEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PCD_ESTADO")
                    .HasComment("Estado de la linea, ABIERTO,CERRADO,ANULADO");

                entity.Property(e => e.PcdFecent)
                    .HasColumnType("date")
                    .HasColumnName("PCD_FECENT")
                    .HasComment("Fecha entrega");

                entity.Property(e => e.PcdImpivg)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_IMPIVG")
                    .HasComment("Importe Iva general");

                entity.Property(e => e.PcdImpivr)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_IMPIVR")
                    .HasComment("Importe Iva reducido");

                entity.Property(e => e.PcdImpnet)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_IMPNET")
                    .HasComment("Importe neto unitario");

                entity.Property(e => e.PcdImptot)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_IMPTOT")
                    .HasComment("Importe total unitario");

                entity.Property(e => e.PcdLinaco)
                    .HasColumnName("PCD_LINACO")
                    .HasComment("Linea acondicionamiento");

                entity.Property(e => e.PcdNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PCD_NROFAC")
                    .HasComment("Nro. de factura");

                entity.Property(e => e.PcdNropre)
                    .HasPrecision(12)
                    .HasColumnName("PCD_NROPRE");

                entity.Property(e => e.PcdNrorem)
                    .HasPrecision(12)
                    .HasColumnName("PCD_NROREM")
                    .HasComment("Nro. de remito (de entrega) aca o en el remito... x entr. parciales");

                entity.Property(e => e.PcdObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PCD_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.PcdPreuni)
                    .HasPrecision(11, 2)
                    .HasColumnName("PCD_PREUNI")
                    .HasComment("Precio unitario");

                entity.Property(e => e.PcdTipaco)
                    .HasMaxLength(15)
                    .HasColumnName("PCD_TIPACO")
                    .HasComment("Tipo acondicionamiento");

                entity.Property(e => e.PcdUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("PCD_UNIMED")
                    .HasComment("Unidad de medida");

                entity.Property(e => e.PcdValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("PCD_VALIVA")
                    .HasComment("Alicuota IVA");

                entity.HasOne(d => d.PcdNropedNavigation)
                    .WithMany(p => p.PedidoscDets)
                    .HasForeignKey(d => d.PcdNroped)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pedidosc_detalle_pedidosc");
            });

            modelBuilder.Entity<Pedidosv>(entity =>
            {
                entity.HasKey(e => e.PvcNroped)
                    .HasName("PRIMARY");

                entity.ToTable("pedidosv");

                entity.HasComment("Presupuestos - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PvcNroped)
                    .HasPrecision(12)
                    .HasColumnName("PVC_NROPED")
                    .HasComment("Numero de pedido");

                entity.Property(e => e.PvcAcopio)
                    .HasColumnName("PVC_ACOPIO")
                    .HasComment("Pedido de Acopio: 0=NO, 1=Acopio de Dinero, 2:Acopio de mercaderías.");

                entity.Property(e => e.PvcBonif1)
                    .HasPrecision(13, 2)
                    .HasColumnName("PVC_BONIF1")
                    .HasComment("bonfiicacion 1");

                entity.Property(e => e.PvcBonif2)
                    .HasPrecision(13, 2)
                    .HasColumnName("PVC_BONIF2")
                    .HasComment("bonificacion 2");

                entity.Property(e => e.PvcCodcli)
                    .HasPrecision(6)
                    .HasColumnName("PVC_CODCLI")
                    .HasComment("Cod. de cliente");

                entity.Property(e => e.PvcCodcpa)
                    .HasColumnName("PVC_CODCPA")
                    .HasComment("Codigo condicion de pago");

                entity.Property(e => e.PvcCoddep)
                    .HasColumnName("PVC_CODDEP")
                    .HasComment("Codigo de deposito");

                entity.Property(e => e.PvcCodlis)
                    .HasColumnName("PVC_CODLIS")
                    .HasComment("Codigo de lista de precios utilizada");

                entity.Property(e => e.PvcCodtra)
                    .HasColumnName("PVC_CODTRA")
                    .HasComment("Codigo de transporte");

                entity.Property(e => e.PvcCodusu)
                    .HasColumnName("PVC_CODUSU")
                    .HasComment("Codigo Usuario");

                entity.Property(e => e.PvcCodven).HasColumnName("PVC_CODVEN");

                entity.Property(e => e.PvcDtogen)
                    .HasPrecision(13, 2)
                    .HasColumnName("PVC_DTOGEN")
                    .HasComment("Importe dto. gral del comprobante");

                entity.Property(e => e.PvcDtogep)
                    .HasPrecision(5, 2)
                    .HasColumnName("PVC_DTOGEP")
                    .HasComment("Porcentaje de descuento gral.");

                entity.Property(e => e.PvcEntpar)
                    .HasMaxLength(1)
                    .HasColumnName("PVC_ENTPAR")
                    .HasComment("Entrega parcia S/N");

                entity.Property(e => e.PvcEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PVC_ESTADO")
                    .HasComment("Estado del pedido ABIERTO, CERRADO, ANULADO");

                entity.Property(e => e.PvcFecent)
                    .HasColumnType("date")
                    .HasColumnName("PVC_FECENT")
                    .HasComment("Fecha de entrega (mas larga del detalle)");

                entity.Property(e => e.PvcFecped)
                    .HasColumnType("date")
                    .HasColumnName("PVC_FECPED")
                    .HasComment("Fecha de pedido");

                entity.Property(e => e.PvcImpivg)
                    .HasPrecision(13, 2)
                    .HasColumnName("PVC_IMPIVG")
                    .HasComment("Importe iva general");

                entity.Property(e => e.PvcImpivr)
                    .HasPrecision(13, 2)
                    .HasColumnName("PVC_IMPIVR")
                    .HasComment("Importe iva reducido");

                entity.Property(e => e.PvcImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("PVC_IMPORT")
                    .HasComment("Importe antes de bonif.");

                entity.Property(e => e.PvcLeyend)
                    .HasMaxLength(100)
                    .HasColumnName("PVC_LEYEND")
                    .HasComment("Leyenda adicional");

                entity.Property(e => e.PvcLugent)
                    .HasMaxLength(45)
                    .HasColumnName("PVC_LUGENT");

                entity.Property(e => e.PvcNeto)
                    .HasPrecision(13, 2)
                    .HasColumnName("PVC_NETO")
                    .HasComment("Importe neto ");

                entity.Property(e => e.PvcNomcli)
                    .HasMaxLength(40)
                    .HasColumnName("PVC_NOMCLI")
                    .HasComment("Nombre de Cliente");

                entity.Property(e => e.PvcNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PVC_NROFAC")
                    .HasComment("Nro de factura");

                entity.Property(e => e.PvcNrooco)
                    .HasMaxLength(20)
                    .HasColumnName("PVC_NROOCO")
                    .HasComment("Nro orden de compra");

                entity.Property(e => e.PvcNropre)
                    .HasPrecision(12)
                    .HasColumnName("PVC_NROPRE")
                    .HasComment("Nro de presupuesto");

                entity.Property(e => e.PvcNrorem)
                    .HasPrecision(12)
                    .HasColumnName("PVC_NROREM")
                    .HasComment("Nro de remito (aca o en detalle..?)");

                entity.Property(e => e.PvcObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PVC_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.PvcTotal)
                    .HasPrecision(13, 2)
                    .HasColumnName("PVC_TOTAL")
                    .HasComment("Importe total ");
            });

            modelBuilder.Entity<PedidosvDet>(entity =>
            {
                entity.HasKey(e => new { e.PvdNroped, e.PvdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pedidosv_det");

                entity.HasComment("Presupuestos - detalle")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PvdNroped, "fk_pedidos_detalle_pedidos");

                entity.Property(e => e.PvdNroped)
                    .HasPrecision(12)
                    .HasColumnName("PVD_NROPED")
                    .HasComment("Número");

                entity.Property(e => e.PvdNrolin)
                    .HasColumnName("PVD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.PvdBonif1)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_BONIF1")
                    .HasComment("% Bonificacion 1");

                entity.Property(e => e.PvdBonif2)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_BONIF2")
                    .HasComment("% Bonificacion 2");

                entity.Property(e => e.PvdCanent)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_CANENT")
                    .HasComment("Cantidad entregada");

                entity.Property(e => e.PvdCanped)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_CANPED")
                    .HasComment("Cantidad pedida");

                entity.Property(e => e.PvdCodart)
                    .HasMaxLength(15)
                    .HasColumnName("PVD_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.PvdDescri)
                    .HasMaxLength(40)
                    .HasColumnName("PVD_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.PvdEspeci)
                    .HasMaxLength(254)
                    .HasColumnName("PVD_ESPECI")
                    .HasComment("Especificaciones particulares");

                entity.Property(e => e.PvdEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PVD_ESTADO")
                    .HasComment("Estado de la linea, ABIERTO,CERRADO,ANULADO");

                entity.Property(e => e.PvdFecent)
                    .HasColumnType("date")
                    .HasColumnName("PVD_FECENT")
                    .HasComment("Fecha entrega");

                entity.Property(e => e.PvdImpivg)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_IMPIVG")
                    .HasComment("Importe Iva general");

                entity.Property(e => e.PvdImpivr)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_IMPIVR")
                    .HasComment("Importe Iva reducido");

                entity.Property(e => e.PvdImpnet)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_IMPNET")
                    .HasComment("Importe neto unitario");

                entity.Property(e => e.PvdImptot)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_IMPTOT")
                    .HasComment("Importe total unitario");

                entity.Property(e => e.PvdNrofac)
                    .HasPrecision(12)
                    .HasColumnName("PVD_NROFAC")
                    .HasComment("Nro. de factura");

                entity.Property(e => e.PvdNropre)
                    .HasPrecision(12)
                    .HasColumnName("PVD_NROPRE");

                entity.Property(e => e.PvdNrorem)
                    .HasPrecision(12)
                    .HasColumnName("PVD_NROREM")
                    .HasComment("Nro. de remito (de entrega) aca o en el remito... x entr. parciales");

                entity.Property(e => e.PvdObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PVD_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.PvdPreunit)
                    .HasPrecision(11, 2)
                    .HasColumnName("PVD_PREUNIT")
                    .HasComment("Precio unitario");

                entity.Property(e => e.PvdUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("PVD_UNIMED")
                    .HasComment("Unidad de medida");

                entity.Property(e => e.PvdValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("PVD_VALIVA")
                    .HasComment("Alicuota de IVA");

                entity.HasOne(d => d.PvdNropedNavigation)
                    .WithMany(p => p.PedidosvDets)
                    .HasForeignKey(d => d.PvdNroped)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pedidos_detalle_pedidos");
            });

            modelBuilder.Entity<Pre>(entity =>
            {
                entity.HasKey(e => e.Codart)
                    .HasName("PRIMARY");

                entity.ToTable("pre");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Codart)
                    .HasMaxLength(15)
                    .HasColumnName("CODART");

                entity.Property(e => e.Moneda).HasColumnName("MONEDA");

                entity.Property(e => e.Precos)
                    .HasPrecision(13, 2)
                    .HasColumnName("PRECOS");
            });

            modelBuilder.Entity<Precio>(entity =>
            {
                entity.HasKey(e => new { e.PreCodart, e.PrePvci002 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("precios");

                entity.HasComment("Precios de los articulos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PreCodart, "fk_precios_articulos1");

                entity.Property(e => e.PreCodart)
                    .HasMaxLength(15)
                    .HasColumnName("PRE_CODART")
                    .HasComment("Codigo de artículo");

                entity.Property(e => e.PrePvci002)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI002");

                entity.Property(e => e.PreCmon001).HasColumnName("PRE_CMON001");

                entity.Property(e => e.PreCmon002).HasColumnName("PRE_CMON002");

                entity.Property(e => e.PreCmon003)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON003")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon004)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON004")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon005)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON005")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon006)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON006")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon007)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON007")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon008)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON008")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon009)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON009")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon010)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON010")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon011)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON011")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon012)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON012")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PreCmon013)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON013")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.PreCmon014)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON014")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.PreCmon015)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_CMON015")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.PreCodlin)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("PRE_CODLIN");

                entity.Property(e => e.PreCodmar)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("PRE_CODMAR");

                entity.Property(e => e.PreCodmon).HasColumnName("PRE_CODMON");

                entity.Property(e => e.PreCodrub)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("PRE_CODRUB");

                entity.Property(e => e.PreCodsru)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("PRE_CODSRU");

                entity.Property(e => e.PrePrecos)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PRECOS");

                entity.Property(e => e.PrePvci001)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI001")
                    .HasComment("Precio de venta con iva lista 1");

                entity.Property(e => e.PrePvci003)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI003");

                entity.Property(e => e.PrePvci004)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI004");

                entity.Property(e => e.PrePvci005)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI005");

                entity.Property(e => e.PrePvci006)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI006");

                entity.Property(e => e.PrePvci007)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI007");

                entity.Property(e => e.PrePvci008)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI008");

                entity.Property(e => e.PrePvci009)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI009");

                entity.Property(e => e.PrePvci010)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI010");

                entity.Property(e => e.PrePvci011)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI011");

                entity.Property(e => e.PrePvci012)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI012");

                entity.Property(e => e.PrePvci013)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI013");

                entity.Property(e => e.PrePvci014)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI014");

                entity.Property(e => e.PrePvci015)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVCI015");

                entity.Property(e => e.PrePvsi001)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI001")
                    .HasComment("Precio de venta sin iva lista 1");

                entity.Property(e => e.PrePvsi002)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI002");

                entity.Property(e => e.PrePvsi003)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI003");

                entity.Property(e => e.PrePvsi004)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI004");

                entity.Property(e => e.PrePvsi005)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI005");

                entity.Property(e => e.PrePvsi006)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI006");

                entity.Property(e => e.PrePvsi007)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI007");

                entity.Property(e => e.PrePvsi008)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI008");

                entity.Property(e => e.PrePvsi009)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI009");

                entity.Property(e => e.PrePvsi010)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI010");

                entity.Property(e => e.PrePvsi011)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI011");

                entity.Property(e => e.PrePvsi012)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI012");

                entity.Property(e => e.PrePvsi013)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI013");

                entity.Property(e => e.PrePvsi014)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI014");

                entity.Property(e => e.PrePvsi015)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_PVSI015");

                entity.Property(e => e.PreTcal001)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL001")
                    .HasDefaultValueSql("'A'")
                    .HasComment("A:AUTOMATICO - M:MANUAL lista 1");

                entity.Property(e => e.PreTcal002)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL002")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal003)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL003")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal004)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL004")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal005)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL005")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal006)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL006")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal007)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL007")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal008)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL008")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal009)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL009")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal010)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL010")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal011)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL011")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal012)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL012")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal013)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL013")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal014)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL014")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreTcal015)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("PRE_TCAL015")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.PreUtil001)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL001")
                    .HasComment("Utilidad Lista 1");

                entity.Property(e => e.PreUtil002)
                    .HasPrecision(13, 3)
                    .HasColumnName("PRE_UTIL002");

                entity.Property(e => e.PreUtil003)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL003");

                entity.Property(e => e.PreUtil004)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL004");

                entity.Property(e => e.PreUtil005)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL005");

                entity.Property(e => e.PreUtil006)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL006");

                entity.Property(e => e.PreUtil007)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL007");

                entity.Property(e => e.PreUtil008)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL008");

                entity.Property(e => e.PreUtil009)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL009");

                entity.Property(e => e.PreUtil010)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL010");

                entity.Property(e => e.PreUtil011)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL011");

                entity.Property(e => e.PreUtil012)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL012");

                entity.Property(e => e.PreUtil013)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL013");

                entity.Property(e => e.PreUtil014)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL014");

                entity.Property(e => e.PreUtil015)
                    .HasPrecision(6, 2)
                    .HasColumnName("PRE_UTIL015");

                entity.Property(e => e.PreValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("PRE_VALIVA");

                entity.HasOne(d => d.PreCodartNavigation)
                    .WithMany(p => p.Precios)
                    .HasForeignKey(d => d.PreCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_precios_articulos1");
            });

            modelBuilder.Entity<Presup>(entity =>
            {
                entity.HasKey(e => e.PtcNropre)
                    .HasName("PRIMARY");

                entity.ToTable("presup");

                entity.HasComment("Pedidos - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PtcNropre)
                    .HasPrecision(12)
                    .HasColumnName("PTC_NROPRE")
                    .HasComment("Numero");

                entity.Property(e => e.PtcBonif1)
                    .HasPrecision(13, 2)
                    .HasColumnName("PTC_BONIF1")
                    .HasComment("bonfiicacion 1");

                entity.Property(e => e.PtcBonif2)
                    .HasPrecision(13, 2)
                    .HasColumnName("PTC_BONIF2")
                    .HasComment("bonificacion 2");

                entity.Property(e => e.PtcCcosto)
                    .HasMaxLength(45)
                    .HasColumnName("PTC_CCOSTO")
                    .HasComment("Centro de Costo");

                entity.Property(e => e.PtcCodcli)
                    .HasPrecision(6)
                    .HasColumnName("PTC_CODCLI")
                    .HasComment("Cod. de cliente");

                entity.Property(e => e.PtcCodcpa)
                    .HasColumnName("PTC_CODCPA")
                    .HasComment("Condicion de pago");

                entity.Property(e => e.PtcCoddep)
                    .HasColumnName("PTC_CODDEP")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PtcCodlis)
                    .HasColumnName("PTC_CODLIS")
                    .HasComment("Codigo de lista");

                entity.Property(e => e.PtcCodmon)
                    .HasColumnName("PTC_CODMON")
                    .HasComment("Codigo de moneda");

                entity.Property(e => e.PtcCodtra)
                    .HasColumnName("PTC_CODTRA")
                    .HasComment("Codigo de Transporte");

                entity.Property(e => e.PtcCodusu)
                    .HasColumnName("PTC_CODUSU")
                    .HasComment("Codigo de Usuario");

                entity.Property(e => e.PtcCodven).HasColumnName("PTC_CODVEN");

                entity.Property(e => e.PtcConiva)
                    .HasColumnName("PTC_CONIVA")
                    .HasComment("Contiene IVA");

                entity.Property(e => e.PtcContac)
                    .HasMaxLength(40)
                    .HasColumnName("PTC_CONTAC")
                    .HasComment("Contacto");

                entity.Property(e => e.PtcDiasen)
                    .HasColumnName("PTC_DIASEN")
                    .HasComment("dias de entrega");

                entity.Property(e => e.PtcDtogen)
                    .HasPrecision(13, 2)
                    .HasColumnName("PTC_DTOGEN")
                    .HasComment("Importe dto. gral comprobante");

                entity.Property(e => e.PtcDtogep)
                    .HasPrecision(5, 2)
                    .HasColumnName("PTC_DTOGEP")
                    .HasComment("Porcentaje dto. gral comprobante");

                entity.Property(e => e.PtcEntpar)
                    .HasMaxLength(1)
                    .HasColumnName("PTC_ENTPAR")
                    .HasComment("Entregas parciales S/N");

                entity.Property(e => e.PtcEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PTC_ESTADO");

                entity.Property(e => e.PtcFecent)
                    .HasMaxLength(10)
                    .HasColumnName("PTC_FECENT")
                    .HasComment("Fecha de entrega (mas larga del detalle)");

                entity.Property(e => e.PtcFecpre)
                    .HasColumnType("date")
                    .HasColumnName("PTC_FECPRE")
                    .HasComment("Fecha de presup");

                entity.Property(e => e.PtcFecven)
                    .HasColumnType("date")
                    .HasColumnName("PTC_FECVEN")
                    .HasComment("Fecha vencimiento presup.");

                entity.Property(e => e.PtcImpivg)
                    .HasPrecision(13, 2)
                    .HasColumnName("PTC_IMPIVG")
                    .HasComment("Importe iva general");

                entity.Property(e => e.PtcImpivr)
                    .HasPrecision(13, 2)
                    .HasColumnName("PTC_IMPIVR")
                    .HasComment("Importe iva reducido");

                entity.Property(e => e.PtcImpnet)
                    .HasPrecision(13, 2)
                    .HasColumnName("PTC_IMPNET")
                    .HasComment("Importe neto ");

                entity.Property(e => e.PtcImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("PTC_IMPORT")
                    .HasComment("Importe antes de bonificaciones");

                entity.Property(e => e.PtcImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("PTC_IMPTOT")
                    .HasComment("Importe total ");

                entity.Property(e => e.PtcLeyend)
                    .HasMaxLength(100)
                    .HasColumnName("PTC_LEYEND");

                entity.Property(e => e.PtcNomcli)
                    .HasMaxLength(40)
                    .HasColumnName("PTC_NOMCLI")
                    .HasComment("Nombre de Cliente");

                entity.Property(e => e.PtcObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PTC_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.PtcValmon)
                    .HasPrecision(5, 2)
                    .HasColumnName("PTC_VALMON")
                    .HasComment("Valor de la moneda");
            });

            modelBuilder.Entity<PresupDet>(entity =>
            {
                entity.HasKey(e => new { e.PtdNropre, e.PtdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("presup_det");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PtdNropre, "fk_pedidos_detalle_pedidos");

                entity.Property(e => e.PtdNropre)
                    .HasPrecision(12)
                    .HasColumnName("PTD_NROPRE")
                    .HasComment("Número");

                entity.Property(e => e.PtdNrolin)
                    .HasColumnName("PTD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.PtdArcham)
                    .HasMaxLength(2)
                    .HasColumnName("PTD_ARCHAM")
                    .HasComment("Si viene del archivo ampliado de art");

                entity.Property(e => e.PtdBonif1)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_BONIF1")
                    .HasComment("% Bonificacion 1");

                entity.Property(e => e.PtdBonif2)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_BONIF2")
                    .HasComment("% Bonificacion 2");

                entity.Property(e => e.PtdCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_CANTID")
                    .HasComment("Cantidad pedida");

                entity.Property(e => e.PtdCodart)
                    .HasMaxLength(15)
                    .HasColumnName("PTD_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.PtdCodmar)
                    .HasMaxLength(15)
                    .HasColumnName("PTD_CODMAR")
                    .HasComment("codigo de marca (para art. externos)");

                entity.Property(e => e.PtdCodori)
                    .HasMaxLength(45)
                    .HasColumnName("PTD_CODORI");

                entity.Property(e => e.PtdDescri)
                    .HasMaxLength(40)
                    .HasColumnName("PTD_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.PtdEspeci)
                    .HasMaxLength(254)
                    .HasColumnName("PTD_ESPECI")
                    .HasComment("Especificaciones particulares");

                entity.Property(e => e.PtdFecent)
                    .HasColumnType("date")
                    .HasColumnName("PTD_FECENT")
                    .HasComment("Fecha entrega");

                entity.Property(e => e.PtdImpivg)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_IMPIVG")
                    .HasComment("Importe Iva general");

                entity.Property(e => e.PtdImpivr)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_IMPIVR")
                    .HasComment("Importe Iva reducido");

                entity.Property(e => e.PtdImpnet)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_IMPNET")
                    .HasComment("Importe neto unitario");

                entity.Property(e => e.PtdImptot)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_IMPTOT")
                    .HasComment("Importe total unitario");

                entity.Property(e => e.PtdObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PTD_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.PtdPrecio)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_PRECIO")
                    .HasComment("Precio unitario");

                entity.Property(e => e.PtdUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("PTD_UNIMED")
                    .HasComment("Unidad de medida");

                entity.Property(e => e.PtdValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("PTD_VALIVA");

                entity.HasOne(d => d.PtdNropreNavigation)
                    .WithMany(p => p.PresupDets)
                    .HasForeignKey(d => d.PtdNropre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pedidos_detalle_pedidos0");
            });

            modelBuilder.Entity<Presupmod>(entity =>
            {
                entity.HasKey(e => e.PtcNropre)
                    .HasName("PRIMARY");

                entity.ToTable("presupmod");

                entity.HasComment("Cabecera presupuestos modelo")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PtcNropre)
                    .HasPrecision(12)
                    .HasColumnName("PTC_NROPRE")
                    .HasComment("Numero");

                entity.Property(e => e.PtcCodcli)
                    .HasPrecision(6)
                    .HasColumnName("PTC_CODCLI")
                    .HasComment("Cod. de cliente");

                entity.Property(e => e.PtcEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PTC_ESTADO");

                entity.Property(e => e.PtcFecpre)
                    .HasColumnType("date")
                    .HasColumnName("PTC_FECPRE")
                    .HasComment("Fecha de presup");

                entity.Property(e => e.PtcFecven)
                    .HasColumnType("date")
                    .HasColumnName("PTC_FECVEN")
                    .HasComment("Fecha vencimiento presup.");

                entity.Property(e => e.PtcLeyend)
                    .HasMaxLength(100)
                    .HasColumnName("PTC_LEYEND");

                entity.Property(e => e.PtcNompre)
                    .HasMaxLength(40)
                    .HasColumnName("PTC_NOMPRE")
                    .HasComment("Nombre del Presupuesto");

                entity.Property(e => e.PtcObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PTC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<PresupmodDet>(entity =>
            {
                entity.HasKey(e => new { e.PtdNropre, e.PtdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("presupmod_det");

                entity.HasComment("Detalle Presupuestos modelo")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PtdNropre, "fk_presupmod_det_presupmod1");

                entity.Property(e => e.PtdNropre)
                    .HasPrecision(12)
                    .HasColumnName("PTD_NROPRE");

                entity.Property(e => e.PtdNrolin)
                    .HasColumnName("PTD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.PtdBonif1)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_BONIF1")
                    .HasComment("Bonificacion 1");

                entity.Property(e => e.PtdBonif2)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_BONIF2")
                    .HasComment("Bonificacion 2");

                entity.Property(e => e.PtdCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_CANTID")
                    .HasComment("Cantidad pedida");

                entity.Property(e => e.PtdCodart)
                    .HasMaxLength(15)
                    .HasColumnName("PTD_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.PtdCodmar)
                    .HasMaxLength(15)
                    .HasColumnName("PTD_CODMAR");

                entity.Property(e => e.PtdDescri)
                    .HasMaxLength(40)
                    .HasColumnName("PTD_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.PtdEspeci)
                    .HasMaxLength(100)
                    .HasColumnName("PTD_ESPECI")
                    .HasComment("Especificaciones particulares");

                entity.Property(e => e.PtdImpivg)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_IMPIVG")
                    .HasComment("Iva general");

                entity.Property(e => e.PtdImpivr)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_IMPIVR")
                    .HasComment("Iva reducido");

                entity.Property(e => e.PtdImpnet)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_IMPNET")
                    .HasComment("Importe neto");

                entity.Property(e => e.PtdImptot)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_IMPTOT")
                    .HasComment("Importe total");

                entity.Property(e => e.PtdObserv)
                    .HasMaxLength(45)
                    .HasColumnName("PTD_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.PtdPrecio)
                    .HasPrecision(11, 2)
                    .HasColumnName("PTD_PRECIO")
                    .HasComment("Precio unitario");

                entity.Property(e => e.PtdUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("PTD_UNIMED")
                    .HasComment("Unidad de medida");

                entity.Property(e => e.PtdValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("PTD_VALIVA");

                entity.HasOne(d => d.PtdNropreNavigation)
                    .WithMany(p => p.PresupmodDets)
                    .HasForeignKey(d => d.PtdNropre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_presupmod_det_presupmod1");
            });

            modelBuilder.Entity<Promocione>(entity =>
            {
                entity.HasKey(e => e.PrmCodart)
                    .HasName("PRIMARY");

                entity.ToTable("promociones");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.PrmCodart)
                    .HasMaxLength(15)
                    .HasColumnName("PRM_CODART");

                entity.Property(e => e.PrmFdesde)
                    .HasColumnType("date")
                    .HasColumnName("PRM_FDESDE");

                entity.Property(e => e.PrmHasta)
                    .HasColumnType("date")
                    .HasColumnName("PRM_HASTA");

                entity.Property(e => e.PrmIva)
                    .HasPrecision(11, 2)
                    .HasColumnName("PRM_IVA");

                entity.Property(e => e.PrmPrecio)
                    .HasMaxLength(45)
                    .HasColumnName("PRM_PRECIO");
            });

            modelBuilder.Entity<ProveeContac>(entity =>
            {
                entity.HasKey(e => new { e.PycCodpro, e.PycCodcon })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("provee_contac");

                entity.HasComment("Proveedores y contactos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PycCodpro, "fk_provee_contac_proveedores1");

                entity.HasIndex(e => e.PycCodcon, "fk_table1_contactos1");

                entity.Property(e => e.PycCodpro)
                    .HasColumnName("PYC_CODPRO")
                    .HasComment("Codigo de proveedor");

                entity.Property(e => e.PycCodcon)
                    .HasPrecision(6)
                    .HasColumnName("PYC_CODCON")
                    .HasComment("Codigo de contacto");

                entity.HasOne(d => d.PycCodconNavigation)
                    .WithMany(p => p.ProveeContacs)
                    .HasForeignKey(d => d.PycCodcon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_table1_contactos11");

                entity.HasOne(d => d.PycCodproNavigation)
                    .WithMany(p => p.ProveeContacs)
                    .HasForeignKey(d => d.PycCodpro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_provee_contac_proveedores1");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.ProCodpro)
                    .HasName("PRIMARY");

                entity.ToTable("proveedores");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ProCodciv, "fk_proveedores_condiva1");

                entity.HasIndex(e => e.ProCodcpa, "fk_proveedores_condpago1");

                entity.HasIndex(e => e.ProCodloc, "fk_proveedores_localidad1");

                entity.HasIndex(e => e.ProCodprv, "fk_proveedores_provincia1");

                entity.Property(e => e.ProCodpro)
                    .ValueGeneratedNever()
                    .HasColumnName("PRO_CODPRO")
                    .HasComment("codigo de proveedor");

                entity.Property(e => e.ProCai)
                    .HasMaxLength(15)
                    .HasColumnName("PRO_CAI")
                    .HasComment("Nro cai");

                entity.Property(e => e.ProCodciv).HasColumnName("PRO_CODCIV");

                entity.Property(e => e.ProCodcpa).HasColumnName("PRO_CODCPA");

                entity.Property(e => e.ProCodloc)
                    .HasPrecision(5)
                    .HasColumnName("PRO_CODLOC");

                entity.Property(e => e.ProCodmon)
                    .HasColumnName("PRO_CODMON")
                    .HasComment("moneda saldo inicial");

                entity.Property(e => e.ProCodpos)
                    .HasMaxLength(8)
                    .HasColumnName("PRO_CODPOS")
                    .HasComment("Codigo Postal");

                entity.Property(e => e.ProCodprv)
                    .HasPrecision(3)
                    .HasColumnName("PRO_CODPRV");

                entity.Property(e => e.ProConcep)
                    .HasMaxLength(20)
                    .HasColumnName("PRO_CONCEP")
                    .HasComment("concepto: mercaderia o gastos");

                entity.Property(e => e.ProCtacte)
                    .HasColumnName("PRO_CTACTE")
                    .HasComment("Cuenta Corriente");

                entity.Property(e => e.ProCuit)
                    .HasMaxLength(13)
                    .HasColumnName("PRO_CUIT")
                    .HasComment("Cuit");

                entity.Property(e => e.ProDescpa)
                    .HasPrecision(5, 2)
                    .HasColumnName("PRO_DESCPA")
                    .HasComment("Descuento para condición de pago habitual");

                entity.Property(e => e.ProDescri)
                    .HasMaxLength(40)
                    .HasColumnName("PRO_DESCRI")
                    .HasComment("Nombre-denominacion");

                entity.Property(e => e.ProDeslis)
                    .HasPrecision(5, 2)
                    .HasColumnName("PRO_DESLIS")
                    .HasComment("Descuento sobre lista de precios");

                entity.Property(e => e.ProDirecc)
                    .HasMaxLength(40)
                    .HasColumnName("PRO_DIRECC")
                    .HasComment("dirección");

                entity.Property(e => e.ProEstado)
                    .HasMaxLength(10)
                    .HasColumnName("PRO_ESTADO")
                    .HasComment("Condiciones de estado (ver)");

                entity.Property(e => e.ProFax)
                    .HasMaxLength(20)
                    .HasColumnName("PRO_FAX")
                    .HasComment("Fax empresa");

                entity.Property(e => e.ProFecalt)
                    .HasColumnType("timestamp")
                    .HasColumnName("PRO_FECALT")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("fecha de alta");

                entity.Property(e => e.ProFecufr)
                    .HasColumnType("date")
                    .HasColumnName("PRO_FECUFR")
                    .HasComment("Ultima factura recibida");

                entity.Property(e => e.ProFecupa)
                    .HasColumnType("date")
                    .HasColumnName("PRO_FECUPA")
                    .HasComment("Fecha ultimo pago");

                entity.Property(e => e.ProIngbru)
                    .HasMaxLength(15)
                    .HasColumnName("PRO_INGBRU")
                    .HasComment("nro. ingresos brutos");

                entity.Property(e => e.ProLimcre)
                    .HasPrecision(11)
                    .HasColumnName("PRO_LIMCRE")
                    .HasComment("Limite de credito");

                entity.Property(e => e.ProMail)
                    .HasMaxLength(45)
                    .HasColumnName("PRO_MAIL")
                    .HasComment("mail empresa");

                entity.Property(e => e.ProObserv)
                    .HasMaxLength(200)
                    .HasColumnName("PRO_OBSERV")
                    .HasComment("observaciones");

                entity.Property(e => e.ProSaldo)
                    .HasPrecision(13, 2)
                    .HasColumnName("PRO_SALDO")
                    .HasComment("saldo");

                entity.Property(e => e.ProTele1)
                    .HasMaxLength(20)
                    .HasColumnName("PRO_TELE1")
                    .HasComment("telefono 1 empresa");

                entity.Property(e => e.ProTele2)
                    .HasMaxLength(20)
                    .HasColumnName("PRO_TELE2")
                    .HasComment("Telefono 2 empresa");

                entity.Property(e => e.ProVencai)
                    .HasColumnType("date")
                    .HasColumnName("PRO_VENCAI")
                    .HasComment("vencimiento del cai");

                entity.Property(e => e.ProWeb)
                    .HasMaxLength(45)
                    .HasColumnName("PRO_WEB")
                    .HasComment("web empresa");

                entity.HasOne(d => d.ProCodcivNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.ProCodciv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_condiva1");

                entity.HasOne(d => d.ProCodcpaNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.ProCodcpa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_condpago1");

                entity.HasOne(d => d.ProCodlocNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.ProCodloc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_localidad1");

                entity.HasOne(d => d.ProCodprvNavigation)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.ProCodprv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_proveedores_provincia1");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.PrvCodprv)
                    .HasName("PRIMARY");

                entity.ToTable("provincias");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PrvCodprv, "provin_pk")
                    .IsUnique();

                entity.Property(e => e.PrvCodprv)
                    .HasPrecision(3)
                    .HasColumnName("PRV_CODPRV");

                entity.Property(e => e.PrvDescri)
                    .IsRequired()
                    .HasMaxLength(23)
                    .HasColumnName("PRV_DESCRI")
                    .HasDefaultValueSql("' '");
            });

            modelBuilder.Entity<Puesto>(entity =>
            {
                entity.HasKey(e => e.PueCodpue)
                    .HasName("PRIMARY");

                entity.ToTable("puestos");

                entity.HasComment("Puestos de trabajo")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.PueNompc, "PUE_NOMPC_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PueCoddep, "fk_puestos_depositos1");

                entity.Property(e => e.PueCodpue)
                    .ValueGeneratedNever()
                    .HasColumnName("PUE_CODPUE")
                    .HasComment("Codigo");

                entity.Property(e => e.PueCoddep)
                    .HasColumnName("PUE_CODDEP")
                    .HasComment("Codigo de deposito al que descarga stock");

                entity.Property(e => e.PueCodlis)
                    .HasColumnName("PUE_CODLIS")
                    .HasComment("Lista de precios por defecto");

                entity.Property(e => e.PueDespue)
                    .HasMaxLength(45)
                    .HasColumnName("PUE_DESPUE")
                    .HasComment("Descripción del puesto");

                entity.Property(e => e.PueDirip)
                    .HasMaxLength(45)
                    .HasColumnName("PUE_DIRIP")
                    .HasComment("Dirección IP de la PC");

                entity.Property(e => e.PueHtmail)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("PUE_HTMAIL")
                    .HasDefaultValueSql("''")
                    .HasComment("HOST SMTP para envio de mail (sendmail)");

                entity.Property(e => e.PueImpfis)
                    .HasColumnName("PUE_IMPFIS")
                    .HasComment("Tiene impresora fiscal conectada");

                entity.Property(e => e.PueNompc)
                    .HasMaxLength(15)
                    .HasColumnName("PUE_NOMPC")
                    .HasComment("Nombre de la PC");

                entity.Property(e => e.PuePrecel)
                    .HasColumnName("PUE_PRECEL")
                    .HasComment("Prefijo Comprobantes Electronicos");

                entity.Property(e => e.PuePrefis)
                    .HasColumnName("PUE_PREFIS")
                    .HasComment("Prefijo Comprobantes fiscales");

                entity.Property(e => e.PuePreman)
                    .HasColumnName("PUE_PREMAN")
                    .HasComment("Prefijo Comprobantes manuales");

                entity.Property(e => e.PuePreots)
                    .HasColumnName("PUE_PREOTS")
                    .HasComment("Prefijo otros comprobantes (internos)");

                entity.Property(e => e.PuePresis)
                    .HasColumnName("PUE_PRESIS")
                    .HasComment("Prefijo Comprobantes del sistema");

                entity.Property(e => e.PuePsmail)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("PUE_PSMAIL")
                    .HasDefaultValueSql("''")
                    .HasComment("Password mail (sendmail)");

                entity.Property(e => e.PuePtmail)
                    .HasColumnName("PUE_PTMAIL")
                    .HasComment("Puerto SMTP (sendmail)");

                entity.Property(e => e.PuePuefis)
                    .HasColumnName("PUE_PUEFIS")
                    .HasComment("Id de la impresora fiscal");

                entity.Property(e => e.PueUsmail)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("PUE_USMAIL")
                    .HasDefaultValueSql("''")
                    .HasComment("Usuario mail (sendmail)");

                entity.Property(e => e.PueUsuari)
                    .HasMaxLength(10)
                    .HasColumnName("PUE_USUARI")
                    .HasComment("usuario por defecto");

                entity.HasOne(d => d.PueCoddepNavigation)
                    .WithMany(p => p.Puestos)
                    .HasForeignKey(d => d.PueCoddep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_puestos_depositos1");
            });

            modelBuilder.Entity<ReclMov>(entity =>
            {
                entity.HasKey(e => e.MorId)
                    .HasName("PRIMARY");

                entity.ToTable("recl_mov");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.MorIdrec, "fk_recl_mov_reclamos1_idx");

                entity.Property(e => e.MorId)
                    .HasColumnName("MOR_ID")
                    .HasComment("Id movimiento");

                entity.Property(e => e.MorDescri)
                    .HasMaxLength(300)
                    .HasColumnName("MOR_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.MorFecmov)
                    .HasColumnType("date")
                    .HasColumnName("MOR_FECMOV")
                    .HasComment("Fecha Movimiento");

                entity.Property(e => e.MorIdrec)
                    .HasColumnName("MOR_IDREC")
                    .HasComment("Id Reclamo");

                entity.Property(e => e.MorTipmov)
                    .HasMaxLength(30)
                    .HasColumnName("MOR_TIPMOV")
                    .HasComment("Tipo Movimiento");

                entity.HasOne(d => d.MorIdrecNavigation)
                    .WithMany(p => p.ReclMovs)
                    .HasForeignKey(d => d.MorIdrec)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_recl_mov_reclamos1");
            });

            modelBuilder.Entity<Reclamo>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PRIMARY");

                entity.ToTable("reclamos");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.RecCodart, "fk_reclamos_articulos_idx");

                entity.HasIndex(e => e.RecCodcli, "fk_reclamos_clientes1_idx");

                entity.HasIndex(e => e.RecCodpro, "fk_reclamos_proveedores");

                entity.Property(e => e.RecId)
                    .HasColumnName("REC_ID")
                    .HasComment("Id");

                entity.Property(e => e.RecCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("REC_CANTID")
                    .HasComment("Cantidad");

                entity.Property(e => e.RecCodart)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("REC_CODART")
                    .HasDefaultValueSql("''")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.RecCodcli)
                    .HasPrecision(6)
                    .HasColumnName("REC_CODCLI");

                entity.Property(e => e.RecCodpro).HasColumnName("REC_CODPRO");

                entity.Property(e => e.RecDescri)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("REC_DESCRI")
                    .HasDefaultValueSql("''")
                    .HasComment("Descripcion del producto");

                entity.Property(e => e.RecDetall)
                    .HasMaxLength(500)
                    .HasColumnName("REC_DETALL")
                    .HasComment("Detalle de la falla");

                entity.Property(e => e.RecEstado)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("REC_ESTADO")
                    .HasDefaultValueSql("''")
                    .HasComment("Estado del Reclamo: \n\nPENDIENTE ENVIO\nPENDIENTE REPARACION\n\nENVIADO\nREPARADO\nSIN POSIBILIDAD REPARAR\n\nRECIBIDO REPARADO\nRECIBIDO NUEVO\nRECIBIDO SIN SOLUCION\n\nENTREGADO REPARADO\nENTREGADO NUEVO\nDESECHADO");

                entity.Property(e => e.RecFecha)
                    .HasColumnType("date")
                    .HasColumnName("REC_FECHA")
                    .HasComment("Fecha Reclamo");

                entity.Property(e => e.RecGarant)
                    .HasColumnType("bit(1)")
                    .HasColumnName("REC_GARANT")
                    .HasDefaultValueSql("b'0'")
                    .HasComment("Garantia SI-NO\n");

                entity.Property(e => e.RecInfrep)
                    .HasMaxLength(500)
                    .HasColumnName("REC_INFREP");

                entity.Property(e => e.RecNrocom)
                    .HasPrecision(12)
                    .HasColumnName("REC_NROCOM");

                entity.Property(e => e.RecNumero)
                    .HasPrecision(12)
                    .HasColumnName("REC_NUMERO")
                    .HasComment("Nro reclamo-reparacion");

                entity.Property(e => e.RecPrflete)
                    .HasPrecision(11, 2)
                    .HasColumnName("REC_PRFLETE")
                    .HasComment("Precio flete");

                entity.Property(e => e.RecPrrepa)
                    .HasPrecision(11, 2)
                    .HasColumnName("REC_PRREPA")
                    .HasComment("Precio Reparacion");

                entity.Property(e => e.RecPrrepu)
                    .HasPrecision(11, 2)
                    .HasColumnName("REC_PRREPU")
                    .HasComment("Precio Repuestos");

                entity.Property(e => e.RecPrtota)
                    .HasPrecision(13, 2)
                    .HasColumnName("REC_PRTOTA")
                    .HasComment("Precio Total");

                entity.Property(e => e.RecTipcom).HasColumnName("REC_TIPCOM");

                entity.Property(e => e.RecTratam)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("REC_TRATAM")
                    .HasDefaultValueSql("' '")
                    .HasComment("Revision interna o envio 'INT' - 'ENV'");

                entity.HasOne(d => d.RecCodartNavigation)
                    .WithMany(p => p.Reclamos)
                    .HasForeignKey(d => d.RecCodart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reclamos_articulos");

                entity.HasOne(d => d.RecCodcliNavigation)
                    .WithMany(p => p.Reclamos)
                    .HasForeignKey(d => d.RecCodcli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reclamos_clientes1");

                entity.HasOne(d => d.RecCodproNavigation)
                    .WithMany(p => p.Reclamos)
                    .HasForeignKey(d => d.RecCodpro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reclamos_proveedores");
            });

            modelBuilder.Entity<Reglapre>(entity =>
            {
                entity.HasKey(e => e.RepCodreg)
                    .HasName("PRIMARY");

                entity.ToTable("reglapre");

                entity.HasComment("Reglas de precios")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.RepCodsru, "fk_precios_r_Subrubros1");

                entity.HasIndex(e => e.RepCodart, "fk_precios_r_articulos1");

                entity.HasIndex(e => e.RepCodlin, "fk_precios_r_lineas1");

                entity.HasIndex(e => e.RepCodmar, "fk_precios_r_marcas1");

                entity.HasIndex(e => e.RepCodrub, "fk_precios_r_rubros1");

                entity.Property(e => e.RepCodreg)
                    .ValueGeneratedNever()
                    .HasColumnName("REP_CODREG");

                entity.Property(e => e.RepCodart)
                    .HasMaxLength(15)
                    .HasColumnName("REP_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.RepCodlin)
                    .HasMaxLength(4)
                    .HasColumnName("REP_CODLIN")
                    .HasComment("Codigo de linea");

                entity.Property(e => e.RepCodmar)
                    .HasMaxLength(15)
                    .HasColumnName("REP_CODMAR")
                    .HasComment("Codigo de marca");

                entity.Property(e => e.RepCodrub)
                    .HasMaxLength(15)
                    .HasColumnName("REP_CODRUB")
                    .HasComment("Codigo de Rubro");

                entity.Property(e => e.RepCodsru)
                    .HasMaxLength(15)
                    .HasColumnName("REP_CODSRU")
                    .HasComment("Codigo de subrubro");

                entity.Property(e => e.RepDesreg)
                    .HasMaxLength(40)
                    .HasColumnName("REP_DESREG")
                    .HasComment("Descripcion");

                entity.Property(e => e.RepNivel)
                    .HasColumnName("REP_NIVEL")
                    .HasComment("Nivel (para el cálculo)");

                entity.Property(e => e.RepObserv)
                    .HasMaxLength(30)
                    .HasColumnName("REP_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.RepUtilid)
                    .HasPrecision(6, 2)
                    .HasColumnName("REP_UTILID")
                    .HasComment("Porcentaje de utilidad");

                entity.HasOne(d => d.RepCodartNavigation)
                    .WithMany(p => p.Reglapres)
                    .HasForeignKey(d => d.RepCodart)
                    .HasConstraintName("fk_precios_r_articulos1");

                entity.HasOne(d => d.RepCodlinNavigation)
                    .WithMany(p => p.Reglapres)
                    .HasForeignKey(d => d.RepCodlin)
                    .HasConstraintName("fk_precios_r_lineas1");

                entity.HasOne(d => d.RepCodmarNavigation)
                    .WithMany(p => p.Reglapres)
                    .HasForeignKey(d => d.RepCodmar)
                    .HasConstraintName("fk_precios_r_marcas1");

                entity.HasOne(d => d.RepCodrubNavigation)
                    .WithMany(p => p.Reglapres)
                    .HasForeignKey(d => d.RepCodrub)
                    .HasConstraintName("fk_precios_r_rubros1");

                entity.HasOne(d => d.RepCodsruNavigation)
                    .WithMany(p => p.Reglapres)
                    .HasForeignKey(d => d.RepCodsru)
                    .HasConstraintName("fk_precios_r_Subrubros1");
            });

            modelBuilder.Entity<Remitosc>(entity =>
            {
                entity.HasKey(e => new { e.RccNrorem, e.RccCodpro })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("remitosc");

                entity.HasComment("Remitos de compra - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.RccNrorem)
                    .HasPrecision(12)
                    .HasColumnName("RCC_NROREM")
                    .HasComment("Numero de remito");

                entity.Property(e => e.RccCodpro)
                    .HasPrecision(6)
                    .HasColumnName("RCC_CODPRO")
                    .HasComment("Cod. de proveedor");

                entity.Property(e => e.RccAcopio)
                    .HasColumnName("RCC_ACOPIO")
                    .HasComment("Remito de Acopio: 0=NO, 1=Acopio de Dinero, 2:Acopio de mercaderías.");

                entity.Property(e => e.RccBonif1)
                    .HasPrecision(13, 2)
                    .HasColumnName("RCC_BONIF1")
                    .HasComment("bonfiicacion 1");

                entity.Property(e => e.RccBonif2)
                    .HasPrecision(13, 2)
                    .HasColumnName("RCC_BONIF2")
                    .HasComment("bonificacion 2");

                entity.Property(e => e.RccCodcpa)
                    .HasColumnName("RCC_CODCPA")
                    .HasComment("Codigo condicion de pago");

                entity.Property(e => e.RccCoddep)
                    .HasColumnName("RCC_CODDEP")
                    .HasComment("Codigo de deposito");

                entity.Property(e => e.RccCodlis)
                    .HasColumnName("RCC_CODLIS")
                    .HasComment("Codigo de lista de precios utilizada");

                entity.Property(e => e.RccCodtra)
                    .HasColumnName("RCC_CODTRA")
                    .HasComment("Codigo de transportista");

                entity.Property(e => e.RccCodusu)
                    .HasColumnName("RCC_CODUSU")
                    .HasComment("id usuario");

                entity.Property(e => e.RccCodven)
                    .HasColumnName("RCC_CODVEN")
                    .HasComment("Codigo de vendedor");

                entity.Property(e => e.RccDtogen)
                    .HasPrecision(13, 2)
                    .HasColumnName("RCC_DTOGEN")
                    .HasComment("Importe dto. gral. comprobante");

                entity.Property(e => e.RccDtogep)
                    .HasPrecision(5, 2)
                    .HasColumnName("RCC_DTOGEP")
                    .HasComment("Porcentaje dto. general");

                entity.Property(e => e.RccEstado)
                    .HasMaxLength(10)
                    .HasColumnName("RCC_ESTADO")
                    .HasComment("Estado del pedido ABIERTO, CERRADO, ANULADO");

                entity.Property(e => e.RccFecrem)
                    .HasColumnType("date")
                    .HasColumnName("RCC_FECREM")
                    .HasComment("Fecha de remito");

                entity.Property(e => e.RccImpivg)
                    .HasPrecision(13, 2)
                    .HasColumnName("RCC_IMPIVG")
                    .HasComment("Importe iva general");

                entity.Property(e => e.RccImpivr)
                    .HasPrecision(13, 2)
                    .HasColumnName("RCC_IMPIVR")
                    .HasComment("Importe iva reducido");

                entity.Property(e => e.RccImpnet)
                    .HasPrecision(13, 2)
                    .HasColumnName("RCC_IMPNET")
                    .HasComment("Importe neto");

                entity.Property(e => e.RccImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("RCC_IMPORT")
                    .HasComment("Importe antes de bonificaciones");

                entity.Property(e => e.RccImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("RCC_IMPTOT")
                    .HasComment("Importe total");

                entity.Property(e => e.RccLeyend)
                    .HasMaxLength(100)
                    .HasColumnName("RCC_LEYEND");

                entity.Property(e => e.RccLugent)
                    .HasMaxLength(45)
                    .HasColumnName("RCC_LUGENT")
                    .HasComment("lugar de entrega");

                entity.Property(e => e.RccNrofac)
                    .HasPrecision(12)
                    .HasColumnName("RCC_NROFAC")
                    .HasComment("Nro de factura");

                entity.Property(e => e.RccNrooco)
                    .HasMaxLength(12)
                    .HasColumnName("RCC_NROOCO")
                    .HasComment("Nro orden de compra");

                entity.Property(e => e.RccNroped)
                    .HasPrecision(12)
                    .HasColumnName("RCC_NROPED")
                    .HasComment("Nro de pedido");

                entity.Property(e => e.RccNropre)
                    .HasPrecision(12)
                    .HasColumnName("RCC_NROPRE")
                    .HasComment("Nro de presupuesto");

                entity.Property(e => e.RccObserv)
                    .HasMaxLength(45)
                    .HasColumnName("RCC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<RemitoscDet>(entity =>
            {
                entity.HasKey(e => new { e.RcdNrorem, e.RcdCodpro, e.RcdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("remitosc_det");

                entity.HasComment("Remitos de compra - detalle")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => new { e.RcdNrorem, e.RcdCodpro }, "fk_remitosc_det_remitosc1");

                entity.Property(e => e.RcdNrorem)
                    .HasPrecision(12)
                    .HasColumnName("RCD_NROREM")
                    .HasComment("Nro Remito");

                entity.Property(e => e.RcdCodpro)
                    .HasPrecision(6)
                    .HasColumnName("RCD_CODPRO")
                    .HasComment("Codigo de Proveedor");

                entity.Property(e => e.RcdNrolin)
                    .HasColumnName("RCD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.RcdBonif1)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_BONIF1")
                    .HasComment("% Bonificacion 1");

                entity.Property(e => e.RcdBonif2)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_BONIF2")
                    .HasComment("% Bonificacion 2");

                entity.Property(e => e.RcdCandev)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_CANDEV")
                    .HasComment("Cantidad devuelta");

                entity.Property(e => e.RcdCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_CANTID")
                    .HasComment("Cantidad ");

                entity.Property(e => e.RcdCodart)
                    .HasMaxLength(15)
                    .HasColumnName("RCD_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.RcdCodori)
                    .HasMaxLength(20)
                    .HasColumnName("RCD_CODORI")
                    .HasComment("Codigo original del articulo");

                entity.Property(e => e.RcdDescri)
                    .HasMaxLength(40)
                    .HasColumnName("RCD_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.RcdEstado)
                    .HasMaxLength(10)
                    .HasColumnName("RCD_ESTADO")
                    .HasComment("Estado de la linea, ABIERTO,CERRADO,ANULADO");

                entity.Property(e => e.RcdImpivg)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_IMPIVG")
                    .HasComment("Importe Iva general");

                entity.Property(e => e.RcdImpivr)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_IMPIVR")
                    .HasComment("Importe Iva reducido");

                entity.Property(e => e.RcdImpnet)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_IMPNET")
                    .HasComment("Importe neto unitario");

                entity.Property(e => e.RcdImptot)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_IMPTOT")
                    .HasComment("Importe total");

                entity.Property(e => e.RcdLinaco)
                    .HasColumnName("RCD_LINACO")
                    .HasComment("Linea del acopio");

                entity.Property(e => e.RcdNrofac)
                    .HasPrecision(12)
                    .HasColumnName("RCD_NROFAC")
                    .HasComment("Nro. de factura");

                entity.Property(e => e.RcdNrolpe)
                    .HasColumnName("RCD_NROLPE")
                    .HasComment("Nro linea de pedido");

                entity.Property(e => e.RcdNroped)
                    .HasPrecision(12)
                    .HasColumnName("RCD_NROPED")
                    .HasComment("Nro. de pedido");

                entity.Property(e => e.RcdNropre)
                    .HasPrecision(12)
                    .HasColumnName("RCD_NROPRE")
                    .HasComment("Nro presupuesto");

                entity.Property(e => e.RcdObserv)
                    .HasMaxLength(45)
                    .HasColumnName("RCD_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.RcdPrecio)
                    .HasPrecision(11, 2)
                    .HasColumnName("RCD_PRECIO")
                    .HasComment("Precio unitario");

                entity.Property(e => e.RcdTipaco)
                    .HasMaxLength(15)
                    .HasColumnName("RCD_TIPACO")
                    .HasComment("Tipo de acondicionamiento");

                entity.Property(e => e.RcdUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("RCD_UNIMED")
                    .HasComment("Unidad de medida");

                entity.Property(e => e.RcdValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("RCD_VALIVA")
                    .HasComment("ALICIUOTA IVA");

                entity.HasOne(d => d.Rcd)
                    .WithMany(p => p.RemitoscDets)
                    .HasForeignKey(d => new { d.RcdNrorem, d.RcdCodpro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_remitosc_det_remitosc1");
            });

            modelBuilder.Entity<Remitosv>(entity =>
            {
                entity.HasKey(e => e.RvcNrorem)
                    .HasName("PRIMARY");

                entity.ToTable("remitosv");

                entity.HasComment("Presupuestos - cabecera")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.RvcNrorem)
                    .HasPrecision(12)
                    .HasColumnName("RVC_NROREM")
                    .HasComment("Numero de remito");

                entity.Property(e => e.RvcAcopio)
                    .HasColumnName("RVC_ACOPIO")
                    .HasComment("Remito de Acopio: 0=NO, 1=Acopio de Dinero, 2:Acopio de mercaderías.");

                entity.Property(e => e.RvcBonif1)
                    .HasPrecision(13, 2)
                    .HasColumnName("RVC_BONIF1")
                    .HasComment("bonfiicacion 1");

                entity.Property(e => e.RvcBonif2)
                    .HasPrecision(13, 2)
                    .HasColumnName("RVC_BONIF2")
                    .HasComment("bonificacion 2");

                entity.Property(e => e.RvcCodcli)
                    .HasPrecision(6)
                    .HasColumnName("RVC_CODCLI")
                    .HasComment("Cod. de cliente");

                entity.Property(e => e.RvcCodcpa)
                    .HasColumnName("RVC_CODCPA")
                    .HasComment("Codigo Condicion de pago");

                entity.Property(e => e.RvcCoddep)
                    .HasColumnName("RVC_CODDEP")
                    .HasComment("Codigo de deposito");

                entity.Property(e => e.RvcCodlis)
                    .HasColumnName("RVC_CODLIS")
                    .HasComment("Codigo de lista de precios utilizada");

                entity.Property(e => e.RvcCodtra)
                    .HasColumnName("RVC_CODTRA")
                    .HasComment("Codigo de transportista");

                entity.Property(e => e.RvcCodusu)
                    .HasColumnName("RVC_CODUSU")
                    .HasComment("Codigo de Usuario");

                entity.Property(e => e.RvcCodven)
                    .HasColumnName("RVC_CODVEN")
                    .HasComment("Codigo de vendedor");

                entity.Property(e => e.RvcDtogen)
                    .HasPrecision(13, 2)
                    .HasColumnName("RVC_DTOGEN")
                    .HasComment("Importe dto. gral. comprobante");

                entity.Property(e => e.RvcDtogep)
                    .HasPrecision(5, 2)
                    .HasColumnName("RVC_DTOGEP")
                    .HasComment("Porcentaje dto. general");

                entity.Property(e => e.RvcEstado)
                    .HasMaxLength(10)
                    .HasColumnName("RVC_ESTADO")
                    .HasComment("Estado del pedido ABIERTO, CERRADO, ANULADO");

                entity.Property(e => e.RvcFecrem)
                    .HasColumnType("date")
                    .HasColumnName("RVC_FECREM")
                    .HasComment("Fecha de remito");

                entity.Property(e => e.RvcImpivg)
                    .HasPrecision(13, 2)
                    .HasColumnName("RVC_IMPIVG")
                    .HasComment("Importe iva general");

                entity.Property(e => e.RvcImpivr)
                    .HasPrecision(13, 2)
                    .HasColumnName("RVC_IMPIVR")
                    .HasComment("Importe iva reducido");

                entity.Property(e => e.RvcImpnet)
                    .HasPrecision(13, 2)
                    .HasColumnName("RVC_IMPNET")
                    .HasComment("Importe neto");

                entity.Property(e => e.RvcImport)
                    .HasPrecision(13, 2)
                    .HasColumnName("RVC_IMPORT")
                    .HasComment("Importe antes de bonificaciones");

                entity.Property(e => e.RvcImptot)
                    .HasPrecision(13, 2)
                    .HasColumnName("RVC_IMPTOT")
                    .HasComment("Importe total");

                entity.Property(e => e.RvcLeyend)
                    .HasMaxLength(100)
                    .HasColumnName("RVC_LEYEND");

                entity.Property(e => e.RvcLugent)
                    .HasMaxLength(45)
                    .HasColumnName("RVC_LUGENT")
                    .HasComment("lugar de entrega");

                entity.Property(e => e.RvcNrofac)
                    .HasPrecision(12)
                    .HasColumnName("RVC_NROFAC")
                    .HasComment("Nro de factura");

                entity.Property(e => e.RvcNrooco)
                    .HasMaxLength(20)
                    .HasColumnName("RVC_NROOCO")
                    .HasComment("Nro orden de compra");

                entity.Property(e => e.RvcNroped)
                    .HasPrecision(12)
                    .HasColumnName("RVC_NROPED")
                    .HasComment("Nro de pedido");

                entity.Property(e => e.RvcNropre)
                    .HasPrecision(12)
                    .HasColumnName("RVC_NROPRE")
                    .HasComment("Nro de presupuesto");

                entity.Property(e => e.RvcObserv)
                    .HasMaxLength(45)
                    .HasColumnName("RVC_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<RemitosvDet>(entity =>
            {
                entity.HasKey(e => new { e.RvdNrorem, e.RvdNrolin })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("remitosv_det");

                entity.HasComment("Presupuestos - detalle")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.RvdNrorem, "fk_pedidos_detalle_pedidos");

                entity.Property(e => e.RvdNrorem)
                    .HasPrecision(12)
                    .HasColumnName("RVD_NROREM")
                    .HasComment("Número");

                entity.Property(e => e.RvdNrolin)
                    .HasColumnName("RVD_NROLIN")
                    .HasComment("Nro de linea");

                entity.Property(e => e.RvdBonif1)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_BONIF1")
                    .HasComment("% Bonificacion 1");

                entity.Property(e => e.RvdBonif2)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_BONIF2")
                    .HasComment("% Bonificacion 2");

                entity.Property(e => e.RvdCandev)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_CANDEV")
                    .HasComment("Cantidad devuelta");

                entity.Property(e => e.RvdCantid)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_CANTID")
                    .HasComment("Cantidad ");

                entity.Property(e => e.RvdCodart)
                    .HasMaxLength(15)
                    .HasColumnName("RVD_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.RvdDescri)
                    .HasMaxLength(40)
                    .HasColumnName("RVD_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.RvdEstado)
                    .HasMaxLength(10)
                    .HasColumnName("RVD_ESTADO")
                    .HasComment("Estado de la linea, ABIERTO,CERRADO,ANULADO");

                entity.Property(e => e.RvdImpivg)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_IMPIVG")
                    .HasComment("Importe Iva general");

                entity.Property(e => e.RvdImpivr)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_IMPIVR")
                    .HasComment("Importe Iva reducido");

                entity.Property(e => e.RvdImpnet)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_IMPNET")
                    .HasComment("Importe neto unitario");

                entity.Property(e => e.RvdImptot)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_IMPTOT")
                    .HasComment("Importe total");

                entity.Property(e => e.RvdLinaco)
                    .HasColumnName("RVD_LINACO")
                    .HasComment("Linea del acondicionamiento");

                entity.Property(e => e.RvdNrofac)
                    .HasPrecision(12)
                    .HasColumnName("RVD_NROFAC")
                    .HasComment("Nro. de factura");

                entity.Property(e => e.RvdNrolpe)
                    .HasColumnName("RVD_NROLPE")
                    .HasComment("Nro linea de pedido");

                entity.Property(e => e.RvdNroped)
                    .HasPrecision(12)
                    .HasColumnName("RVD_NROPED")
                    .HasComment("Nro. de pedido");

                entity.Property(e => e.RvdNropre)
                    .HasPrecision(12)
                    .HasColumnName("RVD_NROPRE")
                    .HasComment("Nro presupuesto");

                entity.Property(e => e.RvdObserv)
                    .HasMaxLength(45)
                    .HasColumnName("RVD_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.RvdPrecio)
                    .HasPrecision(11, 2)
                    .HasColumnName("RVD_PRECIO")
                    .HasComment("Precio unitario");

                entity.Property(e => e.RvdUnimed)
                    .HasMaxLength(6)
                    .HasColumnName("RVD_UNIMED")
                    .HasComment("Unidad de medida");

                entity.Property(e => e.RvdValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("RVD_VALIVA")
                    .HasComment("Alicuota de IVA");

                entity.HasOne(d => d.RvdNroremNavigation)
                    .WithMany(p => p.RemitosvDets)
                    .HasForeignKey(d => d.RvdNrorem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pedidos_detalle_pedidos1");
            });

            modelBuilder.Entity<RetClient>(entity =>
            {
                entity.HasKey(e => e.RtcNromov)
                    .HasName("PRIMARY");

                entity.ToTable("ret_client");

                entity.HasComment("Retenciones de clientes")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.RtcCodcli, "fk_ret_client_clientes_idx");

                entity.HasIndex(e => e.RtcCodret, "fk_ret_client_retenciones1");

                entity.Property(e => e.RtcNromov).HasColumnName("RTC_NROMOV");

                entity.Property(e => e.RtcCodcli)
                    .HasPrecision(6)
                    .HasColumnName("RTC_CODCLI")
                    .HasComment("Codigo de cliente");

                entity.Property(e => e.RtcCodret).HasColumnName("RTC_CODRET");

                entity.Property(e => e.RtcFecmov)
                    .HasColumnType("date")
                    .HasColumnName("RTC_FECMOV")
                    .HasComment("Fecha de movimento");

                entity.Property(e => e.RtcFecret)
                    .HasColumnType("date")
                    .HasColumnName("RTC_FECRET")
                    .HasComment("Fecha de retencion");

                entity.Property(e => e.RtcImpret)
                    .HasPrecision(13, 2)
                    .HasColumnName("RTC_IMPRET")
                    .HasComment("Importe de retencion");

                entity.Property(e => e.RtcNrorec)
                    .HasPrecision(12)
                    .HasColumnName("RTC_NROREC")
                    .HasComment("Nro. de recibo");

                entity.Property(e => e.RtcNroret)
                    .HasColumnName("RTC_NRORET")
                    .HasComment("Nro de retencion");

                entity.HasOne(d => d.RtcCodcliNavigation)
                    .WithMany(p => p.RetClients)
                    .HasForeignKey(d => d.RtcCodcli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ret_client_clientes");

                entity.HasOne(d => d.RtcCodretNavigation)
                    .WithMany(p => p.RetClients)
                    .HasForeignKey(d => d.RtcCodret)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ret_client_retenciones1");
            });

            modelBuilder.Entity<RetProvee>(entity =>
            {
                entity.HasKey(e => e.Rtpnromov)
                    .HasName("PRIMARY");

                entity.ToTable("ret_provee");

                entity.HasComment("Retenciones  Proveedores")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.RtpCodpro, "fk_ret_client_PROVEEDORES_idx");

                entity.HasIndex(e => e.RtpCodret, "fk_ret_client_retenciones1");

                entity.Property(e => e.Rtpnromov).HasColumnName("RTPNROMOV");

                entity.Property(e => e.RtpCodpro)
                    .HasColumnName("RTP_CODPRO")
                    .HasComment("Codigo de cliente");

                entity.Property(e => e.RtpCodret).HasColumnName("RTP_CODRET");

                entity.Property(e => e.RtpFecmov)
                    .HasColumnType("date")
                    .HasColumnName("RTP_FECMOV")
                    .HasComment("Fecha de movimento");

                entity.Property(e => e.RtpFecret)
                    .HasColumnType("date")
                    .HasColumnName("RTP_FECRET")
                    .HasComment("Fecha de retencion");

                entity.Property(e => e.RtpImpret)
                    .HasPrecision(13, 2)
                    .HasColumnName("RTP_IMPRET")
                    .HasComment("Importe de retencion");

                entity.Property(e => e.RtpNrofac)
                    .HasPrecision(12)
                    .HasColumnName("RTP_NROFAC")
                    .HasComment("Nro de factura");

                entity.Property(e => e.RtpNrorec)
                    .HasPrecision(12)
                    .HasColumnName("RTP_NROREC")
                    .HasComment("Nro. de recibo");

                entity.Property(e => e.RtpNroret)
                    .HasColumnName("RTP_NRORET")
                    .HasComment("Nro de retencion");

                entity.HasOne(d => d.RtpCodproNavigation)
                    .WithMany(p => p.RetProvees)
                    .HasForeignKey(d => d.RtpCodpro)
                    .HasConstraintName("fk_ret_client_PROVEEDORES");

                entity.HasOne(d => d.RtpCodretNavigation)
                    .WithMany(p => p.RetProvees)
                    .HasForeignKey(d => d.RtpCodret)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ret_client_retenciones10");
            });

            modelBuilder.Entity<Retencione>(entity =>
            {
                entity.HasKey(e => e.RetCodret)
                    .HasName("PRIMARY");

                entity.ToTable("retenciones");

                entity.HasComment("tipos de retenciones")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.RetCodret)
                    .ValueGeneratedNever()
                    .HasColumnName("RET_CODRET")
                    .HasComment("Codigo de retencion");

                entity.Property(e => e.RetCtacon)
                    .HasMaxLength(15)
                    .HasColumnName("RET_CTACON")
                    .HasComment("Cuenta contable");

                entity.Property(e => e.RetDescri)
                    .HasMaxLength(40)
                    .HasColumnName("RET_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.RetObserv)
                    .HasMaxLength(40)
                    .HasColumnName("RET_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.RetPorcen)
                    .HasPrecision(5, 2)
                    .HasColumnName("RET_PORCEN")
                    .HasComment("Porcentaje");
            });

            modelBuilder.Entity<Rubro>(entity =>
            {
                entity.HasKey(e => e.RubCodrub)
                    .HasName("PRIMARY");

                entity.ToTable("rubros");

                entity.HasComment("Rubros")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.RubIdweb, "IdWeb")
                    .IsUnique();

                entity.Property(e => e.RubCodrub)
                    .HasMaxLength(15)
                    .HasColumnName("RUB_CODRUB")
                    .HasDefaultValueSql("''")
                    .HasComment("Codigo de rubro");

                entity.Property(e => e.RubActivo)
                    .HasColumnName("RUB_ACTIVO")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Activo");

                entity.Property(e => e.RubDescri)
                    .HasMaxLength(30)
                    .HasColumnName("RUB_DESCRI")
                    .HasComment("Descripcion");

                entity.Property(e => e.RubIdweb)
                    .HasColumnName("RUB_IDWEB")
                    .HasComment("Id");

                entity.Property(e => e.RubObserv)
                    .HasMaxLength(45)
                    .HasColumnName("RUB_OBSERV")
                    .HasComment("Observaciones");
            });

            modelBuilder.Entity<SgiGrup>(entity =>
            {
                entity.HasKey(e => new { e.Cgr, e.Csg })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("sgi_grup");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.Cgr)
                    .HasMaxLength(15)
                    .HasColumnName("CGR");

                entity.Property(e => e.Csg)
                    .HasMaxLength(15)
                    .HasColumnName("CSG");

                entity.Property(e => e.Ngr)
                    .HasMaxLength(40)
                    .HasColumnName("NGR");

                entity.Property(e => e.Nsg)
                    .HasMaxLength(40)
                    .HasColumnName("NSG");

                entity.Property(e => e.Obs)
                    .HasMaxLength(45)
                    .HasColumnName("OBS");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("stock");

                entity.HasComment("Copia articulos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.ArtCodart, "fk_stock_articulos_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArtCanped)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_CANPED")
                    .HasComment("Cantidad de articulos pedidos");

                entity.Property(e => e.ArtCcocom)
                    .HasMaxLength(10)
                    .HasColumnName("ART_CCOCOM")
                    .HasComment("Centro de costo compras");

                entity.Property(e => e.ArtCcovta)
                    .HasMaxLength(10)
                    .HasColumnName("ART_CCOVTA")
                    .HasComment("Centro de costos venta");

                entity.Property(e => e.ArtCodart)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODART")
                    .HasComment("Codigo de articulo");

                entity.Property(e => e.ArtCodbar)
                    .HasMaxLength(20)
                    .HasColumnName("ART_CODBAR")
                    .HasComment("Codigo de barras");

                entity.Property(e => e.ArtCodlin)
                    .HasMaxLength(4)
                    .HasColumnName("ART_CODLIN")
                    .HasComment("Codigo de linea");

                entity.Property(e => e.ArtCodmar)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODMAR")
                    .HasComment("Codigo de marca");

                entity.Property(e => e.ArtCodmon)
                    .HasColumnName("ART_CODMON")
                    .HasComment("Codigo de  moneda");

                entity.Property(e => e.ArtCodori)
                    .HasMaxLength(20)
                    .HasColumnName("ART_CODORI")
                    .HasComment("Codigo del fabricante");

                entity.Property(e => e.ArtCodpro)
                    .HasColumnName("ART_CODPRO")
                    .HasComment("Cod. de proveedor");

                entity.Property(e => e.ArtCodrub)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODRUB");

                entity.Property(e => e.ArtCodsru)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CODSRU")
                    .HasComment("Codigo de subrubro");

                entity.Property(e => e.ArtCodtar)
                    .HasColumnName("ART_CODTAR")
                    .HasComment("Codigo tpo de articulo ");

                entity.Property(e => e.ArtCoefcv)
                    .HasColumnName("ART_COEFCV")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Coeficiente unidad de compra unidad de venta");

                entity.Property(e => e.ArtCompue)
                    .HasColumnName("ART_COMPUE")
                    .HasComment("Articulo Compuesto - Si es true");

                entity.Property(e => e.ArtComvta)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_COMVTA")
                    .HasComment("Comisión s/ventas");

                entity.Property(e => e.ArtCtacom)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CTACOM")
                    .HasComment("Cuenta contable p compras");

                entity.Property(e => e.ArtCtavta)
                    .HasMaxLength(15)
                    .HasColumnName("ART_CTAVTA")
                    .HasComment("Cuenta contable p ventas");

                entity.Property(e => e.ArtDescri)
                    .HasMaxLength(40)
                    .HasColumnName("ART_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.ArtDescrl)
                    .HasMaxLength(100)
                    .HasColumnName("ART_DESCRL")
                    .HasComment("Descripción larga");

                entity.Property(e => e.ArtDiscon)
                    .HasColumnName("ART_DISCON")
                    .HasComment("Producto discontinuado");

                entity.Property(e => e.ArtDispon)
                    .HasColumnName("ART_DISPON")
                    .HasComment("Art. disponible p/comercialización");

                entity.Property(e => e.ArtDtocom)
                    .HasPrecision(5, 2)
                    .HasColumnName("ART_DTOCOM")
                    .HasComment("Descuento s/precio de lista en compras");

                entity.Property(e => e.ArtDtovta)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_DTOVTA")
                    .HasComment("Descuento p /ventas");

                entity.Property(e => e.ArtEmbala)
                    .HasColumnName("ART_EMBALA")
                    .HasComment("Embalaje");

                entity.Property(e => e.ArtEquiva)
                    .HasColumnName("ART_EQUIVA")
                    .HasComment("articulo con equivalencias: 0=no, 1=si");

                entity.Property(e => e.ArtImagen)
                    .HasMaxLength(60)
                    .HasColumnName("ART_IMAGEN")
                    .HasComment("Dirección de imgen asociada");

                entity.Property(e => e.ArtImpues)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_IMPUES")
                    .HasComment("Impuesto interno sobre el articulo");

                entity.Property(e => e.ArtObserv)
                    .HasMaxLength(50)
                    .HasColumnName("ART_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.ArtPrecos)
                    .HasPrecision(13, 3)
                    .HasColumnName("ART_PRECOS")
                    .HasComment("Precio de costo s/iva");

                entity.Property(e => e.ArtPromoc)
                    .HasColumnName("ART_PROMOC")
                    .HasComment("Articulo en promocion: 0=no, 1=si");

                entity.Property(e => e.ArtStoact)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_STOACT")
                    .HasComment("Cantidad en stock actual");

                entity.Property(e => e.ArtStocom)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_STOCOM")
                    .HasComment("Stock comprometido");

                entity.Property(e => e.ArtStomax)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_STOMAX")
                    .HasComment("Stock maximo");

                entity.Property(e => e.ArtStomin)
                    .HasPrecision(13, 2)
                    .HasColumnName("ART_STOMIN")
                    .HasComment("Stock minimo");

                entity.Property(e => e.ArtTipimp)
                    .HasColumnName("ART_TIPIMP")
                    .HasComment("Tipo de impuesto: 0=importe fijo, 1=porcentual");

                entity.Property(e => e.ArtUltact)
                    .HasColumnType("date")
                    .HasColumnName("ART_ULTACT")
                    .HasComment("Fecha ultima actualización");

                entity.Property(e => e.ArtUltcom)
                    .HasColumnType("date")
                    .HasColumnName("ART_ULTCOM")
                    .HasComment("Fecha ultima compra");

                entity.Property(e => e.ArtUmcomp)
                    .HasMaxLength(6)
                    .HasColumnName("ART_UMCOMP")
                    .HasComment("Unidad de medida p/compra");

                entity.Property(e => e.ArtUmvent)
                    .HasMaxLength(6)
                    .HasColumnName("ART_UMVENT")
                    .HasComment("Unidad de venta");

                entity.Property(e => e.ArtUspart)
                    .HasColumnName("ART_USPART")
                    .HasComment("Usa partida");

                entity.Property(e => e.ArtUsseri)
                    .HasColumnName("ART_USSERI")
                    .HasComment("Usa Nro. de serie");

                entity.Property(e => e.ArtValiva)
                    .HasPrecision(5, 2)
                    .HasColumnName("ART_VALIVA")
                    .HasComment("Porcentaje de IVA");
            });

            modelBuilder.Entity<Subrubro>(entity =>
            {
                entity.HasKey(e => e.SruCodsru)
                    .HasName("PRIMARY");

                entity.ToTable("subrubros");

                entity.HasComment("Subrubros")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.SruIdweb, "IdWeb")
                    .IsUnique();

                entity.HasIndex(e => e.SruCodrub, "fk_Subrubros_rubros1");

                entity.Property(e => e.SruCodsru)
                    .HasMaxLength(15)
                    .HasColumnName("SRU_CODSRU")
                    .HasComment("Codigo de Sub Rubro");

                entity.Property(e => e.SruActivo)
                    .HasColumnName("SRU_ACTIVO")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Activo");

                entity.Property(e => e.SruCodrub)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("SRU_CODRUB")
                    .HasComment("Codigo de rubro");

                entity.Property(e => e.SruDescri)
                    .HasMaxLength(30)
                    .HasColumnName("SRU_DESCRI")
                    .HasComment("Descripción");

                entity.Property(e => e.SruIdweb)
                    .HasColumnName("SRU_IDWEB")
                    .HasComment("Id");

                entity.Property(e => e.SruObserv)
                    .HasMaxLength(45)
                    .HasColumnName("SRU_OBSERV")
                    .HasComment("Observaciones");

                entity.HasOne(d => d.SruCodrubNavigation)
                    .WithMany(p => p.Subrubros)
                    .HasForeignKey(d => d.SruCodrub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Subrubros_rubros1");
            });

            modelBuilder.Entity<Tarea>(entity =>
            {
                entity.HasKey(e => e.TarId)
                    .HasName("PRIMARY");

                entity.ToTable("tareas");

                entity.HasComment("Log de errores")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TarId, "XPKDI_ERR_M")
                    .IsUnique();

                entity.Property(e => e.TarId)
                    .HasColumnType("mediumint unsigned")
                    .HasColumnName("TAR_ID")
                    .HasComment("Id tarea realizada");

                entity.Property(e => e.TarDescri)
                    .HasMaxLength(255)
                    .HasColumnName("TAR_DESCRI")
                    .HasComment("Descripcion tarea");

                entity.Property(e => e.TarFechor)
                    .HasColumnType("timestamp")
                    .HasColumnName("TAR_FECHOR")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("Fecha y hora");

                entity.Property(e => e.TarModulo)
                    .HasMaxLength(12)
                    .HasColumnName("TAR_MODULO")
                    .HasComment("Modulo de la aplicacion");

                entity.Property(e => e.TarPuesto)
                    .HasMaxLength(30)
                    .HasColumnName("TAR_PUESTO")
                    .HasComment("Puesto de trabajo");

                entity.Property(e => e.TarUsuari)
                    .HasMaxLength(10)
                    .HasColumnName("TAR_USUARI")
                    .HasComment("Usuario");
            });

            modelBuilder.Entity<Tarjeta>(entity =>
            {
                entity.HasKey(e => e.TarCodtar)
                    .HasName("PRIMARY");

                entity.ToTable("tarjetas");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TarCodban, "fk_tarjetas_bancos_idx");

                entity.Property(e => e.TarCodtar)
                    .ValueGeneratedNever()
                    .HasColumnName("TAR_CODTAR")
                    .HasComment("Codigo de tarjeta");

                entity.Property(e => e.TarCodban)
                    .HasColumnName("TAR_CODBAN")
                    .HasComment("Codigo de banco");

                entity.Property(e => e.TarDestar)
                    .HasMaxLength(40)
                    .HasColumnName("TAR_DESTAR")
                    .HasComment("Descripcion");

                entity.Property(e => e.TarObserv)
                    .HasMaxLength(40)
                    .HasColumnName("TAR_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.TarTiptar)
                    .HasMaxLength(8)
                    .HasColumnName("TAR_TIPTAR")
                    .HasComment("Tipo de tarjeta: CREDITO/DEBITO");

                entity.HasOne(d => d.TarCodbanNavigation)
                    .WithMany(p => p.Tarjeta)
                    .HasForeignKey(d => d.TarCodban)
                    .HasConstraintName("fk_tarjetas_bancos");
            });

            modelBuilder.Entity<Tarjrec>(entity =>
            {
                entity.HasKey(e => e.TjrIdmovi)
                    .HasName("PRIMARY");

                entity.ToTable("tarjrec");

                entity.HasComment("Pagos con tarjeta recibidos")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.TjrCodcli, "fk_tarjrec_clientes_idx");

                entity.HasIndex(e => e.TjrCodtar, "fk_tarjrec_tarjetas_idx");

                entity.Property(e => e.TjrIdmovi)
                    .HasColumnName("TJR_IDMOVI")
                    .HasComment("Codigo de movimiento");

                entity.Property(e => e.TjrCancuo)
                    .HasColumnName("TJR_CANCUO")
                    .HasComment("Cantidad de cuotas");

                entity.Property(e => e.TjrCodcli)
                    .HasPrecision(6)
                    .HasColumnName("TJR_CODCLI")
                    .HasComment("Cod. cliente que entrega");

                entity.Property(e => e.TjrCodtar)
                    .HasColumnName("TJR_CODTAR")
                    .HasComment("Codigo de tarjeta");

                entity.Property(e => e.TjrCuoacre)
                    .HasColumnName("TJR_CUOACRE")
                    .HasComment("Cantidad de cuotas acreditadas");

                entity.Property(e => e.TjrDescli)
                    .HasMaxLength(40)
                    .HasColumnName("TJR_DESCLI")
                    .HasComment("Descripcion cliente");

                entity.Property(e => e.TjrEstado)
                    .HasMaxLength(12)
                    .HasColumnName("TJR_ESTADO")
                    .HasComment("Estado");

                entity.Property(e => e.TjrFecacr)
                    .HasColumnType("date")
                    .HasColumnName("TJR_FECACR")
                    .HasComment("Fecha de acreditacion");

                entity.Property(e => e.TjrImpacre)
                    .HasPrecision(13, 2)
                    .HasColumnName("TJR_IMPACRE")
                    .HasComment("Importe acreditado");

                entity.Property(e => e.TjrImppgo)
                    .HasPrecision(13, 2)
                    .HasColumnName("TJR_IMPPGO")
                    .HasComment("Importe");

                entity.Property(e => e.TjrNrolot)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("TJR_NROLOT")
                    .HasComment("Codigo de lote");

                entity.Property(e => e.TjrNumaut)
                    .HasColumnName("TJR_NUMAUT")
                    .HasComment("Numero de autorizacion o movimiento");

                entity.Property(e => e.TjrNumcup)
                    .HasMaxLength(15)
                    .HasColumnName("TJR_NUMCUP")
                    .HasComment("Nro de cupon");

                entity.Property(e => e.TjrObserv)
                    .HasMaxLength(40)
                    .HasColumnName("TJR_OBSERV");

                entity.Property(e => e.TjrRespon)
                    .HasMaxLength(40)
                    .HasColumnName("TJR_RESPON")
                    .HasComment("Responsable");

                entity.HasOne(d => d.TjrCodtarNavigation)
                    .WithMany(p => p.Tarjrecs)
                    .HasForeignKey(d => d.TjrCodtar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tarjrec_tarjetas");
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.ToTable("test_table");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.HasIndex(e => e.Name, "name");

                entity.HasIndex(e => e.Other, "other_key");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Other).HasColumnName("other");
            });

            modelBuilder.Entity<Tipoart>(entity =>
            {
                entity.HasKey(e => e.TarCodtar)
                    .HasName("PRIMARY");

                entity.ToTable("tipoart");

                entity.HasComment("Tipo de articulo")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.TarCodtar)
                    .ValueGeneratedNever()
                    .HasColumnName("TAR_CODTAR");

                entity.Property(e => e.TarDescri)
                    .HasMaxLength(20)
                    .HasColumnName("TAR_DESCRI");
            });

            modelBuilder.Entity<Tiposdocumento>(entity =>
            {
                entity.HasKey(e => e.TdoCodtdo)
                    .HasName("PRIMARY");

                entity.ToTable("tiposdocumentos");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.TdoCodtdo)
                    .ValueGeneratedNever()
                    .HasColumnName("TDO_CODTDO")
                    .HasComment("Codigo tipo documento");

                entity.Property(e => e.TdoCodafi)
                    .HasColumnName("TDO_CODAFI")
                    .HasComment("Codigo AFIP");

                entity.Property(e => e.TdoDescri)
                    .HasMaxLength(45)
                    .HasColumnName("TDO_DESCRI")
                    .HasComment("'Descripción'");
            });

            modelBuilder.Entity<Transporte>(entity =>
            {
                entity.HasKey(e => e.TraCodtra)
                    .HasName("PRIMARY");

                entity.ToTable("transportes");

                entity.HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.TraCodtra)
                    .ValueGeneratedNever()
                    .HasColumnName("TRA_CODTRA");

                entity.Property(e => e.TraCelula)
                    .HasMaxLength(15)
                    .HasColumnName("TRA_CELULA");

                entity.Property(e => e.TraContac)
                    .HasMaxLength(40)
                    .HasColumnName("TRA_CONTAC");

                entity.Property(e => e.TraDescri)
                    .HasMaxLength(40)
                    .HasColumnName("TRA_DESCRI");

                entity.Property(e => e.TraDomici)
                    .HasMaxLength(40)
                    .HasColumnName("TRA_DOMICI");

                entity.Property(e => e.TraTelefo)
                    .HasMaxLength(15)
                    .HasColumnName("TRA_TELEFO");

                entity.Property(e => e.TraVehicul)
                    .HasMaxLength(45)
                    .HasColumnName("TRA_VEHICUL")
                    .HasComment("Datos del vehículo");
            });

            modelBuilder.Entity<Unimed>(entity =>
            {
                entity.HasKey(e => e.UmeDescri)
                    .HasName("PRIMARY");

                entity.ToTable("unimed");

                entity.HasComment("Unidades de medida")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.UmeDescri)
                    .HasMaxLength(6)
                    .HasColumnName("UME_DESCRI")
                    .HasComment("Descripción");
            });

            modelBuilder.Entity<UsuaMenu>(entity =>
            {
                entity.HasKey(e => new { e.UymCodmen, e.UymCodusu, e.UymNumopc })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("usua_menu");

                entity.HasComment("Usuarios y menus")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.HasIndex(e => e.UymCodusu, "fk_usua_menu_usuarios_idx");

                entity.Property(e => e.UymCodmen)
                    .HasColumnName("UYM_CODMEN")
                    .HasComment("Codigo de menu");

                entity.Property(e => e.UymCodusu)
                    .HasColumnName("UYM_CODUSU")
                    .HasComment("Codigo de usuario");

                entity.Property(e => e.UymNumopc)
                    .HasColumnName("UYM_NUMOPC")
                    .HasComment("Numero de opcion dentro del menu");

                entity.Property(e => e.UymDesopc)
                    .HasMaxLength(45)
                    .HasColumnName("UYM_DESOPC")
                    .HasComment("descripcion de la opcion");

                entity.Property(e => e.UymNivacc)
                    .HasColumnName("UYM_NIVACC")
                    .HasComment("Nivel de acceso (si hace falta)");

                entity.HasOne(d => d.UymCodmenNavigation)
                    .WithMany(p => p.UsuaMenus)
                    .HasForeignKey(d => d.UymCodmen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usua_menu_menus");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => new { e.UsuCodusu, e.UsuNombre })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("usuarios");

                entity.HasComment("Usuarios del sistema")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.UsuCodusu)
                    .HasColumnName("USU_CODUSU")
                    .HasComment("codigo de usuario");

                entity.Property(e => e.UsuNombre)
                    .HasMaxLength(10)
                    .HasColumnName("USU_NOMBRE")
                    .HasDefaultValueSql("' '")
                    .HasComment("Nombre de acceso al sistema");

                entity.Property(e => e.UsuAccrap)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("USU_ACCRAP")
                    .HasDefaultValueSql("' '")
                    .HasComment("Acceso a Menu Acceso rapido");

                entity.Property(e => e.UsuApeyno)
                    .HasMaxLength(40)
                    .HasColumnName("USU_APEYNO")
                    .HasComment("Apellido y Nombre");

                entity.Property(e => e.UsuCatusu)
                    .HasColumnName("USU_CATUSU")
                    .HasComment("Categoria de usuario");

                entity.Property(e => e.UsuContras)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("USU_CONTRAS")
                    .HasDefaultValueSql("' '")
                    .HasComment("Contraseña");

                entity.Property(e => e.UsuObserv)
                    .HasMaxLength(45)
                    .HasColumnName("USU_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.UsuPin)
                    .HasPrecision(4)
                    .HasColumnName("USU_PIN")
                    .HasComment("Pin");
            });

            modelBuilder.Entity<Vendedore>(entity =>
            {
                entity.HasKey(e => e.VenCodven)
                    .HasName("PRIMARY");

                entity.ToTable("vendedores");

                entity.HasComment("Vendedores")
                    .HasCharSet("utf8")
                    .UseCollation("utf8_general_ci");

                entity.Property(e => e.VenCodven)
                    .ValueGeneratedNever()
                    .HasColumnName("VEN_CODVEN")
                    .HasComment("Codigo de vendedor");

                entity.Property(e => e.VenComisi)
                    .HasPrecision(5, 2)
                    .HasColumnName("VEN_COMISI")
                    .HasComment("Porcent. comision");

                entity.Property(e => e.VenCuil)
                    .HasMaxLength(13)
                    .HasColumnName("VEN_CUIL")
                    .HasComment("CUIL");

                entity.Property(e => e.VenDescri)
                    .HasMaxLength(40)
                    .HasColumnName("VEN_DESCRI")
                    .HasComment("Nombre");

                entity.Property(e => e.VenFecing)
                    .HasColumnType("date")
                    .HasColumnName("VEN_FECING")
                    .HasComment("Fecha de ingreso");

                entity.Property(e => e.VenNroleg)
                    .HasPrecision(10)
                    .HasColumnName("VEN_NROLEG")
                    .HasComment("Nro. de legajo");

                entity.Property(e => e.VenNrotar)
                    .HasPrecision(10)
                    .HasColumnName("VEN_NROTAR")
                    .HasComment("Nro. de tarjeta");

                entity.Property(e => e.VenObserv)
                    .HasMaxLength(45)
                    .HasColumnName("VEN_OBSERV")
                    .HasComment("Observaciones");

                entity.Property(e => e.VenPin)
                    .HasPrecision(4)
                    .HasColumnName("VEN_PIN")
                    .HasComment("PIN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
