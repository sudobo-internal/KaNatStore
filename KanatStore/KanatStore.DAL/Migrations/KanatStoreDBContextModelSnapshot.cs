﻿// <auto-generated />
using System;
using KanatStore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KanatStore.DAL.Migrations
{
    [DbContext(typeof(KanatStoreDBContext))]
    partial class KanatStoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KanatStore.DAL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("KanatStore.DAL.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Địa chỉ")
                        .HasColumnOrder(4);

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal")
                        .HasColumnName("Thưởng")
                        .HasColumnOrder(9);

                    b.Property<decimal>("Coefficient")
                        .HasColumnType("decimal")
                        .HasColumnName("Hệ số lương")
                        .HasColumnOrder(10);

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("Số điện thoại")
                        .HasColumnOrder(5);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("DateTime")
                        .HasColumnName("Ngày sinh")
                        .HasColumnOrder(2);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Họ và tên")
                        .HasColumnOrder(1);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Giới tính")
                        .HasColumnOrder(3);

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CCCD")
                        .HasColumnOrder(7);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Ảnh")
                        .HasColumnOrder(12);

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal")
                        .HasColumnName("Tổng lương")
                        .HasColumnOrder(11);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Loại đối tượng")
                        .HasColumnOrder(6);

                    b.Property<double>("WorkDays")
                        .HasColumnType("float")
                        .HasColumnName("Số ngày làm")
                        .HasColumnOrder(8);

                    b.HasKey("Id");

                    b.ToTable("Nhân viên", (string)null);
                });

            modelBuilder.Entity("KanatStore.DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Description");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Image");

                    b.Property<double>("ImportPrice")
                        .HasColumnType("float")
                        .HasColumnName("ImportPrice");

                    b.Property<float>("Length")
                        .HasColumnType("real")
                        .HasColumnName("Length");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Origin");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("Price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Status");

                    b.Property<float>("Thickness")
                        .HasColumnType("real")
                        .HasColumnName("Thickness");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Unit");

                    b.Property<float>("Width")
                        .HasColumnType("real")
                        .HasColumnName("Width");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("KanatStore.DAL.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Address");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("StoreInformation", (string)null);
                });

            modelBuilder.Entity("KanatStore.DAL.Entities.Product", b =>
                {
                    b.HasOne("KanatStore.DAL.Entities.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KanatStore.DAL.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
