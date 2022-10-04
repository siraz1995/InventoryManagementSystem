using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class ItemStock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockId { get; set; }
        [NotMapped]
        public int ItemId { get; set; }
        public string Item { get; set; }
        public decimal Quantity { get; set; }

    }
}
