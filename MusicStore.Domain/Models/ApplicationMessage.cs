using MusicStore.Framework;
using MusicStore.Framework.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class ApplicationMessage : BaseModel
    {
        [NotMapped]
        public string Name { get; set; }
        public string Content { get; set; }
        public MessageType MessageType { get; set; }
        public int MessageCode { get; set; }
    }
}
