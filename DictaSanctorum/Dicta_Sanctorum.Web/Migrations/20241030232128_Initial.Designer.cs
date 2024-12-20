﻿// <auto-generated />
using System;
using Dicta_Sanctorum.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dicta_Sanctorum.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20241030232128_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dicta_Sanctorum.Models.PhraseModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("idSaint")
                        .HasColumnType("int");

                    b.Property<string>("phrase")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("idSaint");

                    b.ToTable("Phrases", (string)null);
                });

            modelBuilder.Entity("Dicta_Sanctorum.Models.SaintModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bio")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("birthYear")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("canonizationYear")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("deathYear")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("feastDay")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nationality")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prayer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Saints", (string)null);
                });

            modelBuilder.Entity("Dicta_Sanctorum.Models.PhraseModel", b =>
                {
                    b.HasOne("Dicta_Sanctorum.Models.SaintModel", "Saint")
                        .WithMany("Phrases")
                        .HasForeignKey("idSaint")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Saint");
                });

            modelBuilder.Entity("Dicta_Sanctorum.Models.SaintModel", b =>
                {
                    b.Navigation("Phrases");
                });
#pragma warning restore 612, 618
        }
    }
}
