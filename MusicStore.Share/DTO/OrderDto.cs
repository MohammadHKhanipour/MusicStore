using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class OrderDto : BaseDto
    {
        public bool IsFinal { get; set; }
        public int Total { get; set; }
        public DateTime Date { get; set; }
        public Guid ApplicationUserId { get; set; }
    }
}
