using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class UserAddress
    {
        [Key]
        public int AddressId { get; set; }

        public Userr Userr { get; set; }

        public string Title { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 15)]
        public string Address { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        public bool IsActive { get; set; }
    }
}
