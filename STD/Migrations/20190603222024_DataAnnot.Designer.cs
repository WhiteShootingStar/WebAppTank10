﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using STD.Models;

namespace STD.Migrations
{
    [DbContext(typeof(StdDbContext))]
    [Migration("20190603222024_DataAnnot")]
    partial class DataAnnot
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("STD.Models.Std", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<string>("Studies")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.HasKey("Id");

                    b.ToTable("Stds");
                });
#pragma warning restore 612, 618
        }
    }
}
