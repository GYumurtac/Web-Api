using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiBitirme.Models.VMClasses
{
    public class ProductVM
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
        public string CategoryName { get; set; }
       

    }
}