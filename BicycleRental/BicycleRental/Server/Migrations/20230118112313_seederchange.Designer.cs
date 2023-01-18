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
    [Migration("20230118112313_seederchange")]
    partial class seederchange
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
                            Brand = "ratione-ea-quisquam",
                            GearCount = -1022928617,
                            Name = "Audreanne",
                            Place = "Oletashire",
                            PrizePerDay = 3.1584989716117673,
                            Region = "Cambridgeshire",
                            TireSize = 19,
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            Brand = "voluptatem-distinctio-sint",
                            GearCount = -303086298,
                            Name = "Marlin",
                            Place = "Haneland",
                            PrizePerDay = 111.53173625572543,
                            Region = "Bedfordshire",
                            TireSize = 12,
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            Brand = "sunt-repellendus-et",
                            GearCount = -1629358854,
                            Name = "Allene",
                            Place = "East Pedro",
                            PrizePerDay = 116.72240846101759,
                            Region = "Cambridgeshire",
                            TireSize = 24,
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            Brand = "ut-eaque-quis",
                            GearCount = -1809174832,
                            Name = "Maybelle",
                            Place = "South Caterinafurt",
                            PrizePerDay = 216.46388568906099,
                            Region = "Borders",
                            TireSize = 11,
                            Type = 1
                        },
                        new
                        {
                            Id = 5,
                            Brand = "deserunt-est-rerum",
                            GearCount = 323397413,
                            Name = "Reed",
                            Place = "Jamaalton",
                            PrizePerDay = 89.541930709620473,
                            Region = "Borders",
                            TireSize = 19,
                            Type = 6
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BicycleId = 2,
                            EndDate = new DateTime(2023, 2, 6, 4, 35, 28, 740, DateTimeKind.Local).AddTicks(3320),
                            StartDate = new DateTime(2023, 1, 25, 5, 37, 6, 541, DateTimeKind.Local).AddTicks(1256)
                        },
                        new
                        {
                            Id = 2,
                            BicycleId = 6,
                            EndDate = new DateTime(2023, 2, 6, 8, 1, 51, 587, DateTimeKind.Local).AddTicks(2022),
                            StartDate = new DateTime(2023, 1, 28, 0, 55, 40, 125, DateTimeKind.Local).AddTicks(5141)
                        },
                        new
                        {
                            Id = 3,
                            BicycleId = 3,
                            EndDate = new DateTime(2023, 2, 3, 9, 49, 33, 548, DateTimeKind.Local).AddTicks(8699),
                            StartDate = new DateTime(2023, 1, 26, 5, 11, 35, 687, DateTimeKind.Local).AddTicks(3071)
                        },
                        new
                        {
                            Id = 4,
                            BicycleId = 2,
                            EndDate = new DateTime(2023, 2, 2, 14, 13, 4, 195, DateTimeKind.Local).AddTicks(7930),
                            StartDate = new DateTime(2023, 1, 24, 5, 50, 29, 876, DateTimeKind.Local).AddTicks(5148)
                        },
                        new
                        {
                            Id = 5,
                            BicycleId = 1,
                            EndDate = new DateTime(2023, 2, 1, 12, 27, 40, 132, DateTimeKind.Local).AddTicks(9826),
                            StartDate = new DateTime(2023, 1, 25, 19, 12, 45, 362, DateTimeKind.Local).AddTicks(56)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}