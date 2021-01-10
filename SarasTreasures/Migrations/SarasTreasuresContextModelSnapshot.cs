﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SarasTreasures.Data;

namespace SarasTreasures.Migrations
{
    [DbContext(typeof(SarasTreasuresContext))]
    partial class SarasTreasuresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SarasTreasures.Models.Story", b =>
                {
                    b.Property<int>("StoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(8000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("StoryID");

                    b.HasIndex("UserID");

                    b.ToTable("Story");

                    b.HasData(
                        new
                        {
                            StoryID = 1,
                            Date = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Filename = "zxyz.jpg",
                            Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Vestibulum sed arcu non odio euismod lacinia. Sed vulputate odio ut enim. Sem et tortor consequat id porta nibh venenatis cras. Turpis egestas pretium aenean pharetra magna. Fusce id velit ut tortor. Sit amet consectetur adipiscing elit ut aliquam. Feugiat in fermentum posuere urna nec.

                        Ut morbi tincidunt augue interdum velit euismod. Duis at consectetur lorem donec massa sapien faucibus. Nisl condimentum id venenatis a condimentum vitae. Justo eget magna fermentum iaculis. Tempus iaculis urna id volutpat. Et malesuada fames ac turpis egestas. Imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper.",
                            Title = "Papaya",
                            UserID = 1
                        },
                        new
                        {
                            StoryID = 2,
                            Date = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Filename = "zxyz.jpg",
                            Text = @"Est ultricies integer quis auctor elit sed vulputate. Dolor morbi non arcu risus quis varius quam quisque. Vitae congue eu consequat ac felis. Ut consequat semper viverra nam libero justo. In tellus integer feugiat scelerisque varius morbi enim nunc. Bibendum enim facilisis gravida neque convallis a cras semper auctor. Neque convallis a cras semper. Risus sed vulputate odio ut enim blandit volutpat.

                        Sagittis eu volutpat odio facilisis mauris sit amet. Quam vulputate dignissim suspendisse in est ante. Leo vel orci porta non pulvinar neque laoreet suspendisse. Auctor neque vitae tempus quam pellentesque nec. Risus nullam eget felis eget nunc lobortis mattis aliquam. Dignissim enim sit amet venenatis urna cursus eget nunc scelerisque.",
                            Title = "Little Bear",
                            UserID = 2
                        },
                        new
                        {
                            StoryID = 3,
                            Date = new DateTime(2020, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Filename = "xyzyg.jpg",
                            Text = @"Cras ornare arcu dui vivamus. Ultricies leo integer malesuada nunc vel risus commodo viverra. Mauris nunc congue nisi vitae. Donec ultrices tincidunt arcu non sodales neque sodales ut. Hac habitasse platea dictumst quisque sagittis purus. Donec ac odio tempor orci dapibus. Tellus orci ac auctor augue. Posuere lorem ipsum dolor sit. Lectus magna fringilla urna porttitor rhoncus dolor. Id velit ut tortor pretium viverra. Cursus eget nunc scelerisque viverra mauris in aliquam.

                        Velit laoreet id donec ultrices tincidunt arcu non sodales neque. Egestas integer eget aliquet nibh praesent tristique magna sit amet. Cursus risus at ultrices mi tempus imperdiet nulla. Non enim praesent elementum facilisis leo vel fringilla est. At varius vel pharetra vel.",
                            Title = "Big Bear",
                            UserID = 3
                        });
                });

            modelBuilder.Entity("SarasTreasures.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("UserID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            EmailAddress = "srosenblum@aol.com",
                            FirstName = "Sally",
                            LastName = "Rosenblum",
                            Username = "mrs.rosenblum"
                        },
                        new
                        {
                            UserID = 2,
                            EmailAddress = "paula_parrot@yahoo.com",
                            FirstName = "Paula",
                            LastName = "Parrot",
                            Username = "paula_parrot"
                        },
                        new
                        {
                            UserID = 3,
                            EmailAddress = "winelover387@hotmail.com",
                            FirstName = "Margot",
                            LastName = "Merlot",
                            Username = "margotmerlot"
                        });
                });

            modelBuilder.Entity("SarasTreasures.Models.Story", b =>
                {
                    b.HasOne("SarasTreasures.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
