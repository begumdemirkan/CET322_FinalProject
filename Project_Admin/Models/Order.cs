using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


// [Column(TypeName = "decimal(18,2)")] 'ı migration yaparken aldığım Microsoft.EntityFrameworkCore.Model.Validation[30000] hatası
//üzerine https://mattferderer.com/entity-framework-no-type-was-specified-for-the-decimal-column sitesinden bakarak ekledim.
namespace Project_Admin.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int StatuName { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int UserId { get; set; }

        public Userr Userr { get; set; }

        public int UserAddressId { get; set; }

        public int StatusId { get; set; }

        public Statu Status { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalProductPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalDiscount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public virtual List<OrderPayment> Order_Payments { get; set; }

        public virtual List<OrderProduct> OrderProducts { get; set; }
    }
}
