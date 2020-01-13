using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Data.Entity.
using System.Data.Entity;
using WebApplication6.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace WebApplication6.DAL
{
    public class UserContext : DbContext
    {
        public UserContext(): base("UserContext")
        {

        }
        public class ECommerceDBContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Cart> Carts { get; set; }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<WebApplication6.Models.User> Users { get; set; }
    }
}