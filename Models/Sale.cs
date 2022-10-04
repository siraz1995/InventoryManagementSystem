using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }
        public string InvoiceNo { get; set; }
        [NotMapped]
        public int CompanyInfoId { get; set; }
        public string CompanyInfo { get; set; }
        public string ReferenceNo { get; set; }
        public decimal SubTotal { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public string Note { get; set; }
        [NotMapped]
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public DateTime SellingDate { get; set; }
        public string Status { get; set; }
        public List<SalesDetails> SalesDetails { get; set; }
        public List<SalesReturn> SalesReturns { get; set; }

    }
}
