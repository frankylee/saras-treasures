﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SarasTreasures.Models;

namespace SarasTreasures.Migrations
{
    [DbContext(typeof(StoryContext))]
    [Migration("20201104222207_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("SarasTreasures.Models.Story", b =>
                {
                    b.Property<int>("StoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserNameUserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("StoryID");

                    b.HasIndex("UserNameUserID");

                    b.ToTable("HappyTails");
                });

            modelBuilder.Entity("SarasTreasures.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SarasTreasures.Models.Story", b =>
                {
                    b.HasOne("SarasTreasures.Models.User", "UserName")
                        .WithMany()
                        .HasForeignKey("UserNameUserID");
                });
#pragma warning restore 612, 618
        }
    }
}
