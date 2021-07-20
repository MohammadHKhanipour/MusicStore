using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class Product : BaseModel
    {
        public Product()
        {
            ProductLinks = new List<ProductLink>();
            ProductImages = new List<ProductImage>();
        }

        public string Name { get; set; }
        public int Price { get; set; }

        public List<ProductLink> ProductLinks { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public Category Category { get; set; }

    }
}
