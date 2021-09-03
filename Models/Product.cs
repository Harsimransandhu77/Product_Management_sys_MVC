using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management_sys_MVC.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Categoryid { get; set; }
        public int Brandid { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }

        public  Brand Brand { get; set; }
        public  Category Category { get; set; }
    }
}
