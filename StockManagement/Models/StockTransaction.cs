using System.ComponentModel.DataAnnotations;

namespace StockManagement.Models
{
    public class StockTransaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public string Remarks { get; set; }

        // Navigation property if you want to access the related Product
        public Product Product { get; set; }
    }
}
