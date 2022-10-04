using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class PurchaseOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseOrderId { get; set; }
        public string InvoiceNo { get; set; }
        [NotMapped]
        public int CompanyInfoId { get; set; }
        public string CompanyInfo { get; set; }
        public string ReferenceNo { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal GrandTotal { get; set; }
        public string Note { get; set; }
        [NotMapped]
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Status { get; set; }
        public List<PurchaseOrderDetails> PurchaseOrderDetailss { get; set; }
        public List<PurchaseReturn> PurchaseReturn { get; set; }
        public List<GoodsReceived> GoodsReceived { get; set; }

    }
}
