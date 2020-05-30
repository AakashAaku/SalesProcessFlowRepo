﻿// <auto-generated />
using System;
using DSP.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DSP.Data.Migrations
{
    [DbContext(typeof(DSPMainDbContext))]
    [Migration("20200530065726_AgainTrackChangesOfTable")]
    partial class AgainTrackChangesOfTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DSP.Domain.Models.AppUsers", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active");

                    b.Property<string>("Approver");

                    b.Property<string>("BranchCode")
                        .IsRequired();

                    b.Property<string>("ContactNo");

                    b.Property<string>("CustomerCode")
                        .IsRequired();

                    b.Property<string>("EmailAddress");

                    b.Property<int?>("LicenseAssignLicensesId");

                    b.Property<string>("LicenseAvailablity");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("SAPBranch")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("VendorCode")
                        .IsRequired();

                    b.Property<int>("VendorCustomerId");

                    b.Property<string>("Warehouse")
                        .IsRequired();

                    b.Property<string>("WarehouseCode")
                        .IsRequired();

                    b.HasKey("AppUserId");

                    b.HasIndex("LicenseAssignLicensesId");

                    b.HasIndex("VendorCustomerId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("DSP.Domain.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<long>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DSP.Domain.Models.ITN_OPRO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("ContactPerson")
                        .HasMaxLength(20);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(150);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeletedFlag")
                        .HasMaxLength(2);

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("DiscountPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DocumentNo")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<string>("DocumentOwner")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PORefNo")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("PostingDate");

                    b.Property<string>("ReferenceNo")
                        .HasMaxLength(150);

                    b.Property<string>("Remarks")
                        .HasMaxLength(30);

                    b.Property<string>("SORefNo")
                        .HasMaxLength(10);

                    b.Property<string>("Status")
                        .HasMaxLength(20);

                    b.Property<decimal?>("TaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalBeforeDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(150);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("VendorCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("ITN_OPRO");
                });

            modelBuilder.Entity("DSP.Domain.Models.ITN_PRO1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BATCH_NO");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DeletedFlag")
                        .HasMaxLength(2);

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ITN_PROID");

                    b.Property<string>("ItemCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("ItemDescription")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ReceivedQty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SERIAL_NO");

                    b.Property<decimal?>("TaxAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TaxCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(150);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("Warehouse")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("ITN_PROID");

                    b.ToTable("ITN_PRO1");
                });

            modelBuilder.Entity("DSP.Domain.Models.Licenses", b =>
                {
                    b.Property<int>("LicensesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("License");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("LicensesId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("DSP.Domain.Models.VendorsCustomer", b =>
                {
                    b.Property<int>("VendorCustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillToAddress");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("ContactNumber");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("ContractNo")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("EmailId");

                    b.Property<string>("Group")
                        .IsRequired();

                    b.Property<string>("GroupCode")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PANVAT");

                    b.Property<string>("Reference");

                    b.Property<string>("Remarks");

                    b.Property<string>("ShipToAddress");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("VendorCustomerId");

                    b.ToTable("VendorCustomer");
                });

            modelBuilder.Entity("DSP.Domain.Models.AppUsers", b =>
                {
                    b.HasOne("DSP.Domain.Models.Licenses", "LicenseAssign")
                        .WithMany()
                        .HasForeignKey("LicenseAssignLicensesId");

                    b.HasOne("DSP.Domain.Models.VendorsCustomer", "VendorCustomer")
                        .WithMany()
                        .HasForeignKey("VendorCustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DSP.Domain.Models.ITN_PRO1", b =>
                {
                    b.HasOne("DSP.Domain.Models.ITN_OPRO", "ITN_OPRO")
                        .WithMany("ITN_PRO1")
                        .HasForeignKey("ITN_PROID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}