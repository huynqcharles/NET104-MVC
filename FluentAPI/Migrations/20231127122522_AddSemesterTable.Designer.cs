﻿// <auto-generated />
using System;
using FluentAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FluentAPI.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20231127122522_AddSemesterTable")]
    partial class AddSemesterTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FluentAPI.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("AddressDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("FluentAPI.Models.Semester", b =>
                {
                    b.Property<int>("SemesterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemesterID"), 1L, 1);

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SemesterID");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("FluentAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date of Birth");

                    b.Property<int>("SemesterID")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("SemesterID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FluentAPI.Models.Address", b =>
                {
                    b.HasOne("FluentAPI.Models.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("FluentAPI.Models.Address", "AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("FluentAPI.Models.Student", b =>
                {
                    b.HasOne("FluentAPI.Models.Semester", "Semester")
                        .WithMany("Students")
                        .HasForeignKey("SemesterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("FluentAPI.Models.Semester", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("FluentAPI.Models.Student", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
