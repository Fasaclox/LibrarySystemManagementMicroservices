﻿// <auto-generated />
using System;
using LSMBookMicroserviceApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LSMBookMicroserviceApi.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LSMBookMicroserviceApi.Model.Book", b =>
                {
                    b.Property<int>("BookISBN_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Binding_Id")
                        .HasColumnType("int");

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Edited")
                        .HasColumnType("datetime2");

                    b.Property<int>("Edition")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number_Actual_Copies")
                        .HasColumnType("int");

                    b.Property<int>("Number_Current_Copies")
                        .HasColumnType("int");

                    b.Property<int>("Shelf_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Year_Published")
                        .HasColumnType("datetime2");

                    b.HasKey("BookISBN_Id");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
