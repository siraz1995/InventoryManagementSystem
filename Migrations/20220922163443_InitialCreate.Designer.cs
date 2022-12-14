// <auto-generated />
using System;
using InventoryManagementSystem.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryManagementSystem.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20220922163443_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryManagementSystem.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CountryId1")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId1");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.CompanyInfo", b =>
                {
                    b.Property<int>("CompanyInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId1")
                        .HasColumnType("int");

                    b.Property<string>("CompanyLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyInfoId");

                    b.HasIndex("CityId1");

                    b.ToTable("CompanyInfos");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.GoodsReceived", b =>
                {
                    b.Property<int>("GoodReceivedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiscountRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsExclusive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPercentage")
                        .HasColumnType("bit");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ReceivedQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalePriceWithoutVAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SoldQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("GoodReceivedId");

                    b.HasIndex("PurchaseOrderId");

                    b.ToTable("GoodsReceiveds");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BrandId1")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("VAT")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.HasIndex("BrandId1");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.ItemStock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("StockId");

                    b.HasIndex("ItemId1");

                    b.ToTable("ItemStocks");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseOrder", b =>
                {
                    b.Property<int>("PurchaseOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyInfoId1")
                        .HasColumnType("int");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OtherCharges")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReferenceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplierId1")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseOrderId");

                    b.HasIndex("CompanyInfoId1");

                    b.HasIndex("SupplierId1");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseOrderDetails", b =>
                {
                    b.Property<int>("PurchaseOrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsExclusive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPercentage")
                        .HasColumnType("bit");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.Property<string>("PurchaseOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PurchaseOrderId1")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseOrderDetailsId");

                    b.HasIndex("ItemId1");

                    b.HasIndex("PurchaseOrderId1");

                    b.ToTable("PurchaseOrderDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchasePayment", b =>
                {
                    b.Property<int>("PurchasePaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AdjustedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BillAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BillNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DueAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PaidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseOrder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurchasePaymentId");

                    b.ToTable("PurchasePayments");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseReturn", b =>
                {
                    b.Property<int>("PurchaseReturnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyInfoId1")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtherCharges")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PurchaseOrdeer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PurchaseOrderId1")
                        .HasColumnType("int");

                    b.Property<int?>("PurchasePaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReturnInvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseReturnId");

                    b.HasIndex("CompanyInfoId1");

                    b.HasIndex("PurchaseOrderId1");

                    b.HasIndex("PurchasePaymentId");

                    b.ToTable("PurchaseReturns");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseReturnDetails", b =>
                {
                    b.Property<int>("PurchaseReturnDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPercentage")
                        .HasColumnType("bit");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PurchaseReturn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PurchaseReturnId1")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseReturnDetailId");

                    b.HasIndex("ItemId1");

                    b.HasIndex("PurchaseReturnId1");

                    b.ToTable("PurchaseReturnDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId1")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OtherCharges")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReferenceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SellingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleId");

                    b.HasIndex("CustomerId1");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesDetails", b =>
                {
                    b.Property<int>("SalesDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsExclusive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPercentage")
                        .HasColumnType("bit");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SaleId1")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VATAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SalesDetailId");

                    b.HasIndex("ItemId1");

                    b.HasIndex("SaleId1");

                    b.ToTable("SalesDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesPayment", b =>
                {
                    b.Property<int>("SalesPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AdjustedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DueAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InvoiceAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ReceivedAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sale")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesPaymentId");

                    b.ToTable("SalesPayments");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesReturn", b =>
                {
                    b.Property<int>("SalesReturnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OtherCharges")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SaleId1")
                        .HasColumnType("int");

                    b.Property<int?>("SalesPaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SalesReturnId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SaleId1");

                    b.HasIndex("SalesPaymentId");

                    b.ToTable("SalesReturns");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesReturnDetails", b =>
                {
                    b.Property<int>("SalesReturnDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyInfoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPercentage")
                        .HasColumnType("bit");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ItemId1")
                        .HasColumnType("int");

                    b.Property<decimal>("OtherCharges")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SalesReturn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalesReturnId1")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VATAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SalesReturnDetailsId");

                    b.HasIndex("CompanyInfoId");

                    b.HasIndex("ItemId1");

                    b.HasIndex("SalesReturnId1");

                    b.ToTable("SalesReturnDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CityId1")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VatNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.HasIndex("CityId1");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.City", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Country", null)
                        .WithMany("Citys")
                        .HasForeignKey("CountryId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.CompanyInfo", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.City", null)
                        .WithMany("CompanyInfos")
                        .HasForeignKey("CityId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.GoodsReceived", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.PurchaseOrder", null)
                        .WithMany("GoodsReceived")
                        .HasForeignKey("PurchaseOrderId");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Item", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Brand", null)
                        .WithMany("Items")
                        .HasForeignKey("BrandId1");

                    b.HasOne("InventoryManagementSystem.Models.Category", null)
                        .WithMany("Items")
                        .HasForeignKey("CategoryId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.ItemStock", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Item", null)
                        .WithMany("ItemStocks")
                        .HasForeignKey("ItemId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseOrder", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.CompanyInfo", null)
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("CompanyInfoId1");

                    b.HasOne("InventoryManagementSystem.Models.Supplier", null)
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("SupplierId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseOrderDetails", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Item", null)
                        .WithMany("PurchaseOrderDetails")
                        .HasForeignKey("ItemId1");

                    b.HasOne("InventoryManagementSystem.Models.PurchaseOrder", null)
                        .WithMany("PurchaseOrderDetailss")
                        .HasForeignKey("PurchaseOrderId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseReturn", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.CompanyInfo", null)
                        .WithMany("PurchaseReturn")
                        .HasForeignKey("CompanyInfoId1");

                    b.HasOne("InventoryManagementSystem.Models.PurchaseOrder", null)
                        .WithMany("PurchaseReturn")
                        .HasForeignKey("PurchaseOrderId1");

                    b.HasOne("InventoryManagementSystem.Models.PurchasePayment", null)
                        .WithMany("PurchaseReturn")
                        .HasForeignKey("PurchasePaymentId");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseReturnDetails", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Item", null)
                        .WithMany("PurchaseReturnDetails")
                        .HasForeignKey("ItemId1");

                    b.HasOne("InventoryManagementSystem.Models.PurchaseReturn", null)
                        .WithMany("PurchaseReturnDetails")
                        .HasForeignKey("PurchaseReturnId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Sale", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Customer", null)
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesDetails", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Item", null)
                        .WithMany("SalesDetails")
                        .HasForeignKey("ItemId1");

                    b.HasOne("InventoryManagementSystem.Models.Sale", null)
                        .WithMany("SalesDetails")
                        .HasForeignKey("SaleId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesReturn", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.Customer", null)
                        .WithMany("SalesReturns")
                        .HasForeignKey("CustomerId");

                    b.HasOne("InventoryManagementSystem.Models.Sale", null)
                        .WithMany("SalesReturns")
                        .HasForeignKey("SaleId1");

                    b.HasOne("InventoryManagementSystem.Models.SalesPayment", null)
                        .WithMany("SalesReturns")
                        .HasForeignKey("SalesPaymentId");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesReturnDetails", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.CompanyInfo", null)
                        .WithMany("SalesReturnDetailss")
                        .HasForeignKey("CompanyInfoId");

                    b.HasOne("InventoryManagementSystem.Models.Item", null)
                        .WithMany("SalesReturnDetailss")
                        .HasForeignKey("ItemId1");

                    b.HasOne("InventoryManagementSystem.Models.SalesReturn", null)
                        .WithMany("SalesReturnDetailss")
                        .HasForeignKey("SalesReturnId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Supplier", b =>
                {
                    b.HasOne("InventoryManagementSystem.Models.City", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("CityId1");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Brand", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.City", b =>
                {
                    b.Navigation("CompanyInfos");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.CompanyInfo", b =>
                {
                    b.Navigation("PurchaseOrders");

                    b.Navigation("PurchaseReturn");

                    b.Navigation("SalesReturnDetailss");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Country", b =>
                {
                    b.Navigation("Citys");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Customer", b =>
                {
                    b.Navigation("Sales");

                    b.Navigation("SalesReturns");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Item", b =>
                {
                    b.Navigation("ItemStocks");

                    b.Navigation("PurchaseOrderDetails");

                    b.Navigation("PurchaseReturnDetails");

                    b.Navigation("SalesDetails");

                    b.Navigation("SalesReturnDetailss");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseOrder", b =>
                {
                    b.Navigation("GoodsReceived");

                    b.Navigation("PurchaseOrderDetailss");

                    b.Navigation("PurchaseReturn");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchasePayment", b =>
                {
                    b.Navigation("PurchaseReturn");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.PurchaseReturn", b =>
                {
                    b.Navigation("PurchaseReturnDetails");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Sale", b =>
                {
                    b.Navigation("SalesDetails");

                    b.Navigation("SalesReturns");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesPayment", b =>
                {
                    b.Navigation("SalesReturns");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.SalesReturn", b =>
                {
                    b.Navigation("SalesReturnDetailss");
                });

            modelBuilder.Entity("InventoryManagementSystem.Models.Supplier", b =>
                {
                    b.Navigation("PurchaseOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
