﻿// <auto-generated />
using System;
using LaundryOrderAppMain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaundryOrderAppMain.Migrations
{
    [DbContext(typeof(LaundryOrderDbContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LaundryOrderAppMain.Coupon", b =>
                {
                    b.Property<int>("CouponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ISDropOffServiceCoupon")
                        .HasColumnType("bit");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Used")
                        .HasColumnType("bit");

                    b.HasKey("CouponID");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponID = 1,
                            CreatedDate = new DateTime(2023, 5, 4, 9, 4, 53, 405, DateTimeKind.Local).AddTicks(8805),
                            Description = "1 Free Wash Any Size Washer",
                            ExpDate = new DateTime(2023, 5, 4, 9, 4, 53, 405, DateTimeKind.Local).AddTicks(8808),
                            ISDropOffServiceCoupon = false,
                            Instructions = "Start 1 Washer of any Size for Customer",
                            StartDate = new DateTime(2023, 5, 4, 9, 4, 53, 405, DateTimeKind.Local).AddTicks(8807),
                            Used = false
                        });
                });

            modelBuilder.Entity("LaundryOrderAppMain.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComercial")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Address = "5240 Windswept ln House Springs MO 63051",
                            Email = "Jacob@segotw.com",
                            Instructions = "",
                            IsComercial = false,
                            IsEnabled = true,
                            Name = "Jacob Weinrich",
                            Phone = "314-939-9335"
                        });
                });

            modelBuilder.Entity("LaundryOrderAppMain.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("BlanketsFull")
                        .HasColumnType("int");

                    b.Property<int>("BlanketsKing")
                        .HasColumnType("int");

                    b.Property<int>("BlanketsQueen")
                        .HasColumnType("int");

                    b.Property<int>("BlanketsTwin")
                        .HasColumnType("int");

                    b.Property<int>("ComfortersFull")
                        .HasColumnType("int");

                    b.Property<int>("ComfortersKing")
                        .HasColumnType("int");

                    b.Property<int>("ComfortersQueen")
                        .HasColumnType("int");

                    b.Property<int>("ComfortersTwin")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("HorseBlankets")
                        .HasColumnType("int");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComercial")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPickedUp")
                        .HasColumnType("bit");

                    b.Property<double>("LaundryPounds")
                        .HasColumnType("float");

                    b.Property<DateTime?>("PickUpDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Pillows")
                        .HasColumnType("int");

                    b.Property<int>("RugsLarge")
                        .HasColumnType("int");

                    b.Property<int>("RugsSmall")
                        .HasColumnType("int");

                    b.Property<int>("SleepingBagDouble")
                        .HasColumnType("int");

                    b.Property<int>("SleepingBagSingle")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            BlanketsFull = 0,
                            BlanketsKing = 0,
                            BlanketsQueen = 0,
                            BlanketsTwin = 0,
                            ComfortersFull = 0,
                            ComfortersKing = 0,
                            ComfortersQueen = 0,
                            ComfortersTwin = 0,
                            CreatedDate = new DateTime(2023, 5, 4, 9, 4, 53, 405, DateTimeKind.Local).AddTicks(8738),
                            CustomerID = 1,
                            HorseBlankets = 0,
                            Instructions = "",
                            IsComercial = false,
                            IsPaid = false,
                            IsPickedUp = false,
                            LaundryPounds = 0.0,
                            Pillows = 0,
                            RugsLarge = 0,
                            RugsSmall = 0,
                            SleepingBagDouble = 0,
                            SleepingBagSingle = 0,
                            TotalPrice = 0.0
                        });
                });

            modelBuilder.Entity("LaundryOrderAppMain.Prices", b =>
                {
                    b.Property<int>("PricesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PricesID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("PricesID");

                    b.ToTable("Prices");

                    b.HasData(
                        new
                        {
                            PricesID = 1,
                            Name = "PricePerPound",
                            Price = 1.25
                        },
                        new
                        {
                            PricesID = 2,
                            Name = "PricePerPound-Comercial",
                            Price = 1.5
                        },
                        new
                        {
                            PricesID = 3,
                            Name = "Comforter-Twin",
                            Price = 17.0
                        },
                        new
                        {
                            PricesID = 4,
                            Name = "Comforter-Full",
                            Price = 18.0
                        },
                        new
                        {
                            PricesID = 5,
                            Name = "Comforter-Queen",
                            Price = 19.0
                        },
                        new
                        {
                            PricesID = 6,
                            Name = "Comforter-King",
                            Price = 20.0
                        },
                        new
                        {
                            PricesID = 7,
                            Name = "Blanket-Twin",
                            Price = 15.0
                        },
                        new
                        {
                            PricesID = 8,
                            Name = "Blanket-Full",
                            Price = 16.0
                        },
                        new
                        {
                            PricesID = 9,
                            Name = "Blanket-Queen",
                            Price = 17.0
                        },
                        new
                        {
                            PricesID = 10,
                            Name = "Blanket-King",
                            Price = 18.0
                        },
                        new
                        {
                            PricesID = 11,
                            Name = "Rug-Small",
                            Price = 15.0
                        },
                        new
                        {
                            PricesID = 12,
                            Name = "Rug-Large",
                            Price = 20.0
                        },
                        new
                        {
                            PricesID = 13,
                            Name = "SleepingBag-Single",
                            Price = 15.0
                        },
                        new
                        {
                            PricesID = 14,
                            Name = "SleepingBag-Large",
                            Price = 20.0
                        },
                        new
                        {
                            PricesID = 15,
                            Name = "Pillow",
                            Price = 5.0
                        },
                        new
                        {
                            PricesID = 16,
                            Name = "HorseBlanket",
                            Price = 25.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
