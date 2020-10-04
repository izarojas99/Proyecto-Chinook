﻿// <auto-generated />
using System;
using Chinook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chinook.Migrations
{
    [DbContext(typeof(ChinookContext))]
    partial class ChinookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chinook.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<int?>("CancionId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CancionId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Chinook.Models.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Artista");
                });

            modelBuilder.Entity("Chinook.Models.Cancion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int?>("DetalleFacturaId")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DetalleFacturaId");

                    b.ToTable("Cancion");
                });

            modelBuilder.Entity("Chinook.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FacturaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoporteId")
                        .HasColumnType("int");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacturaId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Chinook.Models.DetalleFactura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CancionId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("FacturaId")
                        .HasColumnType("int");

                    b.Property<float>("PrecioUnidad")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("FacturaId");

                    b.ToTable("DetalleFactura");
                });

            modelBuilder.Entity("Chinook.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<int>("JefeDirecto")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("Chinook.Models.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFactura")
                        .HasColumnType("datetime2");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("Chinook.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CancionId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CancionId");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Chinook.Models.Album", b =>
                {
                    b.HasOne("Chinook.Models.Cancion", "Cancion")
                        .WithMany("AlbumLista")
                        .HasForeignKey("CancionId");
                });

            modelBuilder.Entity("Chinook.Models.Artista", b =>
                {
                    b.HasOne("Chinook.Models.Album", "Album")
                        .WithMany("ArtistaLista")
                        .HasForeignKey("AlbumId");
                });

            modelBuilder.Entity("Chinook.Models.Cancion", b =>
                {
                    b.HasOne("Chinook.Models.DetalleFactura", "DetalleFactura")
                        .WithMany("CancionLista")
                        .HasForeignKey("DetalleFacturaId");
                });

            modelBuilder.Entity("Chinook.Models.Cliente", b =>
                {
                    b.HasOne("Chinook.Models.Factura", "Factura")
                        .WithMany("ClienteLista")
                        .HasForeignKey("FacturaId");
                });

            modelBuilder.Entity("Chinook.Models.DetalleFactura", b =>
                {
                    b.HasOne("Chinook.Models.Factura", "Factura")
                        .WithMany("DetalleFacturaLista")
                        .HasForeignKey("FacturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Chinook.Models.Empleado", b =>
                {
                    b.HasOne("Chinook.Models.Cliente", "Cliente")
                        .WithMany("EmpleadosLista")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Chinook.Models.Empleado", null)
                        .WithMany("EmpleadoLista")
                        .HasForeignKey("EmpleadoId");
                });

            modelBuilder.Entity("Chinook.Models.Genero", b =>
                {
                    b.HasOne("Chinook.Models.Cancion", "Cancion")
                        .WithMany("Generolista")
                        .HasForeignKey("CancionId");
                });
#pragma warning restore 612, 618
        }
    }
}
