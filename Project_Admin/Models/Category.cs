using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class Category
    {
            public int CategoryId { get; set; }

            public DateTime CreateDate { get; set; }

            public int CreateUserId { get; set; }

            public DateTime? UpdateDate { get; set; }

            public int? UpdateUserId { get; set; }

            public int ParentId { get; set; } = 0;

            public bool IsActive { get; set; }
        }
    
}
