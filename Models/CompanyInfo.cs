using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class CompanyInfo
    {
        [Key]
        public int CompanyInfoId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public int CityId { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string VatNumber { get; set; }
        public string Tin { get; set; }
        public string CompanyLogo { get; set; }
        public List<PurchaseOrder> PurchaseOrders { get; set; }
        public List<PurchaseReturn> PurchaseReturn { get; set; }
        public List<SalesReturnDetails> SalesReturnDetailss { get; set; }

    }
}
