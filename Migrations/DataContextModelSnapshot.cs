﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using requirementsSys.Models;

#nullable disable

namespace requirementsSys.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("Requirement", b =>
                {
                    b.Property<int>("RequirementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RequirementID");

                    b.HasIndex("TypeID");

                    b.ToTable("Requirements");
                });

            modelBuilder.Entity("requirementsSys.Models.Type", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TypeID");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Requirement", b =>
                {
                    b.HasOne("requirementsSys.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
