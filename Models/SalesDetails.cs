using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class SalesDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesDetailId { get; set; }
        public bool IsPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsExclusive { get; set; }
        public decimal VATAmount { get; set; }
        public decimal Quantity { get; set; }
        [NotMapped]
        public int ItemId { get; set; }
        public string Item { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalAmount { get; set; }
        [NotMapped]
        public int SaleId { get; set; }
        public string Sale { get; set; }

    }
}
