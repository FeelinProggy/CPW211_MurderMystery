﻿// <auto-generated />
using CPW211_MurderMystery;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CPW211_MurderMystery.Migrations
{
    [DbContext(typeof(MurderMysteryContext))]
    partial class MurderMysteryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CPW211_MurderMystery.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"));

                    b.Property<string>("CharScript")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            CharacterId = 1,
                            CharScript = "TDB",
                            Desc = "Father of Deimos, Phobos and Eden",
                            FullName = "Mars Olufemi",
                            Gender = "Male",
                            Occupation = "Cartographer"
                        },
                        new
                        {
                            CharacterId = 2,
                            CharScript = "TDB",
                            Desc = "Son of Mars, twin brother of Phobos, and elder brother of Eden.",
                            FullName = "Deimos Olufemi",
                            Gender = "Male",
                            Occupation = "Singer"
                        },
                        new
                        {
                            CharacterId = 3,
                            CharScript = "TDB",
                            Desc = "Son of Mars, twin brother of Deimos, and elder brother of Eden.",
                            FullName = "Phobos Olufemi",
                            Gender = "Male",
                            Occupation = "Locksmith"
                        },
                        new
                        {
                            CharacterId = 4,
                            CharScript = "TDB",
                            Desc = "Adopted daughter of Mars and younger sister of Deimos and Phobos.",
                            FullName = "Eden Olufemi",
                            Gender = "Female",
                            Occupation = "Musician"
                        },
                        new
                        {
                            CharacterId = 5,
                            CharScript = "TDB",
                            Desc = "Best friend of Phoebe.",
                            FullName = "Tahlia Collins",
                            Gender = "Female",
                            Occupation = "Gardener"
                        },
                        new
                        {
                            CharacterId = 6,
                            CharScript = "TDB",
                            Desc = "Best friend of Tahlia.",
                            FullName = "Phoebe Mandrapilias",
                            Gender = "Female",
                            Occupation = "Painter"
                        },
                        new
                        {
                            CharacterId = 7,
                            CharScript = "TDB",
                            Desc = "Wife/business partner of Walter and mother of Jamie.",
                            FullName = "Silvia Honey",
                            Gender = "Female",
                            Occupation = "Shop Owner"
                        },
                        new
                        {
                            CharacterId = 8,
                            CharScript = "TDB",
                            Desc = "Husband/business partner of Silvia and father of Jamie.",
                            FullName = "Walter Honey",
                            Gender = "Male",
                            Occupation = "Shop Owner"
                        },
                        new
                        {
                            CharacterId = 9,
                            CharScript = "TDB",
                            Desc = "Son of Walter and Silvia. Jamie was often babysat by Deimos as a child, and the two are still very close to this day. Jamie is also friends with Elliot, and often spends time in his library. Although, while the two enjoy talking, Jamie can’t say he knows much about Elliot personally.",
                            FullName = "Jamie Honey",
                            Gender = "Male",
                            Occupation = "Waiter"
                        },
                        new
                        {
                            CharacterId = 10,
                            CharScript = "TDB",
                            Desc = "Friend of Jamie, but much of his past is a mystery to Jamie.",
                            FullName = "Elliot Perry",
                            Gender = "Male",
                            Occupation = "Librarian"
                        });
                });

            modelBuilder.Entity("CPW211_MurderMystery.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"));

                    b.Property<string>("PlayerFullName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PlayerGender")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CPW211_MurderMystery.Theme", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThemeId"));

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ThemeId");

                    b.ToTable("Themes");
                });
#pragma warning restore 612, 618
        }
    }
}
