using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management_sys_MVC.Models
{
    public class Brand
    {

        public int Id { get; set; }
        [Required]
        public string Brand_Name { get; set; }
    }
}
