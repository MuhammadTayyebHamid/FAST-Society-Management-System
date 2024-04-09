﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SE_Project.Models;

#nullable disable

namespace SE_Project.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240409092304_Society")]
    partial class Society
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SE_Project.Models.Society", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Head")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Member5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MentorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plans")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Societies");
                });
#pragma warning restore 612, 618
        }
    }
}
