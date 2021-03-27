using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralStroeMVC.Models
{
    public class Product
    {[Key]
        public int ProductID    { get; set; }//Key Field
        [Required]
        [Display(Name="Product Name")]
        public string Name  { get; set; }
        public int InventoryCount { get; set; }
        [Required]
        public decimal  Price { get; set; }
        [Required]
        public bool IsFood  { get; set; }
    }
    public class GeneralStoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}