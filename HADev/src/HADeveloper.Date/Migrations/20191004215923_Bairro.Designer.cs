﻿// <auto-generated />
using System;
using HADeveloper.Date.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HADev.Delivery.Date.Migrations
{
    [DbContext(typeof(HADeveloperDBContext))]
    [Migration("20191004215923_Bairro")]
    partial class Bairro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HADev.Delivery.Domain.Entities.Mural", b =>
                {
                    b.Property<int>("MuralId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor");

                    b.Property<string>("Aviso");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Email");

                    b.Property<string>("Titulo");

                    b.HasKey("MuralId");

                    b.ToTable("Mural");
                });

            modelBuilder.Entity("HADev.Delivery.Domain.Models.Bairro", b =>
                {
                    b.Property<int>("BairroId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .IsRequired();

                    b.Property<int>("CidadeId");

                    b.Property<int>("EstadoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("BairroId");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Bairro");
                });

            modelBuilder.Entity("HADev.Delivery.Domain.Models.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EstadoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("CidadeId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("HADev.Delivery.Domain.Models.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("EstadoId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("HADev.Delivery.Domain.Models.Bairro", b =>
                {
                    b.HasOne("HADev.Delivery.Domain.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HADev.Delivery.Domain.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HADev.Delivery.Domain.Models.Cidade", b =>
                {
                    b.HasOne("HADev.Delivery.Domain.Models.Estado", "Estado")
                        .WithMany("cidade")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}