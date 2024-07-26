using System.ComponentModel.DataAnnotations;

namespace StockManagement.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }
    }
}
