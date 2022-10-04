using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class PurchaseOrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderDetailsId { get; set; }
        public bool IsPercentage { get; set; }
        public bool IsExclusive { get; set; }
        public decimal Quantity { get; set; }
        [NotMapped]
        public int ItemId { get; set; }
        public string Item { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalAmount { get; set; }
        [NotMapped]
        public int PurchaseOrderId { get; set; }
        public string PurchaseOrder { get; set; }

    }
}
