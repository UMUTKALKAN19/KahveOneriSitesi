﻿// <auto-generated />
using System;
using KahveOneriSitesi.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KahveOneriSitesi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230511112918_deneme1")]
    partial class deneme1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KahveOneriSitesi.Data.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminKadi")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("AdminSifre")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("KahveOneriSitesi.Data.Models.Kahve", b =>
                {
                    b.Property<int>("KahveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KahveAd")
                        .HasColumnType("int");

                    b.Property<int>("KahveMalzeme")
                        .HasColumnType("int");

                    b.Property<int>("KahveResim")
                        .HasColumnType("int");

                    b.Property<int>("KahveTarif")
                        .HasColumnType("int");

                    b.Property<DateTime>("KahveTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("KahveTur")
                        .HasColumnType("int");

                    b.HasKey("KahveID");

                    b.ToTable("Kahvelers");
                });

            modelBuilder.Entity("KahveOneriSitesi.Data.Models.Mesajlar", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MesajBaslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MesajGonderen")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("MesajIcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("MesajMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajID");

                    b.ToTable("Mesajlars");
                });

            modelBuilder.Entity("KahveOneriSitesi.Data.Models.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KahveID")
                        .HasColumnType("int");

                    b.Property<string>("YorumIcerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("YorumMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("YorumOnay")
                        .HasColumnType("bit");

                    b.Property<string>("YorumSahip")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("YorumTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("YorumID");

                    b.HasIndex("KahveID");

                    b.ToTable("Yorumlars");
                });

            modelBuilder.Entity("KahveOneriSitesi.Data.Models.Yorum", b =>
                {
                    b.HasOne("KahveOneriSitesi.Data.Models.Kahve", "Kahve")
                        .WithMany("Yorumlar")
                        .HasForeignKey("KahveID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
