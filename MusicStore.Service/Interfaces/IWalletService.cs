﻿using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Service.Interfaces
{
    public interface IWalletService : IDomainService<Wallet, WalletDto>
    {
    }
}
