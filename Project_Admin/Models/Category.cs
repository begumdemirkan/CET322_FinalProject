using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class Category
    {
        [Key]
        public int ProductId { get; set; }

        
        [Display(Name = "Oyuncak Adı")]
        public string Name { get; set; }
        public virtual IList<Product> Products { get; set; }


    }
}
