﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Database;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20250109095150_Init2")]
    partial class Init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("WebAPI.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");
                });
#pragma warning restore 612, 618
        }
    }
}
