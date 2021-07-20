using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class ApplicationUser : BaseModel
    {
        public ApplicationUser()
        {
            UserNotifications = new List<UserNotification>();
            Orders = new List<Order>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }

        public List<UserNotification> UserNotifications { get; set; }
        public List<Order> Orders { get; set; }
        public Wallet Wallet { get; set; }
    }
}
