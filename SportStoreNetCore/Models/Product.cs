﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SportStoreNetCore.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
