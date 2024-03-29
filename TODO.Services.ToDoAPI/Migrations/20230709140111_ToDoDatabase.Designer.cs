﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TODO.Services.ToDoAPI.Data;

#nullable disable

namespace TODO.Services.ToDoAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230709140111_ToDoDatabase")]
    partial class ToDoDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TODO.Services.ToDoAPI.Models.ToDo", b =>
                {
                    b.Property<int>("ToDoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ToDoId"));

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ToDoId");

                    b.ToTable("ToDos");

                    b.HasData(
                        new
                        {
                            ToDoId = 1,
                            Done = false,
                            DueDate = new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Task = "Get Groceries"
                        },
                        new
                        {
                            ToDoId = 2,
                            Done = false,
                            DueDate = new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Task = "Pay rent"
                        },
                        new
                        {
                            ToDoId = 3,
                            Done = false,
                            DueDate = new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Task = "Organize garage"
                        },
                        new
                        {
                            ToDoId = 4,
                            Done = false,
                            DueDate = new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Task = "Buy furniture"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
