﻿// <auto-generated />
using System;
using LSMBindingMicroserviceApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LSMBindingMicroserviceApi.Migrations
{
    [DbContext(typeof(BindingContext))]
    [Migration("20220903190923_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LSMBindingMicroserviceApi.Model.Binding", b =>
                {
                    b.Property<int>("Binding_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Binding_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Date_Edited")
                        .HasColumnType("datetime2");

                    b.HasKey("Binding_Id");

                    b.ToTable("Bindngs");
                });
#pragma warning restore 612, 618
        }
    }
}
