using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuitarStore.Models
{
    public class Guitar
    {
        [Key]
        public int GuitarID { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }  

        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public Category Category { get; set; }  
    }
}
