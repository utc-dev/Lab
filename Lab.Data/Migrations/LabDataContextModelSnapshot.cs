﻿// <auto-generated />
using System;
using Lab.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab.Data.Migrations
{
    [DbContext(typeof(LabDataContext))]
    partial class LabDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Bics.Data.Entity.AuditLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("Group")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Key")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserAgent")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UserFullName")
                        .HasMaxLength(255)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserId")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserIp")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Auditlogs", "System");
                });

            modelBuilder.Entity("Bics.Data.Entity.AuditLogDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("AuditLogId")
                        .HasColumnType("bigint");

                    b.Property<string>("ColumnName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NewValue")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValue")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.ToTable("AuditLogDetails", "System");
                });

            modelBuilder.Entity("Lab.Data.Entity.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MaSP")
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHD")
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("Lab.Data.Entity.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Loai")
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Lab.Data.Entity.BookAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("LoaiTacGia")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .HasMaxLength(10)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ten")
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("Lab.Data.Entity.BookCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("LastModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Ma")
                        .IsUnique()
                        .HasFilter("[DeletedAt] IS NULL");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("Lab.Data.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MaDH")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenDH")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Lab.Data.Entity.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MaDH")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("MaSP")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Bics.Data.Entity.AuditLogDetail", b =>
                {
                    b.HasOne("Bics.Data.Entity.AuditLog", "AuditLog")
                        .WithMany("Details")
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuditLog");
                });

            modelBuilder.Entity("Bics.Data.Entity.AuditLog", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
