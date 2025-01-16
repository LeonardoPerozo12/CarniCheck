using Microsoft.EntityFrameworkCore;
using CarniCheck.Models;

namespace CarniCheck.Context
{
    public class CarniCheckContext : DbContext
    {
        public CarniCheckContext(DbContextOptions<CarniCheckContext> options) : base(options) { }

        // DbSets para todas las tablas
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Inspector> Inspectores { get; set; }
        public DbSet<Establecimiento> Establecimientos { get; set; }
        public DbSet<Solicitud_Inspeccion> SolicitudInspecciones { get; set; }
        public DbSet<Inspeccion> Inspecciones { get; set; }
        public DbSet<Infraccion> Infracciones { get; set; }
        public DbSet<Sancion> Sanciones { get; set; }
        public DbSet<Certificacion> Certificaciones { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Certificacion_establecimiento> CertificacionEstablecimientos { get; set; }
        public DbSet<Proveedor_establecimiento> ProveedorEstablecimientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de Cliente
            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
                .Property(c => c.Estado_Cliente)
                .HasDefaultValue("Activo");

            // Configuración de Administrador
            modelBuilder.Entity<Administrador>()
                .ToTable("Administrador");

            // Configuración de Inspector
            modelBuilder.Entity<Inspector>()
                .ToTable("Inspector");

            // Configuración de Establecimiento
            modelBuilder.Entity<Establecimiento>()
                .ToTable("Establecimiento")
                .Property(e => e.Estado_Establecimiento)
                .HasDefaultValue("Activo");

            // Configuración de SolicitudInspeccion
            modelBuilder.Entity<Solicitud_Inspeccion>()
                .ToTable("Solicitud_Inspeccion")
                .Property(s => s.Estado_Solicitud)
                .HasDefaultValue("Pendiente");

            // Configuración de Inspeccion
            modelBuilder.Entity<Inspeccion>()
                .ToTable("Inspeccion")
                .Property(i => i.Estado_Inspección)
                .HasDefaultValue("Pendiente");

            // Configuración de Infraccion
            modelBuilder.Entity<Infraccion>()
                .ToTable("Infraccion")
                .Property(i => i.Estado_Infracción)
                .HasDefaultValue("Pendiente");

            // Configuración de Sancion
            modelBuilder.Entity<Sancion>()
                .ToTable("Sancion");

            // Configuración de Certificacion
            modelBuilder.Entity<Certificacion>()
                .ToTable("Certificacion");

            // Configuración de Producto
            modelBuilder.Entity<Producto>()
                .ToTable("Producto");

            // Configuración de Proveedor
            modelBuilder.Entity<Proveedor>()
                .ToTable("Proveedor");

            // Configuración de CertificacionEstablecimiento (tabla puente)
            modelBuilder.Entity<Certificacion_establecimiento>()
                .ToTable("Certificacion_Establecimiento")
                .HasKey(ce => new { ce.ID_Establecimiento, ce.ID_Certificacion });

            // Configuración de ProveedorEstablecimiento (tabla puente)
            modelBuilder.Entity<Proveedor_establecimiento>()
                .ToTable("Proveedor_Establecimiento")
                .HasKey(pe => new { pe.ID_Proveedor, pe.ID_Establecimiento });

            // Configuración de relaciones para tablas puente
            modelBuilder.Entity<Certificacion_establecimiento>()
                .HasOne<Establecimiento>()
                .WithMany()
                .HasForeignKey(ce => ce.ID_Establecimiento);

            modelBuilder.Entity<Certificacion_establecimiento>()
                .HasOne<Certificacion>()
                .WithMany()
                .HasForeignKey(ce => ce.ID_Certificacion);

            modelBuilder.Entity<Proveedor_establecimiento>()
                .HasOne<Proveedor>()
                .WithMany()
                .HasForeignKey(pe => pe.ID_Proveedor);

            modelBuilder.Entity<Proveedor_establecimiento>()
                .HasOne<Establecimiento>()
                .WithMany()
                .HasForeignKey(pe => pe.ID_Establecimiento);
        }
    }
}
