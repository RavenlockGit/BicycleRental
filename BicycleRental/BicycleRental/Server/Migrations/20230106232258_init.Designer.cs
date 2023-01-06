﻿// <auto-generated />
using System;
using BicycleRental.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BicycleRental.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230106232258_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BicycleRental.Shared.Models.Bicycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FrontPicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("GearCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Picture3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Picture4")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrizePerDay")
                        .HasColumnType("float");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TireSize")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bicycle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "sunt-reiciendis-quod",
                            GearCount = -1084683899,
                            Name = "William",
                            Place = "East Lethashire",
                            PrizePerDay = 206.98628439470815,
                            Region = "Borders",
                            TireSize = 26,
                            Type = 3
                        });
                });

            modelBuilder.Entity("BicycleRental.Shared.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BicycleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Reservation");
                });
#pragma warning restore 612, 618
        }
    }
}