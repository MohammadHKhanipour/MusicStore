using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class UserNotificationDto : BaseDto
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string MessageCode { get; set; }
        public bool IsSeen { get; set; }
        public Guid ApplicationUser_Id { get; set; }
    }
}
