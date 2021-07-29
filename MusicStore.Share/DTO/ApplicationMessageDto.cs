using MusicStore.Framework;
using MusicStore.Framework.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class ApplicationMessageDto : BaseDto
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public MessageType MessageType { get; set; }
        public int MessageCode { get; set; }
    }
}
