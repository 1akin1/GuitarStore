using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuitarStore.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        [StringLength(100)] // Optional: Add a max length
        public string Type { get; set; }

        public ICollection<Guitar> Guitars { get; set; } = new List<Guitar>(); // Prevent null reference
    }
}
