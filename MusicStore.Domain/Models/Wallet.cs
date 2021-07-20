using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class Wallet : BaseModel
    {
        public Wallet()
        {
            Bills = new List<Bill>();
        }

        public int Total { get; set; }
        public Guid ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public List<Bill> Bills { get; set; }
    }
}
