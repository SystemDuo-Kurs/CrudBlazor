﻿// <auto-generated />
using CrudBlazor.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudBlazor.Server.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20211206155824_Druga")]
    partial class Druga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CrudBlazor.Shared.Osoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Godiste")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Osobas");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Godiste = 0,
                            Name = "Pera",
                            Surname = "Peric"
                        },
                        new
                        {
                            Id = -2,
                            Godiste = 0,
                            Name = "Neko",
                            Surname = "Nekic"
                        },
                        new
                        {
                            Id = -3,
                            Godiste = 0,
                            Name = "Trecko",
                            Surname = "Treckovic"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}