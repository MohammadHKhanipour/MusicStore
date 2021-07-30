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
    public class BillService : DomainService<Bill, BillDto>, IBillService
    {
        public BillService(IQueryRepository<Bill> queryRepository, ICommandRepository<Bill> commandRepository, IBaseAdapter<Bill, BillDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
