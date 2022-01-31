﻿// <auto-generated />
using System;
using Epiroc.Data.Entity.DBSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Epiroc.Data.Entity.Migrations
{
    [DbContext(typeof(ProjecInfoContext))]
    partial class ProjecInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("Epiroc.Data.Entity.ProjectInfo", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");
                     

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProjectEnddt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectStaus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProjectstartDt")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId");

                    b.ToTable("ProjectInfos");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Department = "Construction",
                            ProjectEnddt = new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "abc",
                            ProjectStaus = "Inprogress",
                            ProjectstartDt = new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 2,
                            Department = "Construction",
                            ProjectEnddt = new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "abc",
                            ProjectStaus = "Complete",
                            ProjectstartDt = new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 4,
                            Department = "Mining",
                            ProjectEnddt = new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "abc",
                            ProjectStaus = "Inprogress",
                            ProjectstartDt = new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 5,
                            Department = "Mining",
                            ProjectEnddt = new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "abc",
                            ProjectStaus = "Complete",
                            ProjectstartDt = new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectId = 3,
                            Department = "water-Energy",
                            ProjectEnddt = new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "abc",
                            ProjectStaus = "Inprogress",
                            ProjectstartDt = new DateTime(2022, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
