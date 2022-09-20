﻿// <auto-generated />
using System;
using Arahk.AntifakeNews.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Arahk.AntifakeNews.WebApi.Data.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Arahk.AntifakeNews.Infrastructure.Data.Entities.ContentDbEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<string>("Organize")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TitleEn")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("TitleTh")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("Contents", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7b5a9dec-7122-4844-983f-606a0add2e95"),
                            Author = "Sint incididunt",
                            CreatedById = new Guid("ac7383b1-3703-462c-89c9-d8d5534d0db1"),
                            CreatedOn = new DateTime(2022, 9, 18, 20, 54, 0, 0, DateTimeKind.Unspecified),
                            Detail = "Ea nisi laborum ullamco veniam ullamco nisi anim. Ad proident duis tempor sint reprehenderit nisi reprehenderit voluptate mollit veniam amet velit dolor est. Labore veniam sit dolor consectetur minim esse. Elit nisi Lorem magna ad enim elit pariatur laborum dolore deserunt esse.Tempor nulla in nisi tempor dolor Lorem. Minim mollit sunt sint aute occaecat Lorem quis incididunt adipisicing. Qui nisi consectetur occaecat eiusmod tempor ullamco minim nisi commodo est veniam sint ut fugiat. Do enim id ad irure incididunt magna consequat. Consectetur magna tempor Lorem tempor voluptate incididunt sit.",
                            Organize = "Est exercitation",
                            TitleEn = "Officia ea in elit commodo veniam.",
                            TitleTh = ""
                        },
                        new
                        {
                            Id = new Guid("1a210062-d9f5-4795-922a-2aa07827eca1"),
                            Author = "Cupidatat",
                            CreatedById = new Guid("ac7383b1-3703-462c-89c9-d8d5534d0db1"),
                            CreatedOn = new DateTime(2022, 6, 28, 14, 27, 0, 0, DateTimeKind.Unspecified),
                            Detail = "Elit reprehenderit non occaecat nostrud esse et nisi nulla velit do esse proident aliqua reprehenderit. Ullamco est laboris do do duis sint. Consectetur fugiat cillum pariatur duis nisi et. Reprehenderit pariatur nulla laboris consectetur irure pariatur.Ad cillum quis sit minim commodo esse in mollit anim consequat et. Consectetur pariatur consequat proident deserunt commodo aliquip Lorem. Officia qui reprehenderit Lorem officia quis non aliquip qui officia velit ipsum. Id cupidatat nisi sint cillum dolor do est culpa exercitation voluptate aliquip. Id irure irure proident ex proident eiusmod irure deserunt deserunt excepteur veniam commodo fugiat id. Dolor consectetur in amet cupidatat mollit.",
                            Organize = "Proident exercitation",
                            TitleEn = "Anim dolor deserunt consectetur do ad deserunt.",
                            TitleTh = "แล้วสอนว่าอย่าไว้ใจมนุษย์ มันแสนสุดลึกล้ำเหลือกำหนด"
                        });
                });

            modelBuilder.Entity("Arahk.AntifakeNews.Infrastructure.Data.Entities.UserDbEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Members", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac7383b1-3703-462c-89c9-d8d5534d0db1"),
                            Firstname = "Estio",
                            Lastname = "officia"
                        });
                });

            modelBuilder.Entity("Arahk.AntifakeNews.Infrastructure.Data.Entities.ContentDbEntity", b =>
                {
                    b.HasOne("Arahk.AntifakeNews.Infrastructure.Data.Entities.UserDbEntity", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CreatedBy");
                });
#pragma warning restore 612, 618
        }
    }
}