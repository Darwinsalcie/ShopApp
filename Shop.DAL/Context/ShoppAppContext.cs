
using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Entities;


namespace ShopApp.DAL.Context
{

    //this class is the db's methods handler, we can separate this
    //class in differents modules with the propouse the file doesn't become too large.


    /*This file have a combination of two design patterns 
     * We have differents methods for data access with entity framework, but we don't need use
     * all methods in a module, hence we will to create abstraccions with interfaces  to define only
     * the methods that we want.
     */

    public class ShopAppContext : DbContext
    {

        #region "Constructor"
        public ShopAppContext(DbContextOptions<ShopAppContext> options) : base(options)
        {

        }

        #endregion 

        #region "Db Sets"

        public DbSet<Categories> Categories { get; set; }
        //public DbSet<Customers> Customers { get; set; }
        //public DbSet<Employees> Employees { get; set; }
        //public DbSet<OrderDetails> OrderDetails { get; set; }
        //public DbSet<Orders> Orders { get; set; }
        //public DbSet<Products> Products { get; set; }
        //public DbSet<Shippers> Shippers { get; set; }
        //public DbSet<Suppliers> Suppliers { get; set; }


        #endregion

    }
}
