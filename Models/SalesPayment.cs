using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class SalesPayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesPaymentId { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal DueAmount { get; set; }
        public decimal AdjustedAmount { get; set; }
        public decimal ReceivedAmount { get; set; }
        public string PaymentNote { get; set; }
        [NotMapped]
        public int SaleId { get; set; }
        public string Sale { get; set; }
        public List<SalesReturn> SalesReturns { get; set; }

    }
}
