using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuitarStore.Models
{
    public class OrderedItem
    {
        public int OrderedItemID { get; set; }

        [Required]
        public int OrderID { get; set; }
        public Order Order { get; set; }

        [Required]
        public int GuitarID { get; set; }
        public Guitar Guitar { get; set;}

        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Quantity must be at least 1")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }  


    }
}
