﻿// <auto-generated />
using Matriculas.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Matriculas.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220513191753_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Matriculas.Web.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("ClassSchedule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CourseCost")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateInscripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinalDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InicialDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Intensity")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("CourseCode")
                        .IsUnique();

                    b.ToTable("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
