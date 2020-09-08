﻿// <auto-generated />
using System;
using CRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD.Migrations
{
    [DbContext(typeof(CRUDContext))]
    partial class CRUDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("CRUD.Models.HospitalDetails", b =>
                {
                    b.Property<int>("HospitalDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HospitalId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HospitalsHospitalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Unavailable")
                        .HasColumnType("INTEGER");

                    b.HasKey("HospitalDetailsId");

                    b.HasIndex("HospitalsHospitalId");

                    b.ToTable("HospitalDetails");
                });

            modelBuilder.Entity("CRUD.Models.Hospitals", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DecisionMaker")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("HospitalName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(8);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Services")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HospitalId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("CRUD.Models.HospitalDetails", b =>
                {
                    b.HasOne("CRUD.Models.Hospitals", "Hospitals")
                        .WithMany()
                        .HasForeignKey("HospitalsHospitalId");
                });
#pragma warning restore 612, 618
        }
    }
}
