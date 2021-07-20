using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class ProductImage : BaseModel
    {
        public int Num { get; set; }
        public bool IsCover { get; set; }
        public string ImageLink { get; set; }
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
