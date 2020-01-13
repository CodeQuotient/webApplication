using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication6.Models;
namespace WebApplication6.DAL
{
    public class Initializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var products = new List<Product>
            {
            new Product{Desc="laptop",Price=30000,Quantity=50},
            new Product{Desc="Phone",Price=10000,Quantity=30},
            new Product{Desc="car",Price=500000,Quantity=20},
            new Product{Desc="bike",Price=50000,Quantity=60},
            new Product{Desc="Ship",Price=10000000,Quantity=5},
            new Product{Desc="Cycle",Price=11000,Quantity=40},
            new Product{Desc="Earphone",Price=500,Quantity=100},
            new Product{Desc="charger",Price=1000, Quantity=80}
            };
          //  products.ForEach(s = );
            //products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}