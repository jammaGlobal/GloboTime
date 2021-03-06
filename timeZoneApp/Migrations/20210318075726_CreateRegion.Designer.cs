﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using timeZoneApp.Data;

namespace timeZoneApp.Migrations
{
    [DbContext(typeof(TimeZoneAppContext))]
    [Migration("20210318075726_CreateRegion")]
    partial class CreateRegion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("timeZoneApp.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("mostRecentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("offset")
                        .HasColumnType("time");

                    b.Property<string>("offsetType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.ToTable("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
