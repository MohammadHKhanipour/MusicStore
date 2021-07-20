using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class Order : BaseModel
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public bool IsFinal { get; set; }
        public int Total { get; set; }
        public DateTime Date { get; set; }
        public Guid ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
