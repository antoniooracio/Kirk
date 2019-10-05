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
    [Migration("20191001205913_InicioView")]
    partial class InicioView
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

            modelBuilder.Entity("HADev.Delivery.Domain.Models.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("UF");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });
#pragma warning restore 612, 618
        }
    }
}
