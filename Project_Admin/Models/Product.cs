using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Oyuncak Adı")]
        public string Name { get; set; }

        public bool Available { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        [Range(0, 10000)]
        public Decimal Price { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public Category Categories { get; set; }
    }
}
