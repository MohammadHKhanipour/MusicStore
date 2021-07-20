using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class UserNotification : BaseModel
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string MessageCode { get; set; }
        public bool IsSeen { get; set; }
        public Guid ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

    }
}
