using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class Product
    {
        
        public int ProductId { get; set; }

        //public DateTime CreateDate { get; set; }

        //public int CreateUserId { get; set; }

        //public DateTime? UpdateDate { get; set; }

        //public int? UpdateUserId { get; set; }
        [Required]
        [Display(Name = "Oyuncak Adı")]
        public string Name { get; set; }

        //public int CategoryId { get; set; }
        //[Display(Name = "Oyun Kategorisi")]
        //public Category Category { get; set; }

        //public string Brand { get; set; }

        //public string Model { get; set; }

        //public string Description { get; set; }
       
        //public double Price { get; set; }
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal Discount { get; set; }

        //public int Stock { get; set; }

        //public bool Available { get; set; }

        //public string ImageUrl { get; set; }
    }
}
