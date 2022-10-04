using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class SalesReturn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesReturnId { get; set; }
        public string InvoiceNo { get; set; }
        public decimal SubTotal { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime SalesReturnDate { get; set; }
        [NotMapped]
        public int SaleId { get; set; }
        public string Sale { get; set; }
        public List<SalesReturnDetails> SalesReturnDetailss { get; set; }

    }
}
