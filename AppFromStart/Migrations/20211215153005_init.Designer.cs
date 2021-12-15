﻿// <auto-generated />
using AppFromStart.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppFromStart.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20211215153005_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppFromStart.Models.Course", b =>
                {
                    b.Property<int>("CourseNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseNumber");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseNumber = 1,
                            Description = "Master teh art of databse",
                            Name = "RDBMS"
                        },
                        new
                        {
                            CourseNumber = 2,
                            Description = "Microsoft C# for Dotnet",
                            Name = "C#"
                        });
                });

            modelBuilder.Entity("AppFromStart.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Course_Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Course_Id = 1,
                            Name = "Jim",
                            Status = "Registered"
                        },
                        new
                        {
                            Id = 102,
                            Course_Id = 1,
                            Name = "Jack",
                            Status = "Enrolled"
                        });
                });

            modelBuilder.Entity("AppFromStart.Models.Student", b =>
                {
                    b.HasOne("AppFromStart.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("Course_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("AppFromStart.Models.Course", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}