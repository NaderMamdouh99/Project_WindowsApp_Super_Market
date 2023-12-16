﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Super_Market.Models;

#nullable disable

namespace Super_Market.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231002151208_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Super_Market.Categorys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StorId");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDelete = false,
                            Name = "Dairy",
                            StorId = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDelete = false,
                            Name = "protien",
                            StorId = 2
                        });
                });

            modelBuilder.Entity("Super_Market.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("ProudectId")
                        .HasColumnType("int");

                    b.Property<int>("Quanatity")
                        .HasColumnType("int");

                    b.Property<int>("SellinvoceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProudectId");

                    b.HasIndex("SellinvoceId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Super_Market.Proudect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategorysId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PurchasingPrice")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ReciptId")
                        .HasColumnType("int");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<int>("Suppliersid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategorysId");

                    b.HasIndex("ReciptId");

                    b.HasIndex("Suppliersid");

                    b.ToTable("proudcts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategorysId = 1,
                            ExpirationDate = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Name = "Milk",
                            ProductionDate = new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasingPrice = 11.0,
                            Quantity = 20,
                            SellingPrice = 15.0,
                            Suppliersid = 1
                        },
                        new
                        {
                            Id = 2,
                            CategorysId = 1,
                            ExpirationDate = new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Name = "Cheese",
                            ProductionDate = new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasingPrice = 25.0,
                            Quantity = 17,
                            SellingPrice = 30.0,
                            Suppliersid = 1
                        },
                        new
                        {
                            Id = 3,
                            CategorysId = 1,
                            ExpirationDate = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Name = "Yogut",
                            ProductionDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasingPrice = 3.0,
                            Quantity = 200,
                            SellingPrice = 5.0,
                            Suppliersid = 1
                        },
                        new
                        {
                            Id = 4,
                            CategorysId = 2,
                            ExpirationDate = new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Name = "Meet",
                            ProductionDate = new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasingPrice = 130.0,
                            Quantity = 25,
                            SellingPrice = 150.0,
                            Suppliersid = 2
                        },
                        new
                        {
                            Id = 5,
                            CategorysId = 2,
                            ExpirationDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Name = "Chicken",
                            ProductionDate = new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasingPrice = 70.0,
                            Quantity = 48,
                            SellingPrice = 80.0,
                            Suppliersid = 2
                        },
                        new
                        {
                            Id = 6,
                            CategorysId = 2,
                            ExpirationDate = new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDelete = false,
                            Name = "fish",
                            ProductionDate = new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PurchasingPrice = 75.0,
                            Quantity = 36,
                            SellingPrice = 90.0,
                            Suppliersid = 2
                        });
                });

            modelBuilder.Entity("Super_Market.Recipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("SuppliersId")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("SuppliersId");

                    b.ToTable("recipts");
                });

            modelBuilder.Entity("Super_Market.Sellinvoce", b =>
                {
                    b.Property<int>("BonNumberr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BonNumberr"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<double>("PaidMoney")
                        .HasColumnType("float");

                    b.Property<double>("RemainingMoney")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("BonNumberr");

                    b.HasIndex("UsersId");

                    b.ToTable("sellinvoces");
                });

            modelBuilder.Entity("Super_Market.Stor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDelete = false,
                            Location = "Assiut",
                            Name = "store1"
                        },
                        new
                        {
                            Id = 2,
                            IsDelete = false,
                            Location = "Alex",
                            Name = "Store2"
                        });
                });

            modelBuilder.Entity("Super_Market.Suppliers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDelete = false,
                            Name = "johinaa",
                            Phone = "01028574231"
                        },
                        new
                        {
                            Id = 2,
                            IsDelete = false,
                            Name = "almraie",
                            Phone = "01055688224"
                        },
                        new
                        {
                            Id = 3,
                            IsDelete = false,
                            Name = "atyab",
                            Phone = "0104567432"
                        });
                });

            modelBuilder.Entity("Super_Market.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pos")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            IsDelete = false,
                            Password = "12345",
                            Pos = 0,
                            Salary = 2000.0,
                            UserName = "Ahmed"
                        },
                        new
                        {
                            Id = 20,
                            IsDelete = false,
                            Password = "2555",
                            Pos = 0,
                            Salary = 1000.0,
                            UserName = "Mahmoud"
                        },
                        new
                        {
                            Id = 30,
                            IsDelete = false,
                            Password = "11111",
                            Pos = 1,
                            Salary = 3000.0,
                            UserName = "Kero"
                        });
                });

            modelBuilder.Entity("Super_Market.Categorys", b =>
                {
                    b.HasOne("Super_Market.Stor", "objstor")
                        .WithMany("Categories")
                        .HasForeignKey("StorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("objstor");
                });

            modelBuilder.Entity("Super_Market.Order", b =>
                {
                    b.HasOne("Super_Market.Proudect", "Proudect")
                        .WithMany("orders")
                        .HasForeignKey("ProudectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Market.Sellinvoce", "Sellinvoce")
                        .WithMany("Orders")
                        .HasForeignKey("SellinvoceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proudect");

                    b.Navigation("Sellinvoce");
                });

            modelBuilder.Entity("Super_Market.Proudect", b =>
                {
                    b.HasOne("Super_Market.Categorys", "category")
                        .WithMany("Products")
                        .HasForeignKey("CategorysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Market.Recipt", null)
                        .WithMany("products")
                        .HasForeignKey("ReciptId");

                    b.HasOne("Super_Market.Suppliers", "supplier")
                        .WithMany("products")
                        .HasForeignKey("Suppliersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("Super_Market.Recipt", b =>
                {
                    b.HasOne("Super_Market.Suppliers", "supplier")
                        .WithMany("recipts")
                        .HasForeignKey("SuppliersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("supplier");
                });

            modelBuilder.Entity("Super_Market.Sellinvoce", b =>
                {
                    b.HasOne("Super_Market.Users", "Users")
                        .WithMany("Sellinvos")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Super_Market.Categorys", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Super_Market.Proudect", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("Super_Market.Recipt", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("Super_Market.Sellinvoce", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Super_Market.Stor", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Super_Market.Suppliers", b =>
                {
                    b.Navigation("products");

                    b.Navigation("recipts");
                });

            modelBuilder.Entity("Super_Market.Users", b =>
                {
                    b.Navigation("Sellinvos");
                });
#pragma warning restore 612, 618
        }
    }
}
