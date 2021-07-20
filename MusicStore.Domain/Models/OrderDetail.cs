using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class OrderDetail : BaseModel
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
