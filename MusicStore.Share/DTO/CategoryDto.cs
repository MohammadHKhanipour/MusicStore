using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Product_Id { get; set; }
    }
}
