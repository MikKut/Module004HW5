﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module004HW5.Context;

#nullable disable

namespace Module004HW5.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Module004HW5.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("InstagramUrl");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Phone");

                    b.HasKey("Id");

                    b.ToTable("Artist", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1998, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "snoop@gmail.com",
                            InstagramUrl = "https://www.instagram.com/snoopdogg/",
                            Name = "Snoop Dogg",
                            Phone = "+380761234567"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lil@gmail.com",
                            InstagramUrl = "https://www.instagram.com/lilnasxunlimited/",
                            Name = "Lil Nas X",
                            Phone = "+3804567812567"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1988, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "katy@gmail.com",
                            InstagramUrl = "https://www.instagram.com/katyperry/",
                            Name = "Katy Perry",
                            Phone = "+3807891234456"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1995, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rihanna@gmail.com",
                            InstagramUrl = "https://www.instagram.com/badgalriri/",
                            Name = "Rihanna",
                            Phone = "+3807895678123"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1997, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "billie@gmail.com",
                            InstagramUrl = "https://www.instagram.com/billieeilish/",
                            Name = "Billie Eilish",
                            Phone = "+3805674523456"
                        });
                });

            modelBuilder.Entity("Module004HW5.Models.ArtistSong", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int")
                        .HasColumnName("ArtistId");

                    b.Property<int>("SongId")
                        .HasColumnType("int")
                        .HasColumnName("SongId");

                    b.HasKey("ArtistId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSong", (string)null);

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            SongId = 1
                        },
                        new
                        {
                            ArtistId = 2,
                            SongId = 2
                        },
                        new
                        {
                            ArtistId = 3,
                            SongId = 3
                        },
                        new
                        {
                            ArtistId = 4,
                            SongId = 4
                        },
                        new
                        {
                            ArtistId = 5,
                            SongId = 5
                        });
                });

            modelBuilder.Entity("Module004HW5.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Genre", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Pop"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Rap"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Rock"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Jazz"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Classical"
                        });
                });

            modelBuilder.Entity("Module004HW5.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2")
                        .HasColumnName("Duration");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int")
                        .HasColumnName("GenreId");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ReleasedDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Song", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = new DateTime(2000, 8, 15, 0, 2, 30, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            ReleasedDate = new DateTime(2018, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Beautiful"
                        },
                        new
                        {
                            Id = 2,
                            Duration = new DateTime(2000, 8, 15, 0, 3, 50, 0, DateTimeKind.Unspecified),
                            GenreId = 2,
                            ReleasedDate = new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Old Town Road"
                        },
                        new
                        {
                            Id = 3,
                            Duration = new DateTime(2000, 8, 15, 0, 1, 40, 0, DateTimeKind.Unspecified),
                            GenreId = 3,
                            ReleasedDate = new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Dark Hourse"
                        },
                        new
                        {
                            Id = 4,
                            Duration = new DateTime(2000, 8, 15, 0, 2, 25, 0, DateTimeKind.Unspecified),
                            GenreId = 4,
                            ReleasedDate = new DateTime(2020, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Diamonds"
                        },
                        new
                        {
                            Id = 5,
                            Duration = new DateTime(2000, 8, 15, 0, 3, 22, 0, DateTimeKind.Unspecified),
                            GenreId = 5,
                            ReleasedDate = new DateTime(2022, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Lovely"
                        });
                });

            modelBuilder.Entity("Module004HW5.Models.ArtistSong", b =>
                {
                    b.HasOne("Module004HW5.Models.Artist", "Artist")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module004HW5.Models.Song", "Song")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Module004HW5.Models.Song", b =>
                {
                    b.HasOne("Module004HW5.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Module004HW5.Models.Artist", b =>
                {
                    b.Navigation("ArtistSongs");
                });

            modelBuilder.Entity("Module004HW5.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Module004HW5.Models.Song", b =>
                {
                    b.Navigation("ArtistSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
