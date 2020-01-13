using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public virtual ICollection<Product> ProductId{ get; set; }
        public virtual ICollection<User> UserId { get; set; }
    }
}