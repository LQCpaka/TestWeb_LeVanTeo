﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestWeb_LeVanTeo.Models;

namespace TestWeb_LeVanTeo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240625030643_ThemDuLieuLanDau")]
    partial class ThemDuLieuLanDau
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestWeb_LeVanTeo.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "A",
                            Price = 12000.0,
                            Quantity = 10,
                            Title = "PHP"
                        },
                        new
                        {
                            Id = 2,
                            Author = "A",
                            Price = 12000.0,
                            Quantity = 15,
                            Title = "C#"
                        },
                        new
                        {
                            Id = 3,
                            Author = "A",
                            Price = 12000.0,
                            Quantity = 10,
                            Title = "Quản trị SQL Server"
                        },
                        new
                        {
                            Id = 4,
                            Author = "A",
                            Price = 12000.0,
                            Quantity = 15,
                            Title = "Lập trình Node.js"
                        },
                        new
                        {
                            Id = 5,
                            Author = "A",
                            Price = 12000.0,
                            Quantity = 10,
                            Title = "ASP.Net Core MVC"
                        },
                        new
                        {
                            Id = 6,
                            Author = "A",
                            Price = 12000.0,
                            Quantity = 15,
                            Title = "Cấu trúc dữ liệu"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
