using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class Produc
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Oyuncak Adı")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Oyuncak Çeşidi")]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
         public virtual Product Product { get; set; }

        public bool Available { get; set; }

        public string ImageUrl { get; set; }
    }
}
