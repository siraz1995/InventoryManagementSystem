using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagementSystem.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "PurchasePayments",
                columns: table => new
                {
                    PurchasePaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdjustedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseOrder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasePayments", x => x.PurchasePaymentId);
                });

            migrationBuilder.CreateTable(
                name: "SalesPayments",
                columns: table => new
                {
                    SalesPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdjustedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sale = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesPayments", x => x.SalesPaymentId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BrandId1 = table.Column<int>(type: "int", nullable: true),
                    CategoryId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Brands_BrandId1",
                        column: x => x.BrandId1,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId1",
                        column: x => x.CategoryId1,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId1",
                        column: x => x.CountryId1,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemStocks",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStocks", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_ItemStocks_Items_ItemId1",
                        column: x => x.ItemId1,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyInfos",
                columns: table => new
                {
                    CompanyInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfos", x => x.CompanyInfoId);
                    table.ForeignKey(
                        name: "FK_CompanyInfos_Cities_CityId1",
                        column: x => x.CityId1,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Suppliers_Cities_CityId1",
                        column: x => x.CityId1,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesDetails",
                columns: table => new
                {
                    SalesDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPercentage = table.Column<bool>(type: "bit", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsExclusive = table.Column<bool>(type: "bit", nullable: false),
                    VATAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId1 = table.Column<int>(type: "int", nullable: true),
                    SaleId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDetails", x => x.SalesDetailId);
                    table.ForeignKey(
                        name: "FK_SalesDetails_Items_ItemId1",
                        column: x => x.ItemId1,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesDetails_Sales_SaleId1",
                        column: x => x.SaleId1,
                        principalTable: "Sales",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesReturns",
                columns: table => new
                {
                    SalesReturnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    SaleId1 = table.Column<int>(type: "int", nullable: true),
                    SalesPaymentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReturns", x => x.SalesReturnId);
                    table.ForeignKey(
                        name: "FK_SalesReturns_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReturns_Sales_SaleId1",
                        column: x => x.SaleId1,
                        principalTable: "Sales",
                        principalColumn: "SaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReturns_SalesPayments_SalesPaymentId",
                        column: x => x.SalesPaymentId,
                        principalTable: "SalesPayments",
                        principalColumn: "SalesPaymentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyInfoId1 = table.Column<int>(type: "int", nullable: true),
                    SupplierId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.PurchaseOrderId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_CompanyInfos_CompanyInfoId1",
                        column: x => x.CompanyInfoId1,
                        principalTable: "CompanyInfos",
                        principalColumn: "CompanyInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Suppliers_SupplierId1",
                        column: x => x.SupplierId1,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesReturnDetails",
                columns: table => new
                {
                    SalesReturnDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPercentage = table.Column<bool>(type: "bit", nullable: false),
                    VATAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesReturn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyInfoId = table.Column<int>(type: "int", nullable: true),
                    ItemId1 = table.Column<int>(type: "int", nullable: true),
                    SalesReturnId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReturnDetails", x => x.SalesReturnDetailsId);
                    table.ForeignKey(
                        name: "FK_SalesReturnDetails_CompanyInfos_CompanyInfoId",
                        column: x => x.CompanyInfoId,
                        principalTable: "CompanyInfos",
                        principalColumn: "CompanyInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReturnDetails_Items_ItemId1",
                        column: x => x.ItemId1,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReturnDetails_SalesReturns_SalesReturnId1",
                        column: x => x.SalesReturnId1,
                        principalTable: "SalesReturns",
                        principalColumn: "SalesReturnId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GoodsReceiveds",
                columns: table => new
                {
                    GoodReceivedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPercentage = table.Column<bool>(type: "bit", nullable: false),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsExclusive = table.Column<bool>(type: "bit", nullable: false),
                    ReceivedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoldQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalePriceWithoutVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceiveds", x => x.GoodReceivedId);
                    table.ForeignKey(
                        name: "FK_GoodsReceiveds_PurchaseOrders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrders",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetails",
                columns: table => new
                {
                    PurchaseOrderDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPercentage = table.Column<bool>(type: "bit", nullable: false),
                    IsExclusive = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId1 = table.Column<int>(type: "int", nullable: true),
                    PurchaseOrderId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderDetails", x => x.PurchaseOrderDetailsId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_Items_ItemId1",
                        column: x => x.ItemId1,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_PurchaseOrders_PurchaseOrderId1",
                        column: x => x.PurchaseOrderId1,
                        principalTable: "PurchaseOrders",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReturns",
                columns: table => new
                {
                    PurchaseReturnId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReturnInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchaseOrdeer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyInfoId1 = table.Column<int>(type: "int", nullable: true),
                    PurchaseOrderId1 = table.Column<int>(type: "int", nullable: true),
                    PurchasePaymentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReturns", x => x.PurchaseReturnId);
                    table.ForeignKey(
                        name: "FK_PurchaseReturns_CompanyInfos_CompanyInfoId1",
                        column: x => x.CompanyInfoId1,
                        principalTable: "CompanyInfos",
                        principalColumn: "CompanyInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReturns_PurchaseOrders_PurchaseOrderId1",
                        column: x => x.PurchaseOrderId1,
                        principalTable: "PurchaseOrders",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReturns_PurchasePayments_PurchasePaymentId",
                        column: x => x.PurchasePaymentId,
                        principalTable: "PurchasePayments",
                        principalColumn: "PurchasePaymentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReturnDetails",
                columns: table => new
                {
                    PurchaseReturnDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPercentage = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseReturn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId1 = table.Column<int>(type: "int", nullable: true),
                    PurchaseReturnId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReturnDetails", x => x.PurchaseReturnDetailId);
                    table.ForeignKey(
                        name: "FK_PurchaseReturnDetails_Items_ItemId1",
                        column: x => x.ItemId1,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReturnDetails_PurchaseReturns_PurchaseReturnId1",
                        column: x => x.PurchaseReturnId1,
                        principalTable: "PurchaseReturns",
                        principalColumn: "PurchaseReturnId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId1",
                table: "Cities",
                column: "CountryId1");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyInfos_CityId1",
                table: "CompanyInfos",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceiveds_PurchaseOrderId",
                table: "GoodsReceiveds",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_BrandId1",
                table: "Items",
                column: "BrandId1");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId1",
                table: "Items",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStocks_ItemId1",
                table: "ItemStocks",
                column: "ItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_ItemId1",
                table: "PurchaseOrderDetails",
                column: "ItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrderId1",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_CompanyInfoId1",
                table: "PurchaseOrders",
                column: "CompanyInfoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_SupplierId1",
                table: "PurchaseOrders",
                column: "SupplierId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturnDetails_ItemId1",
                table: "PurchaseReturnDetails",
                column: "ItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturnDetails_PurchaseReturnId1",
                table: "PurchaseReturnDetails",
                column: "PurchaseReturnId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturns_CompanyInfoId1",
                table: "PurchaseReturns",
                column: "CompanyInfoId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturns_PurchaseOrderId1",
                table: "PurchaseReturns",
                column: "PurchaseOrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturns_PurchasePaymentId",
                table: "PurchaseReturns",
                column: "PurchasePaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId1",
                table: "Sales",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_ItemId1",
                table: "SalesDetails",
                column: "ItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_SaleId1",
                table: "SalesDetails",
                column: "SaleId1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnDetails_CompanyInfoId",
                table: "SalesReturnDetails",
                column: "CompanyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnDetails_ItemId1",
                table: "SalesReturnDetails",
                column: "ItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnDetails_SalesReturnId1",
                table: "SalesReturnDetails",
                column: "SalesReturnId1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturns_CustomerId",
                table: "SalesReturns",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturns_SaleId1",
                table: "SalesReturns",
                column: "SaleId1");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturns_SalesPaymentId",
                table: "SalesReturns",
                column: "SalesPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CityId1",
                table: "Suppliers",
                column: "CityId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsReceiveds");

            migrationBuilder.DropTable(
                name: "ItemStocks");

            migrationBuilder.DropTable(
                name: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "PurchaseReturnDetails");

            migrationBuilder.DropTable(
                name: "SalesDetails");

            migrationBuilder.DropTable(
                name: "SalesReturnDetails");

            migrationBuilder.DropTable(
                name: "PurchaseReturns");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "SalesReturns");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "PurchasePayments");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "SalesPayments");

            migrationBuilder.DropTable(
                name: "CompanyInfos");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
