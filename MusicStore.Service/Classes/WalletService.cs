using MusicStore.Domain.Models;
using MusicStore.Infrastructure.Repositories;
using MusicStore.Service.Interfaces;
using MusicStore.Share.Adapter;
using MusicStore.Share.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Service.Classes
{
    public class WalletService : DomainService<Wallet, WalletDto>, IWalletService
    {
        public WalletService(IQueryRepository<Wallet> queryRepository, ICommandRepository<Wallet> commandRepository, IBaseAdapter<Wallet, WalletDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
