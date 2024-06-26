﻿// <auto-generated />
using System;
using CarProControl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarProControl.Migrations
{
    [DbContext(typeof(CarProControlContext))]
    [Migration("20240625232504_OutrasEntidades")]
    partial class OutrasEntidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CarProControl.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<double>("Salario");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("CarProControl.Models.OrdemServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataEntrada");

                    b.Property<DateTime>("DataSaida");

                    b.Property<string>("DescricaoServico");

                    b.Property<int?>("FuncionarioResponsavelId");

                    b.Property<double>("ValorOrcamento");

                    b.Property<int?>("VeiculoId");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioResponsavelId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("OrdemServicos");
                });

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

            modelBuilder.Entity("CarProControl.Models.OrdemServico", b =>
                {
                    b.HasOne("CarProControl.Models.Funcionario", "FuncionarioResponsavel")
                        .WithMany()
                        .HasForeignKey("FuncionarioResponsavelId");

                    b.HasOne("CarProControl.Models.Veiculo", "Veiculo")
                        .WithMany("OrdensServico")
                        .HasForeignKey("VeiculoId");
                });
#pragma warning restore 612, 618
        }
    }
}