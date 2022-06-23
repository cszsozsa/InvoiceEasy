﻿// <auto-generated />
using System;
using InvoiceEasy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvoiceEasy.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("InvoiceEasy.Models.CompanyModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id"));

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("registrationNumber")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("InvoiceEasy.Models.InvoiceItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("InvoiceModelid")
                        .HasColumnType("integer");

                    b.Property<decimal>("cost")
                        .HasColumnType("numeric");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceModelid");

                    b.ToTable("InvoiceItems");
                });

            modelBuilder.Entity("InvoiceEasy.Models.InvoiceModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id"));

                    b.Property<int>("buyerid")
                        .HasColumnType("integer");

                    b.Property<DateTime>("deliveryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool?>("isActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("issueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("paymentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("paymentMethod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("sellerid")
                        .HasColumnType("integer");

                    b.Property<int>("uniqueNumber")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("buyerid");

                    b.HasIndex("sellerid");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("InvoiceEasy.Models.PersonModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("companyid")
                        .HasColumnType("integer");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isActive")
                        .HasColumnType("boolean");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("companyid");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("InvoiceEasy.Models.InvoiceItemModel", b =>
                {
                    b.HasOne("InvoiceEasy.Models.InvoiceModel", null)
                        .WithMany("invoiceItems")
                        .HasForeignKey("InvoiceModelid");
                });

            modelBuilder.Entity("InvoiceEasy.Models.InvoiceModel", b =>
                {
                    b.HasOne("InvoiceEasy.Models.PersonModel", "buyer")
                        .WithMany()
                        .HasForeignKey("buyerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvoiceEasy.Models.PersonModel", "seller")
                        .WithMany()
                        .HasForeignKey("sellerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("buyer");

                    b.Navigation("seller");
                });

            modelBuilder.Entity("InvoiceEasy.Models.PersonModel", b =>
                {
                    b.HasOne("InvoiceEasy.Models.CompanyModel", "company")
                        .WithMany()
                        .HasForeignKey("companyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("company");
                });

            modelBuilder.Entity("InvoiceEasy.Models.InvoiceModel", b =>
                {
                    b.Navigation("invoiceItems");
                });
#pragma warning restore 612, 618
        }
    }
}