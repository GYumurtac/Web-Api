﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiBitirme.Models.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

        // relational properties
        

        public virtual List<ProductCategory> Products { get; set; }
    }
}