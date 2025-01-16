﻿// <auto-generated />
using System;
using CarniCheck.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarniCheck.Migrations
{
    [DbContext(typeof(CarniCheckContext))]
    [Migration("20250116203556_NuevaMigracion")]
    partial class NuevaMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CarniCheck.Models.Administrador", b =>
                {
                    b.Property<int>("ID_Administrador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Administrador"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Dirección")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Teléfono")
                        .HasColumnType("longtext");

                    b.HasKey("ID_Administrador");

                    b.ToTable("Administrador", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Certificacion", b =>
                {
                    b.Property<int>("ID_Certificación")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Certificación"));

                    b.Property<string>("Descripción")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Fecha_Expedición")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fecha_Vencimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID_Certificación");

                    b.ToTable("Certificacion", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Certificacion_establecimiento", b =>
                {
                    b.Property<int>("ID_Establecimiento")
                        .HasColumnType("int");

                    b.Property<int>("ID_Certificacion")
                        .HasColumnType("int");

                    b.HasKey("ID_Establecimiento", "ID_Certificacion");

                    b.HasIndex("ID_Certificacion");

                    b.ToTable("Certificacion_Establecimiento", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Cliente", b =>
                {
                    b.Property<int>("ID_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Cliente"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Dirección")
                        .HasColumnType("longtext");

                    b.Property<string>("Documentación")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado_Cliente")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Activo");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Teléfono")
                        .HasColumnType("longtext");

                    b.HasKey("ID_Cliente");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Establecimiento", b =>
                {
                    b.Property<int>("ID_Establecimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Establecimiento"));

                    b.Property<string>("Dirección")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado_Establecimiento")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Activo");

                    b.Property<int>("ID_Cliente")
                        .HasColumnType("int");

                    b.Property<string>("Nivel_Riesgo")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Record_Inspecciones")
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo_Establecimiento")
                        .HasColumnType("longtext");

                    b.HasKey("ID_Establecimiento");

                    b.ToTable("Establecimiento", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Infraccion", b =>
                {
                    b.Property<int>("ID_Infracción")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Infracción"));

                    b.Property<int>("Cantidad_Infracciones")
                        .HasColumnType("int");

                    b.Property<string>("Descripción")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado_Infracción")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Pendiente");

                    b.Property<int>("ID_Establecimiento")
                        .HasColumnType("int");

                    b.Property<int>("ID_Inspección")
                        .HasColumnType("int");

                    b.Property<int>("ID_Inspector")
                        .HasColumnType("int");

                    b.Property<string>("Nivel_Infracción")
                        .HasColumnType("longtext");

                    b.HasKey("ID_Infracción");

                    b.ToTable("Infraccion", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Inspeccion", b =>
                {
                    b.Property<int>("ID_Inspección")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Inspección"));

                    b.Property<string>("Estado_Inspección")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Pendiente");

                    b.Property<DateTime>("Fecha_Inspección")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ID_Establecimiento")
                        .HasColumnType("int");

                    b.Property<int>("ID_Inspector")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasColumnType("longtext");

                    b.HasKey("ID_Inspección");

                    b.ToTable("Inspeccion", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Inspector", b =>
                {
                    b.Property<int>("ID_Inspector")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Inspector"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Especialidad")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Zona_Asignada")
                        .HasColumnType("longtext");

                    b.HasKey("ID_Inspector");

                    b.ToTable("Inspector", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Producto", b =>
                {
                    b.Property<int>("ID_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Producto"));

                    b.Property<int>("Cantidad_Productos")
                        .HasColumnType("int");

                    b.Property<string>("Categoría")
                        .HasColumnType("longtext");

                    b.Property<bool>("Disponibilidad")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("Fecha_Producción")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("Fecha_Vencimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ID_Establecimiento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID_Producto");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Proveedor", b =>
                {
                    b.Property<int>("ID_Proveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Proveedor"));

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo_Producto")
                        .HasColumnType("longtext");

                    b.HasKey("ID_Proveedor");

                    b.ToTable("Proveedor", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Proveedor_establecimiento", b =>
                {
                    b.Property<int>("ID_Proveedor")
                        .HasColumnType("int");

                    b.Property<int>("ID_Establecimiento")
                        .HasColumnType("int");

                    b.HasKey("ID_Proveedor", "ID_Establecimiento");

                    b.HasIndex("ID_Establecimiento");

                    b.ToTable("Proveedor_Establecimiento", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Sancion", b =>
                {
                    b.Property<int>("ID_Sanción")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Sanción"));

                    b.Property<DateTime?>("Fecha_Pago")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal?>("Fianza")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ID_Establecimiento")
                        .HasColumnType("int");

                    b.Property<int>("ID_Infracción")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ID_Sanción");

                    b.ToTable("Sancion", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Solicitud_Inspeccion", b =>
                {
                    b.Property<int>("ID_Solicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ID_Solicitud"));

                    b.Property<string>("Estado_Solicitud")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext")
                        .HasDefaultValue("Pendiente");

                    b.Property<DateTime>("Fecha_Solicitud")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ID_Administrador")
                        .HasColumnType("int");

                    b.Property<int>("ID_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("ID_Establecimiento")
                        .HasColumnType("int");

                    b.Property<int?>("ID_Inspector")
                        .HasColumnType("int");

                    b.HasKey("ID_Solicitud");

                    b.ToTable("Solicitud_Inspeccion", (string)null);
                });

            modelBuilder.Entity("CarniCheck.Models.Certificacion_establecimiento", b =>
                {
                    b.HasOne("CarniCheck.Models.Certificacion", null)
                        .WithMany()
                        .HasForeignKey("ID_Certificacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarniCheck.Models.Establecimiento", null)
                        .WithMany()
                        .HasForeignKey("ID_Establecimiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarniCheck.Models.Proveedor_establecimiento", b =>
                {
                    b.HasOne("CarniCheck.Models.Establecimiento", null)
                        .WithMany()
                        .HasForeignKey("ID_Establecimiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarniCheck.Models.Proveedor", null)
                        .WithMany()
                        .HasForeignKey("ID_Proveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
