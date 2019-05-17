using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class Userr : IdentityUser
    {
        public int UserId { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int? UpdateUserId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Surname { get; set; }


      

        
        [StringLength(50, MinimumLength = 1)]
        public string Tel { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<UserAddress> UserAddress { get; set; }
    }
}
