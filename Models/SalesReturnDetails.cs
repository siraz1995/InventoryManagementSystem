using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class SalesReturnDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesReturnDetailsId { get; set; }
        public bool IsPercentage { get; set; }
        public decimal VATAmount { get; set; }
        public decimal Quantity { get; set; }
        public decimal OtherCharges { get; set; }
        [NotMapped]
        public int ItemId { get; set; }
        public string Item { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalAmount { get; set; }
        [NotMapped]
        public int SalesReturnId { get; set; }
        public string SalesReturn { get; set; }

    }
}
