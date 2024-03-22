﻿// <auto-generated />
using System;
using IOTWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IOTWebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.27");

            modelBuilder.Entity("IOTWebAPI.Entities.Configuration", b =>
                {
                    b.Property<int>("ConfigurationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GatewayID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConfigurationID");

                    b.HasIndex("GatewayID")
                        .IsUnique();

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("IOTWebAPI.Entities.Gateway", b =>
                {
                    b.Property<int>("GatewayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastCommunication")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("GatewayID");

                    b.ToTable("Gateways");
                });

            modelBuilder.Entity("IOTWebAPI.Entities.Configuration", b =>
                {
                    b.HasOne("IOTWebAPI.Entities.Gateway", "Gateway")
                        .WithOne("Configuration")
                        .HasForeignKey("IOTWebAPI.Entities.Configuration", "GatewayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gateway");
                });

            modelBuilder.Entity("IOTWebAPI.Entities.Gateway", b =>
                {
                    b.Navigation("Configuration")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
