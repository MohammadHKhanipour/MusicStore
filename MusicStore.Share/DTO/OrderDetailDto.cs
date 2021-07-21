using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class OrderDetailDto : BaseDto
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
    }
}
