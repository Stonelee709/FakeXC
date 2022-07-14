﻿// <auto-generated />
using System;
using FakeXC.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FakeXC.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220710103140_DataSeeding")]
    partial class DataSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FakeXC.API.Models.TouristRoute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DepatureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.Property<double?>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<string>("Feature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fees")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TouristRoutes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                            CreateTime = new DateTime(2022, 7, 10, 10, 31, 40, 307, DateTimeKind.Utc).AddTicks(3128),
                            Description = "黄山一日游",
                            Feature = "<p>吃住行购物<p>",
                            Fees = "<p>交通费自理<p>",
                            Notes = "<p>小心危险<p>",
                            OriginalPrice = 1299m,
                            Title = "黄山"
                        });
                });

            modelBuilder.Entity("FakeXC.API.Models.TouristRoutePicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("TouristRouteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("TouristRouteId");

                    b.ToTable("TouristRoutePictures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TouristRouteId = new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                            Url = "www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                        },
                        new
                        {
                            Id = 2,
                            TouristRouteId = new Guid("30d318ad-e39c-4b8f-baa3-858431affc67"),
                            Url = "www.image.com/30d318ad-e39c-4b8f-baa3-858431affc67.jpg"
                        });
                });

            modelBuilder.Entity("FakeXC.API.Models.TouristRoutePicture", b =>
                {
                    b.HasOne("FakeXC.API.Models.TouristRoute", "TouristRoute")
                        .WithMany("TouristRoutePicture")
                        .HasForeignKey("TouristRouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TouristRoute");
                });

            modelBuilder.Entity("FakeXC.API.Models.TouristRoute", b =>
                {
                    b.Navigation("TouristRoutePicture");
                });
#pragma warning restore 612, 618
        }
    }
}
