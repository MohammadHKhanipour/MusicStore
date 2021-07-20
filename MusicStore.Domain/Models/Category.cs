using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
