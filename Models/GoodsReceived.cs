using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class GoodsReceived
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodReceivedId { get; set; }
        public bool IsPercentage { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsExclusive { get; set; }
        public decimal ReceivedQuantity { get; set; }
        public decimal SoldQuantity { get; set; }
        [NotMapped]
        public int ItemId { get; set; }
        public string Item { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public decimal SalePriceWithoutVAT { get; set; }
        [NotMapped]
        public int PurchaseOrderdId { get; set; }
        public string PurchaseOrder { get; set; }

    }
}
