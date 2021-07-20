using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class OrderDetailDto : BaseDto
    {
        public Guid Order_Id { get; set; }
        public Guid Product_Id { get; set; }
    }
}
