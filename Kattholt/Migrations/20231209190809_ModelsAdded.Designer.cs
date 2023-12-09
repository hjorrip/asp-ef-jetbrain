﻿// <auto-generated />
using System;
using Kattholt.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kattholt.Migrations
{
    [DbContext(typeof(KattholtContext))]
    [Migration("20231209190809_ModelsAdded")]
    partial class ModelsAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Kattholt.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HouseNumer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int>("ZipCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Kattholt.Models.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TrackingNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("Kattholt.Models.CatTransactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AdoptedTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("CatId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NewOwnerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OldOwnerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TurnedInTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.HasIndex("NewOwnerId");

                    b.HasIndex("OldOwnerId");

                    b.ToTable("CatTransactions");
                });

            modelBuilder.Entity("Kattholt.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CatId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Kattholt.Models.CatTransactions", b =>
                {
                    b.HasOne("Kattholt.Models.Cat", "Cat")
                        .WithMany()
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kattholt.Models.Owner", "NewOwner")
                        .WithMany()
                        .HasForeignKey("NewOwnerId");

                    b.HasOne("Kattholt.Models.Owner", "OldOwner")
                        .WithMany()
                        .HasForeignKey("OldOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cat");

                    b.Navigation("NewOwner");

                    b.Navigation("OldOwner");
                });

            modelBuilder.Entity("Kattholt.Models.Owner", b =>
                {
                    b.HasOne("Kattholt.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kattholt.Models.Cat", "Cat")
                        .WithMany()
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Cat");
                });
#pragma warning restore 612, 618
        }
    }
}