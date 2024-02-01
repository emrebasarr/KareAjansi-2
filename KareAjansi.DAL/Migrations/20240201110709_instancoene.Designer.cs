﻿// <auto-generated />
using System;
using KareAjansi.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KareAjansi.DAL.Migrations
{
    [DbContext(typeof(KareAjansiContext))]
    [Migration("20240201110709_instancoene")]
    partial class instancoene
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KareAjansi.Entity.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Kategori1",
                            CreatedComputerName = "DESKTOP-R1GI7QV",
                            CreatedDate = new DateTime(2024, 2, 1, 14, 7, 9, 73, DateTimeKind.Local).AddTicks(7539),
                            CreatedIpAddress = "192.168.1.26",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Kategori2",
                            CreatedComputerName = "DESKTOP-R1GI7QV",
                            CreatedDate = new DateTime(2024, 2, 1, 14, 7, 9, 74, DateTimeKind.Local).AddTicks(415),
                            CreatedIpAddress = "192.168.1.26",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Kategori3",
                            CreatedComputerName = "DESKTOP-R1GI7QV",
                            CreatedDate = new DateTime(2024, 2, 1, 14, 7, 9, 74, DateTimeKind.Local).AddTicks(1866),
                            CreatedIpAddress = "192.168.1.26",
                            Status = 1
                        });
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Manken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AyakkabiNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beden")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ehliyet")
                        .HasColumnType("bit");

                    b.Property<string>("GozRengi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Kilo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ozellik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SacRengi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SehirDisiCalisabilmeDurumu")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Tel1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YabanciDil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Mankenler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Emre",
                            Adres = "Ornek Adres",
                            AyakkabiNo = "42",
                            Beden = "Medium",
                            Cinsiyet = "Bay",
                            CreatedComputerName = "DESKTOP-R1GI7QV",
                            CreatedDate = new DateTime(2024, 2, 1, 14, 7, 9, 74, DateTimeKind.Local).AddTicks(3270),
                            CreatedIpAddress = "192.168.1.26",
                            Ehliyet = true,
                            GozRengi = "Kahverengi",
                            KategoriId = 1,
                            Kilo = "65",
                            Ozellik = "Ornek Ozellik",
                            SacRengi = "Siyah",
                            SehirDisiCalisabilmeDurumu = true,
                            Soyad = "Bilge",
                            Status = 1,
                            Tel1 = "555-555-5555",
                            Tel2 = "555-555-5556",
                            YabanciDil = "İngilizce"
                        });
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Odeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GunSayisi")
                        .HasColumnType("int");

                    b.Property<int>("Harcama")
                        .HasColumnType("int");

                    b.Property<int>("Kar")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("KonaklamaUcreti")
                        .HasColumnType("int");

                    b.Property<bool>("Konum")
                        .HasColumnType("bit");

                    b.Property<string>("MankenAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MankenId")
                        .HasColumnType("int");

                    b.Property<int>("MankenSayisi")
                        .HasColumnType("int");

                    b.Property<int>("Odenecek")
                        .HasColumnType("int");

                    b.Property<int>("OrganizasyonId")
                        .HasColumnType("int");

                    b.Property<int>("SirkettenAlinacakUcret")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Toplam")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YemekUcreti")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("MankenId");

                    b.HasIndex("OrganizasyonId");

                    b.ToTable("Odemeler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedComputerName = "DESKTOP-R1GI7QV",
                            CreatedDate = new DateTime(2024, 2, 1, 14, 7, 9, 74, DateTimeKind.Local).AddTicks(8706),
                            CreatedIpAddress = "192.168.1.26",
                            GunSayisi = 0,
                            Harcama = 0,
                            Kar = 0,
                            KategoriId = 1,
                            KonaklamaUcreti = 40,
                            Konum = true,
                            MankenAdi = "Emre",
                            MankenId = 1,
                            MankenSayisi = 0,
                            Odenecek = 0,
                            OrganizasyonId = 1,
                            SirkettenAlinacakUcret = 0,
                            Status = 1,
                            Toplam = 0,
                            YemekUcreti = 50
                        });
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Organizasyon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GunSayisi")
                        .HasColumnType("int");

                    b.Property<int>("Odenecek")
                        .HasColumnType("int");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organizasyonlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Ornek Organizasyon",
                            BaslangicTarihi = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BitisTarihi = new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedComputerName = "DESKTOP-R1GI7QV",
                            CreatedDate = new DateTime(2024, 2, 1, 14, 7, 9, 74, DateTimeKind.Local).AddTicks(4662),
                            CreatedIpAddress = "192.168.1.26",
                            Firma = "Ornek Firma",
                            GunSayisi = 7,
                            Odenecek = 10000,
                            Sehir = "İstanbul",
                            Status = 1
                        });
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.OrganizasyonManken", b =>
                {
                    b.Property<int>("OrganizasyonId")
                        .HasColumnType("int");

                    b.Property<int>("MankenId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("KatilmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizasyonId", "MankenId");

                    b.HasIndex("MankenId");

                    b.ToTable("OrganizasyonMankenler");

                    b.HasData(
                        new
                        {
                            OrganizasyonId = 1,
                            MankenId = 1,
                            CreatedComputerName = "DESKTOP-R1GI7QV",
                            CreatedDate = new DateTime(2024, 2, 1, 14, 7, 9, 74, DateTimeKind.Local).AddTicks(6010),
                            CreatedIpAddress = "192.168.1.26",
                            Id = 1,
                            KatilmaTarihi = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = 1
                        });
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedComputerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MankenId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yazari")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yorumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MankenId");

                    b.ToTable("Yorumlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedComputerName = "DESKTOP-R1GI7QV",
                            CreatedDate = new DateTime(2024, 2, 1, 14, 7, 9, 74, DateTimeKind.Local).AddTicks(7358),
                            CreatedIpAddress = "192.168.1.26",
                            MankenId = 1,
                            Status = 1,
                            Yazari = "Emre",
                            Yorumu = "Böyle devam et"
                        });
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Manken", b =>
                {
                    b.HasOne("KareAjansi.Entity.Models.Kategori", "Kategori")
                        .WithMany("Mankenler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Odeme", b =>
                {
                    b.HasOne("KareAjansi.Entity.Models.Kategori", "Kategori")
                        .WithMany("Odemeler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KareAjansi.Entity.Models.Manken", "Manken")
                        .WithMany("Odemeler")
                        .HasForeignKey("MankenId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("KareAjansi.Entity.Models.Organizasyon", "Organizasyon")
                        .WithMany("Odemeler")
                        .HasForeignKey("OrganizasyonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Manken");

                    b.Navigation("Organizasyon");
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.OrganizasyonManken", b =>
                {
                    b.HasOne("KareAjansi.Entity.Models.Manken", "Manken")
                        .WithMany("OrganizasyonMankenler")
                        .HasForeignKey("MankenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KareAjansi.Entity.Models.Organizasyon", "Organizasyon")
                        .WithMany("OrganizasyonMankenler")
                        .HasForeignKey("OrganizasyonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manken");

                    b.Navigation("Organizasyon");
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Yorum", b =>
                {
                    b.HasOne("KareAjansi.Entity.Models.Manken", "Manken")
                        .WithMany("yorumlar")
                        .HasForeignKey("MankenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manken");
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Kategori", b =>
                {
                    b.Navigation("Mankenler");

                    b.Navigation("Odemeler");
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Manken", b =>
                {
                    b.Navigation("Odemeler");

                    b.Navigation("OrganizasyonMankenler");

                    b.Navigation("yorumlar");
                });

            modelBuilder.Entity("KareAjansi.Entity.Models.Organizasyon", b =>
                {
                    b.Navigation("Odemeler");

                    b.Navigation("OrganizasyonMankenler");
                });
#pragma warning restore 612, 618
        }
    }
}