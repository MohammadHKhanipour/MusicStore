using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class ProductImageDto : BaseDto
    {
        public int Num { get; set; }
        public bool IsCover { get; set; }
        public string ImageLink { get; set; }
        public Guid Product_Id { get; set; }
    }
}
