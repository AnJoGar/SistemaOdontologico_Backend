﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaOdontologico.Models;

#nullable disable

namespace SistemaOdontologico.Migrations
{
    [DbContext(typeof(SistemaOdontologicoDbContext))]
    partial class SistemaOdontologicoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaOdontologico.Models.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NumeroDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.DetalleCita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CitaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaReserva")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OdontologoId")
                        .HasColumnType("int");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ServicioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CitaId");

                    b.HasIndex("OdontologoId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("ServicioId");

                    b.ToTable("DetalleCita");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Icono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.MenuRol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("MenuId")
                        .HasColumnType("int");

                    b.Property<int?>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RolId");

                    b.ToTable("MenuRols");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.NumeroDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UltimoNumero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NumeroDocumentos");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Odontologo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Experiencia")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Odontologos");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NombreServicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("EsActivo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreApellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.DetalleCita", b =>
                {
                    b.HasOne("SistemaOdontologico.Models.Cita", "Cita")
                        .WithMany("DetalleCita")
                        .HasForeignKey("CitaId");

                    b.HasOne("SistemaOdontologico.Models.Odontologo", "Odontologo")
                        .WithMany()
                        .HasForeignKey("OdontologoId");

                    b.HasOne("SistemaOdontologico.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");

                    b.HasOne("SistemaOdontologico.Models.Servicio", "Servicio")
                        .WithMany("DetalleCita")
                        .HasForeignKey("ServicioId");

                    b.Navigation("Cita");

                    b.Navigation("Odontologo");

                    b.Navigation("Paciente");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.MenuRol", b =>
                {
                    b.HasOne("SistemaOdontologico.Models.Menu", "Menu")
                        .WithMany("MenuRols")
                        .HasForeignKey("MenuId");

                    b.HasOne("SistemaOdontologico.Models.Rol", "Rol")
                        .WithMany("MenuRols")
                        .HasForeignKey("RolId");

                    b.Navigation("Menu");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Usuario", b =>
                {
                    b.HasOne("SistemaOdontologico.Models.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Cita", b =>
                {
                    b.Navigation("DetalleCita");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Menu", b =>
                {
                    b.Navigation("MenuRols");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Rol", b =>
                {
                    b.Navigation("MenuRols");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SistemaOdontologico.Models.Servicio", b =>
                {
                    b.Navigation("DetalleCita");
                });
#pragma warning restore 612, 618
        }
    }
}
