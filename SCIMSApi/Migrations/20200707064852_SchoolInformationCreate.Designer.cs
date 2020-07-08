﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCIMSApi.Models;

namespace SCIMSApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200707064852_SchoolInformationCreate")]
    partial class SchoolInformationCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCIMSApi.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new { Id = 1, GenderName = "Male" },
                        new { Id = 2, GenderName = "Female" }
                    );
                });

            modelBuilder.Entity("SCIMSApi.Models.SchoolInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(500);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Logo");

                    b.Property<string>("Mobile")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("RegistrationNo");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("SchoolInformation");

                    b.HasData(
                        new { Id = 1, Address = "Abu Dhabi, UAE", CreatedBy = 1, CreatedDate = new DateTime(2020, 7, 7, 10, 48, 52, 272, DateTimeKind.Local), IsActive = true, Logo = "this.png", Mobile = "91 45454655", Name = "Test School One", Phone = "0302 45454555", RegistrationNo = "011121110" }
                    );
                });

            modelBuilder.Entity("SCIMSApi.Models.UserInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("GenderId");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("UserInformations");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(2020, 7, 7, 10, 48, 52, 269, DateTimeKind.Local), FullName = "Admin", GenderId = 1, IsActive = true, UserName = "admin@gmail.com", UserPassword = "1234" }
                    );
                });

            modelBuilder.Entity("SCIMSApi.Models.SchoolInformation", b =>
                {
                    b.HasOne("SCIMSApi.Models.UserInformation", "UserInformation")
                        .WithMany("SchoolInformations")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SCIMSApi.Models.UserInformation", b =>
                {
                    b.HasOne("SCIMSApi.Models.Gender", "Gender")
                        .WithMany("UserInformations")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
