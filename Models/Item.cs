using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        [NotMapped]
        public int BrandId { get; set; }
        public string Brand { get; set; }
        [NotMapped]
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal VAT { get; set; }
        public List<ItemStock> ItemStocks { get; set; }
        public List<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
        public List<PurchaseReturnDetails> PurchaseReturnDetails { get; set; }
        public List<SalesDetails> SalesDetails { get; set; }
        public List<SalesReturnDetails> SalesReturnDetailss { get; set; }

    }
}
