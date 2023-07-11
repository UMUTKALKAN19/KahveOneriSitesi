﻿// <auto-generated />
using System;
using KahveOneriSitesi.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KahveOneriSitesi.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("KahveAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KahveMalzeme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KahveResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KahveTarif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KahveTarih")
                        .HasColumnType("datetime2");

                    b.Property<bool>("KahveTur")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("KahveOneriSitesi.Data.Models.Oneri", b =>
                {
                    b.Property<int>("OneriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OnerenAdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneriAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OneriBegeni")
                        .HasColumnType("int");

                    b.Property<bool>("OneriDurum")
                        .HasColumnType("bit");

                    b.Property<string>("OneriMalzeme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneriResim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneriTarif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OneriTarih")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OneriTur")
                        .HasColumnType("bit");

                    b.HasKey("OneriID");

                    b.ToTable("Oneris");
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
