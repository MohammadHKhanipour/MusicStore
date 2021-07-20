using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class BillDto : BaseDto
    {
        public DateTime IssueDate { get; set; }
        public int Amount { get; set; }
        public Enum PaymentState { get; set; }
        public string PaymentNumber { get; set; }
        public Guid Wallet_Id { get; set; }
    }
}
