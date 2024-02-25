﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlympicsWebsite.Models;

#nullable disable

namespace OlympicsWebsite.Migrations
{
    [DbContext(typeof(CountryContext))]
    [Migration("20240224065940_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OlympicsWebsite.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SportID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryID");

                    b.HasIndex("GameID");

                    b.HasIndex("SportID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "can",
                            CountryImage = "Canada.png",
                            GameID = "wo",
                            Name = "Canada",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "swe",
                            CountryImage = "Sweden.png",
                            GameID = "wo",
                            Name = "Sweden",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "gbr",
                            CountryImage = "GreatBritain.png",
                            GameID = "wo",
                            Name = "Great Britain",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "jam",
                            CountryImage = "Jamaica.png",
                            GameID = "wo",
                            Name = "Jamaica",
                            SportID = "bobsl"
                        },
                        new
                        {
                            CountryID = "ita",
                            CountryImage = "Italy.png",
                            GameID = "wo",
                            Name = "Italy",
                            SportID = "bobsl"
                        },
                        new
                        {
                            CountryID = "jpn",
                            CountryImage = "Japan.png",
                            GameID = "wo",
                            Name = "Japan",
                            SportID = "bobsl"
                        },
                        new
                        {
                            CountryID = "ger",
                            CountryImage = "Germany.png",
                            GameID = "so",
                            Name = "Germany",
                            SportID = "dive"
                        },
                        new
                        {
                            CountryID = "chn",
                            CountryImage = "China.png",
                            GameID = "so",
                            Name = "China",
                            SportID = "dive"
                        },
                        new
                        {
                            CountryID = "mex",
                            CountryImage = "Mexico.png",
                            GameID = "so",
                            Name = "Mexico",
                            SportID = "dive"
                        },
                        new
                        {
                            CountryID = "bra",
                            CountryImage = "Brazil.png",
                            GameID = "so",
                            Name = "Brazil",
                            SportID = "cycl"
                        },
                        new
                        {
                            CountryID = "ned",
                            CountryImage = "Netherlands.png",
                            GameID = "so",
                            Name = "Netherlands",
                            SportID = "cycl"
                        },
                        new
                        {
                            CountryID = "usa",
                            CountryImage = "USA.png",
                            GameID = "so",
                            Name = "USA",
                            SportID = "cycl"
                        },
                        new
                        {
                            CountryID = "tha",
                            CountryImage = "Thailand.png",
                            GameID = "po",
                            Name = "Thailand",
                            SportID = "arch"
                        },
                        new
                        {
                            CountryID = "uru",
                            CountryImage = "Uruguay.png",
                            GameID = "po",
                            Name = "Uruguay",
                            SportID = "arch"
                        },
                        new
                        {
                            CountryID = "ukr",
                            CountryImage = "Ukraine.png",
                            GameID = "po",
                            Name = "Ukraine",
                            SportID = "arch"
                        },
                        new
                        {
                            CountryID = "aus",
                            CountryImage = "Austria.png",
                            GameID = "po",
                            Name = "Austria",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "pak",
                            CountryImage = "Pakistan.png",
                            GameID = "po",
                            Name = "Pakistan",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "zim",
                            CountryImage = "Zimbabwe.png",
                            GameID = "po",
                            Name = "Zimbabwe",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "fra",
                            CountryImage = "France.png",
                            GameID = "yo",
                            Name = "France",
                            SportID = "brkdnc"
                        },
                        new
                        {
                            CountryID = "cyp",
                            CountryImage = "Cyprus.png",
                            GameID = "yo",
                            Name = "Cyprus",
                            SportID = "brkdnc"
                        },
                        new
                        {
                            CountryID = "rus",
                            CountryImage = "Russia.png",
                            GameID = "yo",
                            Name = "Russia",
                            SportID = "brkdnc"
                        },
                        new
                        {
                            CountryID = "fin",
                            CountryImage = "Finland.png",
                            GameID = "yo",
                            Name = "Finland",
                            SportID = "skbrd"
                        },
                        new
                        {
                            CountryID = "svk",
                            CountryImage = "Slovakia.png",
                            GameID = "yo",
                            Name = "Slovakia",
                            SportID = "skbrd"
                        },
                        new
                        {
                            CountryID = "por",
                            CountryImage = "Portugal.png",
                            GameID = "yo",
                            Name = "Portugal",
                            SportID = "skbrd"
                        });
                });

            modelBuilder.Entity("OlympicsWebsite.Models.OlympicGame", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "wo",
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "so",
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "po",
                            Name = "Paralympics"
                        },
                        new
                        {
                            GameID = "yo",
                            Name = "Youth Olympics"
                        });
                });

            modelBuilder.Entity("OlympicsWebsite.Models.SportType", b =>
                {
                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportID");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportID = "curl",
                            Category = "Indoor",
                            Name = "Curling"
                        },
                        new
                        {
                            SportID = "bobsl",
                            Category = "Outdoor",
                            Name = "Bobsleigh"
                        },
                        new
                        {
                            SportID = "dive",
                            Category = "Indoor",
                            Name = "Diving"
                        },
                        new
                        {
                            SportID = "cycl",
                            Category = "Outdoor",
                            Name = "Road Cycling"
                        },
                        new
                        {
                            SportID = "arch",
                            Category = "Indoor",
                            Name = "Archery"
                        },
                        new
                        {
                            SportID = "canoe",
                            Category = "Outdoor",
                            Name = "Canoe Sprint"
                        },
                        new
                        {
                            SportID = "brkdnc",
                            Category = "Indoor",
                            Name = "Breakdancing"
                        },
                        new
                        {
                            SportID = "skbrd",
                            Category = "Outdoor",
                            Name = "Skateboarding"
                        });
                });

            modelBuilder.Entity("OlympicsWebsite.Models.Country", b =>
                {
                    b.HasOne("OlympicsWebsite.Models.OlympicGame", "Game")
                        .WithMany()
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlympicsWebsite.Models.SportType", "Sport")
                        .WithMany()
                        .HasForeignKey("SportID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
