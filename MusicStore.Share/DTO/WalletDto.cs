using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.DTO
{
    public class WalletDto : BaseDto
    {
        public int Total { get; set; }
        public Guid ApplicationUser_Id { get; set; }
    }
}
