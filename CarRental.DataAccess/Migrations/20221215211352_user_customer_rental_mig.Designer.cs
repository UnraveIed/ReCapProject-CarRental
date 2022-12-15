﻿// <auto-generated />
using System;
using CarRental.DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRental.DataAccess.Migrations
{
    [DbContext(typeof(CarRentalContext))]
    [Migration("20221215211352_user_customer_rental_mig")]
    partial class user_customer_rental_mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarRental.Entities.Concrete.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1608),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1608),
                            Name = "Mercedes",
                            Note = "Mercedes Markası"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1611),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1612),
                            Name = "BMV",
                            Note = "BMV Markası"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1614),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1615),
                            Name = "Lamborghini",
                            Note = "Lamborghini Markası"
                        },
                        new
                        {
                            Id = 4,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1616),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1617),
                            Name = "Ferrari",
                            Note = "Ferrari Markası"
                        },
                        new
                        {
                            Id = 5,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1619),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1619),
                            Name = "Opel",
                            Note = "Opel Markası"
                        },
                        new
                        {
                            Id = 6,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1621),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1622),
                            Name = "Peugeot",
                            Note = "Peugeot Markası"
                        },
                        new
                        {
                            Id = 7,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1624),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1624),
                            Name = "Koenigsegg",
                            Note = "Koenigsegg Markası"
                        },
                        new
                        {
                            Id = 8,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1626),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1627),
                            Name = "Aston Martin",
                            Note = "Aston Martin Markası"
                        },
                        new
                        {
                            Id = 9,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1629),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1629),
                            Name = "Porsche",
                            Note = "Porsche Markası"
                        },
                        new
                        {
                            Id = 10,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1631),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1632),
                            Name = "McLaren",
                            Note = "McLaren Markası"
                        },
                        new
                        {
                            Id = 11,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1633),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(1634),
                            Name = "Ford",
                            Note = "Ford Markası"
                        });
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DailyPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<short>("ModelYear")
                        .HasColumnType("smallint");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            ColorId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5264),
                            DailyPrice = 950000.00m,
                            Description = "Iyi bir model 1",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = (short)2019,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5265),
                            Note = "1. Araba"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            ColorId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5270),
                            DailyPrice = 850000.00m,
                            Description = "Iyi bir model 2",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = (short)2017,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5271),
                            Note = "2. Araba"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3,
                            ColorId = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5273),
                            DailyPrice = 1000000.00m,
                            Description = "Iyi bir model 3",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = (short)2021,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5274),
                            Note = "3. Araba"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 4,
                            ColorId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5277),
                            DailyPrice = 980000.00m,
                            Description = "Iyi bir model 4",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = (short)2020,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5278),
                            Note = "4. Araba"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 5,
                            ColorId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5280),
                            DailyPrice = 150000.00m,
                            Description = "Iyi bir model 5",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = (short)2014,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5281),
                            Note = "5. Araba"
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 6,
                            ColorId = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5284),
                            DailyPrice = 250000.00m,
                            Description = "Iyi bir model 6",
                            IsActive = true,
                            IsDeleted = false,
                            ModelYear = (short)2021,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(5284),
                            Note = "6. Araba"
                        });
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2660),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2660),
                            Name = "Sarı",
                            Note = "Sarı Rengi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2663),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2663),
                            Name = "Kırmızı",
                            Note = "Kırmızı Rengi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2665),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(2666),
                            Name = "Mavi",
                            Note = "Mavi Rengi"
                        });
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "AE Yazılım",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6994),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6995),
                            Note = "1. Musteri",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Selçuk Üniversitesi",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6997),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6998),
                            Note = "2. Musteri",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("RentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Rentals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 5,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8974),
                            CustomerId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8975),
                            Note = "Ilk kira",
                            RentDate = new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            ReturnDate = new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            CarId = 7,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8979),
                            CustomerId = 2,
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(8979),
                            Note = "2. kira",
                            RentDate = new DateTime(2022, 12, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            ReturnDate = new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6173),
                            Email = "batu@inal.com",
                            FirstName = "Batuhan",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "İnal",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6174),
                            Note = "User data seed",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6176),
                            Email = "samet@inal.com",
                            FirstName = "Samet",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "İnal",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6177),
                            Note = "User data seed",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6180),
                            Email = "Ilknur@inal.com",
                            FirstName = "Ilknur",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "İnal",
                            ModifiedByName = "InitialCreate",
                            ModifiedDate = new DateTime(2022, 12, 16, 0, 13, 51, 591, DateTimeKind.Local).AddTicks(6180),
                            Note = "User data seed",
                            Password = "12345"
                        });
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Car", b =>
                {
                    b.HasOne("CarRental.Entities.Concrete.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental.Entities.Concrete.Color", "Color")
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Customer", b =>
                {
                    b.HasOne("CarRental.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Rental", b =>
                {
                    b.HasOne("CarRental.Entities.Concrete.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental.Entities.Concrete.Customer", "Customer")
                        .WithMany("Rentals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Brand", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Car", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Color", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarRental.Entities.Concrete.Customer", b =>
                {
                    b.Navigation("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}