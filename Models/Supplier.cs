using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public int CityId { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string VatNumber { get; set; }
        public string SupplierPhoto { get; set; }
        public List<PurchaseOrder> PurchaseOrders { get; set; }

    }
}
