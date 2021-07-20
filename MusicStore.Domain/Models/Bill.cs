using MusicStore.Framework;
using MusicStore.Framework.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicStore.Domain.Models
{
    public class Bill : BaseModel
    {
        public DateTime IssueDate { get; set; }
        public int Amount { get; set; }
        public PaymentState PaymentState { get; set; }
        public string PaymentNumber { get; set; }
        public Guid WalletId { get; set; }

        public Wallet Wallet { get; set; }
    }
}
