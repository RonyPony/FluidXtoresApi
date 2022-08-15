﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using fluidXtoresApi.Models;

#nullable disable

namespace fluidXtoresApi.Migrations
{
    [DbContext(typeof(fluidContext))]
    partial class fluidContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("fluidXtoresApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("allowCustomersToSelectPageSize")
                        .HasColumnType("boolean");

                    b.Property<int>("categoryTemplateId")
                        .HasColumnType("integer");

                    b.Property<string>("createdOnUtc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<int>>("discountIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<int>("displayOrder")
                        .HasColumnType("integer");

                    b.Property<bool>("hasDiscountsApplied")
                        .HasColumnType("boolean");

                    b.Property<bool>("includeintopMenu")
                        .HasColumnType("boolean");

                    b.Property<string>("metaDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("metaKeywords")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("metaTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("pageSize")
                        .HasColumnType("integer");

                    b.Property<string>("pageSizeOptions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("parentCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("priceRanges")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("published")
                        .HasColumnType("boolean");

                    b.Property<List<int>>("roleIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("seName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("showOnHomePage")
                        .HasColumnType("boolean");

                    b.Property<List<int>>("storeIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("updatedOnUtc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("fluidXtoresApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserEmail")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserPassword")
                        .HasColumnType("text");

                    b.Property<DateTime>("UserRegisterDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
