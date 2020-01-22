﻿// <auto-generated />
using Doggo_Capstone_backEnd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DoggoCapstonebackEnd.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200121234545_AddedTables")]
    partial class AddedTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Doggo_Capstone_backEnd.Models.EnergyLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Level")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EnergyLevels");
                });

            modelBuilder.Entity("Doggo_Capstone_backEnd.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Sex")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("Doggo_Capstone_backEnd.Models.InterestedEnergyLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("EnergyLevelId")
                        .HasColumnType("integer");

                    b.Property<string>("InterestedIn")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EnergyLevelId");

                    b.ToTable("InterestedEnergyLevels");
                });

            modelBuilder.Entity("Doggo_Capstone_backEnd.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("About")
                        .HasColumnType("text");

                    b.Property<string>("Breed")
                        .HasColumnType("text");

                    b.Property<int>("EnergyLevelId")
                        .HasColumnType("integer");

                    b.Property<int>("GenderId")
                        .HasColumnType("integer");

                    b.Property<int>("InterestedEnergyLevelId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EnergyLevelId");

                    b.HasIndex("GenderId");

                    b.HasIndex("InterestedEnergyLevelId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Doggo_Capstone_backEnd.Models.InterestedEnergyLevel", b =>
                {
                    b.HasOne("Doggo_Capstone_backEnd.Models.EnergyLevel", "EnergyLevel")
                        .WithMany()
                        .HasForeignKey("EnergyLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Doggo_Capstone_backEnd.Models.User", b =>
                {
                    b.HasOne("Doggo_Capstone_backEnd.Models.EnergyLevel", "EnergyLevel")
                        .WithMany("Users")
                        .HasForeignKey("EnergyLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Doggo_Capstone_backEnd.Models.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Doggo_Capstone_backEnd.Models.InterestedEnergyLevel", "InterestedEnergyLevel")
                        .WithMany("Users")
                        .HasForeignKey("InterestedEnergyLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}