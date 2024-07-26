using System.ComponentModel.DataAnnotations;

namespace StockManagement.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactTitle { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(20)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string HomePage { get; set; }
    }
}
