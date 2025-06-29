using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuitarStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public DateTime OrderDate {  get; set; } = DateTime.Now;
        
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Total { get; set; }

        public ICollection<OrderedItem> Items { get; set; } = new List<OrderedItem>();

    }
}
