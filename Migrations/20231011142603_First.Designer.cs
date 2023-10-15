﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


#nullable disable

namespace traingapp.Migrations
{
    [DbContext(typeof(TrainingDB))]
    [Migration("20231011142603_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("traingapp.Models.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("SessionNumber")
                        .HasColumnType("int");

                    b.Property<int>("TPID")
                        .HasColumnType("int");

                    b.Property<int>("TrainingProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainingProgramId");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("traingapp.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int>("RestInSeconds")
                        .HasColumnType("int");

                    b.Property<int>("Set")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("traingapp.Models.TrainingProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("traingapp.Models.Day", b =>
                {
                    b.HasOne("traingapp.Models.TrainingProgram", "TrainingProgram")
                        .WithMany("TrainingDays")
                        .HasForeignKey("TrainingProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("traingapp.Models.Exercise", b =>
                {
                    b.HasOne("traingapp.Models.Day", "TrainingDay")
                        .WithMany("ExerciseList")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingDay");
                });

            modelBuilder.Entity("traingapp.Models.Day", b =>
                {
                    b.Navigation("ExerciseList");
                });

            modelBuilder.Entity("traingapp.Models.TrainingProgram", b =>
                {
                    b.Navigation("TrainingDays");
                });
#pragma warning restore 612, 618
        }
    }
}
