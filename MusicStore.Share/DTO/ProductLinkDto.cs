using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class ProductLinkDto : BaseDto
    {
        public int Num { get; set; }
        public string Link { get; set; }
        public Guid ProductId { get; set; }
    }
}
