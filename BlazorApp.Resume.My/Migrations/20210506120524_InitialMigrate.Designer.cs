﻿// <auto-generated />
using System;
using BlazorApp.Resume.My.Persistence.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp.Resume.My.Migrations
{
    [DbContext(typeof(KEODbContext))]
    [Migration("20210506120524_InitialMigrate")]
    partial class InitialMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("BlazorApp.Resume.My.Persistence.Data.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("993e0619-9e9e-4b19-b599-57b579fe2965"),
                            LoginTime = new DateTime(2021, 5, 6, 13, 5, 23, 720, DateTimeKind.Local).AddTicks(3872),
                            PasswordKey = "$2a$11$Sx4/6PnA83L2SUomf8JQc.rz3XoVJdrFJubTO0DgejDulPQ0Zzu8m",
                            UserName = "kodex"
                        });
                });

            modelBuilder.Entity("BlazorApp.Resume.My.Persistence.Data.ResumeLike", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<long>("Counter")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("IPAddress")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLiked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SystemName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SystemOS")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}
