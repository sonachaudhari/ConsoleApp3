﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DataAccess.Models
{
    [Table("products", Schema = "production")]

    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public Int16 model_year { get; set; }
        public decimal list_price { get; set; }

        public int brand_id { get; set; }
        [ForeignKey("brand_id")]
        public Brands brand { get; set; }

        public int category_id { get; set; }
        [ForeignKey("category_id")]
        public Categories categories { get; set; }
    }
}
