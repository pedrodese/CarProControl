﻿// <auto-generated />
using CarProControl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarProControl.Migrations
{
    [DbContext(typeof(CarProControlContext))]
    partial class CarProControlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CarProControl.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ano");

                    b.Property<string>("Modelo");

                    b.Property<string>("Placa");

                    b.Property<string>("Propietario");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
