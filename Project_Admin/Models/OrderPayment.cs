using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class OrderPayment
    {
        public int OrderPaymentId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CardNo { get; set; }

        public string UserName { get; set; }
    }
}
