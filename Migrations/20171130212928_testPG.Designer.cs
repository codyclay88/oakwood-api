﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OakwoodApp.Entities;
using System;

namespace OakwoodApp.Migrations
{
    [DbContext(typeof(OakwoodDbContext))]
    [Migration("20171130212928_testPG")]
    partial class testPG
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("OakwoodApp.Entities.Ministry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Ministries");
                });

            modelBuilder.Entity("OakwoodApp.Entities.OakwoodEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDateTime");

                    b.Property<int>("MinistryId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDateTime");

                    b.HasKey("Id");

                    b.HasIndex("MinistryId");

                    b.ToTable("OakwoodEvents");
                });

            modelBuilder.Entity("OakwoodApp.Entities.OakwoodEvent", b =>
                {
                    b.HasOne("OakwoodApp.Entities.Ministry", "Ministry")
                        .WithMany("OakwoodEvents")
                        .HasForeignKey("MinistryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
