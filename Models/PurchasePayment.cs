using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class PurchasePayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchasePaymentId { get; set; }
        public string BillNo { get; set; }
        public string BillReference { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal BillAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string PaymentNote { get; set; }
        
        public decimal AdjustedAmount { get; set; }
        public decimal PaidAmount { get; set; }
        [NotMapped]
        public int PurchaseOrderId { get; set; }
        public string PurchaseOrder { get; set; }
        public List<PurchaseReturn> PurchaseReturn { get; set; }

    }
}
