using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class PurchaseReturn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseReturnId { get; set; }
        public string ReturnInvoiceNo { get; set; }
        [NotMapped]
        public int CompanyInfoId { get; set; }
        public string CompanyInfo { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal SubTotal { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime PurchaseReturnDate { get; set; }
        [NotMapped]
        public int PurchaseOrderId { get; set; }
        public string PurchaseOrdeer { get; set; }
        public List<PurchaseReturnDetails> PurchaseReturnDetails { get; set; }

    }
}
