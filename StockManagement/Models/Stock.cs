namespace StockManagement.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateReceived { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
