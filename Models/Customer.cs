using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public int CityId { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
        public string TaxNumber { get; set; }
        public List<Sale> Sales { get; set; }
        public List<SalesReturn> SalesReturns { get; set; }

    }
}
