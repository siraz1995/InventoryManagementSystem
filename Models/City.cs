using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryName { get; set; }
        [NotMapped]
        public string Country { get; set; }
        public List<CompanyInfo> CompanyInfos { get; set; }
        public List<Supplier> Suppliers { get; set; }

    }
}
