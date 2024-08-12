﻿// <auto-generated />
using System;
using BookLoanApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookLoanApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240812041705_dbCreation")]
    partial class dbCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookLoanApp.Models.AdressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DoorNumber")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StreetAdress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("BookLoanApp.Models.BooksModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cape")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastAlterationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("StockAmount")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookLoanApp.Models.LoanModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("integer");

                    b.Property<int>("BooksId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeliverDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BooksId");

                    b.HasIndex("UserId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("BookLoanApp.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("HashPass")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime>("LastAlterationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Profile")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("SaltPass")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<bool>("Situation")
                        .HasColumnType("boolean");

                    b.Property<int>("Turno")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookLoanApp.Models.AdressModel", b =>
                {
                    b.HasOne("BookLoanApp.Models.UserModel", "User")
                        .WithOne("Adress")
                        .HasForeignKey("BookLoanApp.Models.AdressModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookLoanApp.Models.LoanModel", b =>
                {
                    b.HasOne("BookLoanApp.Models.BooksModel", "Books")
                        .WithMany("Loans")
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLoanApp.Models.UserModel", "User")
                        .WithMany("LoanList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookLoanApp.Models.BooksModel", b =>
                {
                    b.Navigation("Loans");
                });

            modelBuilder.Entity("BookLoanApp.Models.UserModel", b =>
                {
                    b.Navigation("Adress")
                        .IsRequired();

                    b.Navigation("LoanList");
                });
#pragma warning restore 612, 618
        }
    }
}
