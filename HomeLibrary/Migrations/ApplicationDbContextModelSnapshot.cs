﻿// <auto-generated />
using HomeLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HomeLibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeLibrary.Models.Element", b =>
                {
                    b.Property<int>("IDElement")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Carries");

                    b.Property<string>("Cover");

                    b.Property<string>("Description");

                    b.Property<string>("NameOfAuthors");

                    b.Property<string>("Status");

                    b.Property<string>("Title");

                    b.Property<string>("Year");

                    b.HasKey("IDElement");

                    b.ToTable("Elements");
                });
#pragma warning restore 612, 618
        }
    }
}