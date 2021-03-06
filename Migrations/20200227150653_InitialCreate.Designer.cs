﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moment3._2.Data;

namespace Moment3._2.Migrations
{
    [DbContext(typeof(CDContext))]
    [Migration("20200227150653_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Moment3._2.Models.CD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Album")
                        .HasColumnType("TEXT");

                    b.Property<string>("Artist")
                        .HasColumnType("TEXT");

                    b.Property<int>("Release")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tracks")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CD");
                });
#pragma warning restore 612, 618
        }
    }
}
