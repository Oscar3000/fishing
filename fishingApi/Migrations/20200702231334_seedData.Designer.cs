﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using fishingApi.Data;

namespace fishingApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200702231334_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("fishingApi.Models.Boat", b =>
                {
                    b.Property<int>("BoatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("B")
                        .HasColumnType("decimal(14,1)");

                    b.Property<int>("BuildNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("LOA")
                        .HasColumnType("decimal(14,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Picture")
                        .HasColumnType("tinyint");

                    b.Property<string>("Producer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BoatId");

                    b.ToTable("Boats");

                    b.HasData(
                        new
                        {
                            BoatId = 1,
                            B = 30.32m,
                            BuildNumber = 10,
                            LOA = 201.23m,
                            Name = "Destroyer",
                            Picture = (byte)0,
                            Producer = "Centos Company"
                        },
                        new
                        {
                            BoatId = 2,
                            B = 60.32m,
                            BuildNumber = 3,
                            LOA = 221.23m,
                            Name = "Harbinger",
                            Picture = (byte)0,
                            Producer = "Centos Company"
                        },
                        new
                        {
                            BoatId = 3,
                            B = 50.82m,
                            BuildNumber = 5,
                            LOA = 301.24m,
                            Name = "GameChanger",
                            Picture = (byte)0,
                            Producer = "Centos Company"
                        },
                        new
                        {
                            BoatId = 4,
                            B = 30.382m,
                            BuildNumber = 13,
                            LOA = 301.27m,
                            Name = "LoverBoy",
                            Picture = (byte)0,
                            Producer = "Hey Company"
                        },
                        new
                        {
                            BoatId = 5,
                            B = 30.32m,
                            BuildNumber = 8,
                            LOA = 203.23m,
                            Name = "Hope",
                            Picture = (byte)0,
                            Producer = "None Company"
                        },
                        new
                        {
                            BoatId = 6,
                            B = 30.32m,
                            BuildNumber = 2,
                            LOA = 301.23m,
                            Name = "Startropper",
                            Picture = (byte)0,
                            Producer = "John Company"
                        },
                        new
                        {
                            BoatId = 7,
                            B = 30.32m,
                            BuildNumber = 140,
                            LOA = 751.23m,
                            Name = "Johnson",
                            Picture = (byte)0,
                            Producer = "Centos Company"
                        },
                        new
                        {
                            BoatId = 8,
                            B = 350.32m,
                            BuildNumber = 120,
                            LOA = 6071.23m,
                            Name = "Lost",
                            Picture = (byte)0,
                            Producer = "tom Company"
                        },
                        new
                        {
                            BoatId = 9,
                            B = 350.32m,
                            BuildNumber = 30,
                            LOA = 2601.23m,
                            Name = "Titanic",
                            Picture = (byte)0,
                            Producer = "Centos Company"
                        });
                });

            modelBuilder.Entity("fishingApi.Models.CrewMember", b =>
                {
                    b.Property<int>("CrewMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("BoatId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CertifiedUntil")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Picture")
                        .HasColumnType("tinyint");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CrewMemberId");

                    b.HasIndex("BoatId");

                    b.ToTable("CrewMembers");

                    b.HasData(
                        new
                        {
                            CrewMemberId = 1,
                            Age = 34,
                            BoatId = 1,
                            CertifiedUntil = new DateTime(2020, 7, 3, 2, 13, 33, 559, DateTimeKind.Local).AddTicks(1090),
                            Name = "James",
                            Picture = (byte)0,
                            Role = "Captain"
                        },
                        new
                        {
                            CrewMemberId = 2,
                            Age = 24,
                            BoatId = 3,
                            CertifiedUntil = new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2496),
                            Name = "Elena",
                            Picture = (byte)0,
                            Role = "Deck Cadet"
                        },
                        new
                        {
                            CrewMemberId = 3,
                            Age = 44,
                            BoatId = 5,
                            CertifiedUntil = new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2569),
                            Name = "Prince",
                            Picture = (byte)0,
                            Role = "Chief Engineer"
                        },
                        new
                        {
                            CrewMemberId = 4,
                            Age = 30,
                            BoatId = 6,
                            CertifiedUntil = new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2580),
                            Name = "Jeremiah",
                            Picture = (byte)0,
                            Role = "Motorman"
                        },
                        new
                        {
                            CrewMemberId = 5,
                            Age = 28,
                            BoatId = 2,
                            CertifiedUntil = new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2586),
                            Name = "Gordon",
                            Picture = (byte)0,
                            Role = "Deck Cadet"
                        },
                        new
                        {
                            CrewMemberId = 6,
                            Age = 29,
                            BoatId = 9,
                            CertifiedUntil = new DateTime(2020, 7, 3, 2, 13, 33, 565, DateTimeKind.Local).AddTicks(2591),
                            Name = "Kate",
                            Picture = (byte)0,
                            Role = "Chief Engineer"
                        });
                });

            modelBuilder.Entity("fishingApi.Models.CrewMember", b =>
                {
                    b.HasOne("fishingApi.Models.Boat", "Boat")
                        .WithMany("CrewMembers")
                        .HasForeignKey("BoatId");
                });
#pragma warning restore 612, 618
        }
    }
}
