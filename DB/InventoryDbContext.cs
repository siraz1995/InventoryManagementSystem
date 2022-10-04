using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DB
{
    public class InventoryDbContext:DbContext
    {
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<GoodsReceived> GoodsReceiveds { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemStock> ItemStocks { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
        public DbSet<PurchasePayment> PurchasePayments { get; set; }
        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }
        public DbSet<PurchaseReturnDetails> PurchaseReturnDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesDetails> SalesDetails { get; set; }
        public DbSet<SalesPayment> SalesPayments { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<SalesReturnDetails> SalesReturnDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
