﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva_Pharma_Task1.Models
{
    
    public class Categories
    {
        //[Key]
        public int Id { get; set; }
        //[Required]
        //[MaxLength(50)]
        public string catName { get; set; }
        //[Required]
        public int catOrder { get; set; }
        //[NotMapped]
        public DateTime createdDate { get; set; }
        //[Column("isDeleted")]
        public bool markedAsDeleted { get; set; }
        public List<Product> products { get; set; } = new List<Product>();
    }
}
