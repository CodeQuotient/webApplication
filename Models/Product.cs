using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Product
    {
        //[Key]
        //public int ProductID { get; set; }
        public string Desc { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        
        

    }
}