using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class PurchaseReturnDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseReturnDetailId { get; set; }
        public bool IsPercentage { get; set; }
        public decimal Quantity { get; set; }
        [NotMapped]
        public int ItemId { get; set; }
        public string Item { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalAmount { get; set; }
        [NotMapped]
        public int PurchaseReturnId { get; set; }
        public string PurchaseReturn { get; set; }

    }
}
