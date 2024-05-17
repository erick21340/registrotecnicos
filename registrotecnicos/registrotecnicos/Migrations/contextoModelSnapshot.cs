﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using registrotecnicos.DAL;

#nullable disable

namespace registrotecnicos.Migrations
{
    [DbContext(typeof(contexto))]
    partial class contextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("registrotecnicos.Models.Tecnicos", b =>
                {
                    b.Property<int>("TecnicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TecnicosTipos")
                        .HasColumnType("TEXT");

                    b.Property<int>("tipoid")
                        .HasColumnType("INTEGER");

                    b.HasKey("TecnicoId");

                    b.ToTable("Tecnicos");
                });
#pragma warning restore 612, 618
        }
    }
}
