﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreManagement.EF.Context;

namespace StoreManagement.EF.Migrations
{
    [DbContext(typeof(StoreManagementEfContext))]
    partial class StoreManagementEfContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoreManagement.EF.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Product1 description",
                            Name = "Product1"
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Product2 description",
                            Name = "Product2"
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Product3 description",
                            Name = "Product3"
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Product4 description",
                            Name = "Product4"
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "Product5 description",
                            Name = "Product5"
                        });
                });

            modelBuilder.Entity("StoreManagement.EF.Entities.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("StoreHours")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("StoreId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            StoreId = 1,
                            Address = "Address1",
                            Name = "Store1",
                            StoreHours = "9.00-18.00"
                        },
                        new
                        {
                            StoreId = 2,
                            Address = "Address2",
                            Name = "Store2",
                            StoreHours = "9.00-21.00"
                        },
                        new
                        {
                            StoreId = 3,
                            Address = "Address3",
                            Name = "Store3",
                            StoreHours = "9.00-17.00"
                        });
                });

            modelBuilder.Entity("StoreManagement.EF.Entities.StoreProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "StoreId");

                    b.HasIndex("StoreId");

                    b.ToTable("StoresProducts");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            StoreId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            StoreId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            StoreId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            StoreId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            StoreId = 3
                        },
                        new
                        {
                            ProductId = 5,
                            StoreId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            StoreId = 3
                        });
                });

            modelBuilder.Entity("StoreManagement.EF.Entities.StoreProduct", b =>
                {
                    b.HasOne("StoreManagement.EF.Entities.Product", "Product")
                        .WithMany("StoresProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.EF.Entities.Store", "Store")
                        .WithMany("StoresProducts")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
