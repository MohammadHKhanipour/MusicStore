using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class ProductLink : BaseModel
    {
        public int Num { get; set; }
        public string Link { get; set; }
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
