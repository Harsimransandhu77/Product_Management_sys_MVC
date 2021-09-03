using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Product_Management_sys_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Management_sys_MVC.Data
{
    public class ProductDbContext : DbContext
    {


        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }
     public    ProductDbContext()
        {

        }
    }
}
