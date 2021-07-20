using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
