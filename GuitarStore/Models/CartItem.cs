using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GuitarStore.Models
{
    public class CartItem
    {
        public int GuitarID { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}