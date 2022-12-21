﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsApplication;

namespace SportsApplication.Migrations
{
    [DbContext(typeof(SportsContextClass))]
    [Migration("20221221025902_football")]
    partial class football
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SportsApplication.Models.Bigbash", b =>
                {
                    b.Property<int>("Player_Id")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player_Cost")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cost");

                    b.Property<string>("Player_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Player_Id");

                    b.ToTable("Bigbashs");
                });

            modelBuilder.Entity("SportsApplication.Models.Cricket", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Crickets");
                });

            modelBuilder.Entity("SportsApplication.Models.Football", b =>
                {
                    b.Property<int>("Player_Id")
                        .HasColumnType("int");

                    b.Property<int>("PlayerRefId")
                        .HasColumnType("int");

                    b.Property<string>("Player_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tropies")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Player_Id");

                    b.HasIndex("PlayerRefId");

                    b.ToTable("Footballs");
                });

            modelBuilder.Entity("SportsApplication.Models.FootballClub", b =>
                {
                    b.Property<int>("Player_Id")
                        .HasColumnType("int");

                    b.Property<string>("Club_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Player_Id");

                    b.ToTable("FootballClubs");
                });

            modelBuilder.Entity("SportsApplication.Models.Ipl", b =>
                {
                    b.Property<int>("Player_Id")
                        .HasColumnType("int");

                    b.Property<int?>("BigbashPlayer_Id")
                        .HasColumnType("int");

                    b.Property<string>("Ipl_Team")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Player_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Player_Id");

                    b.HasIndex("BigbashPlayer_Id");

                    b.ToTable("Ipls");
                });

            modelBuilder.Entity("SportsApplication.Models.Football", b =>
                {
                    b.HasOne("SportsApplication.Models.FootballClub", "FootballClub")
                        .WithMany("Footballs")
                        .HasForeignKey("PlayerRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FootballClub");
                });

            modelBuilder.Entity("SportsApplication.Models.Ipl", b =>
                {
                    b.HasOne("SportsApplication.Models.Bigbash", "Bigbash")
                        .WithMany()
                        .HasForeignKey("BigbashPlayer_Id");

                    b.Navigation("Bigbash");
                });

            modelBuilder.Entity("SportsApplication.Models.FootballClub", b =>
                {
                    b.Navigation("Footballs");
                });
#pragma warning restore 612, 618
        }
    }
}
