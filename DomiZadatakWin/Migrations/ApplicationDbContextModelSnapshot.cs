﻿// <auto-generated />
using System;
using DomiZadatakWin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DomiZadatakWin.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DomiZadatakWin.Models.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateByUser")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAtUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("CroatianPIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool?>("IsForeign")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PartnerNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PartnerTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Partners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Adresa 190",
                            CreateByUser = "john@example.com",
                            CreatedAtUtc = new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(666),
                            CroatianPIN = "12345678901",
                            ExternalCode = "ABC1238663564",
                            FirstName = "John",
                            Gender = "M",
                            IsForeign = false,
                            LastName = "Doe",
                            PartnerNumber = "12345678901234567890",
                            PartnerTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Address = "Adresa 56",
                            CreateByUser = "jane@example.com",
                            CreatedAtUtc = new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(670),
                            CroatianPIN = "18344658941",
                            ExternalCode = "XYZ4563986685446",
                            FirstName = "Jane",
                            Gender = "F",
                            IsForeign = true,
                            LastName = "Doe",
                            PartnerNumber = "09876543210987654321",
                            PartnerTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Address = "Adresa 123",
                            CreateByUser = "alice@example.com",
                            CreatedAtUtc = new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(672),
                            CroatianPIN = "47314358990",
                            ExternalCode = "DEF789487678756",
                            FirstName = "Alice",
                            Gender = "F",
                            IsForeign = false,
                            LastName = "Smith",
                            PartnerNumber = "11122233344455566677",
                            PartnerTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Address = "Adresa 15",
                            CreateByUser = "bob@example.com",
                            CreatedAtUtc = new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(674),
                            CroatianPIN = "623478695206",
                            ExternalCode = "GHI12345697644",
                            FirstName = "Bob",
                            Gender = "M",
                            IsForeign = true,
                            LastName = "Johnson",
                            PartnerNumber = "44455566677788899900",
                            PartnerTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Address = "Adresa 23",
                            CreateByUser = "charlie@example.com",
                            CreatedAtUtc = new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(676),
                            CroatianPIN = "70345653248",
                            ExternalCode = "JKL45634754656",
                            FirstName = "Charlie",
                            Gender = "N",
                            IsForeign = false,
                            LastName = "Brown",
                            PartnerNumber = "99900011122233344455",
                            PartnerTypeId = 1
                        });
                });

            modelBuilder.Entity("DomiZadatakWin.Models.Policy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<decimal>("PolicyAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PolicyNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId");

                    b.ToTable("Policies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PartnerId = 1,
                            PolicyAmount = 1500.00m,
                            PolicyNumber = "POL001"
                        },
                        new
                        {
                            Id = 2,
                            PartnerId = 2,
                            PolicyAmount = 3000.00m,
                            PolicyNumber = "POL002"
                        },
                        new
                        {
                            Id = 3,
                            PartnerId = 3,
                            PolicyAmount = 2000.00m,
                            PolicyNumber = "POL003"
                        },
                        new
                        {
                            Id = 4,
                            PartnerId = 4,
                            PolicyAmount = 6000.00m,
                            PolicyNumber = "POL004"
                        },
                        new
                        {
                            Id = 5,
                            PartnerId = 5,
                            PolicyAmount = 2500.00m,
                            PolicyNumber = "POL005"
                        });
                });

            modelBuilder.Entity("DomiZadatakWin.Models.Policy", b =>
                {
                    b.HasOne("DomiZadatakWin.Models.Partner", "Partner")
                        .WithMany("Policies")
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Partner");
                });

            modelBuilder.Entity("DomiZadatakWin.Models.Partner", b =>
                {
                    b.Navigation("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
