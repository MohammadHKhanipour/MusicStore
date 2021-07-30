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
    public class OrderDetailService : DomainService<OrderDetail, OrderDetailDto>, IOrderDetailService
    {
        public OrderDetailService(IQueryRepository<OrderDetail> queryRepository, ICommandRepository<OrderDetail> commandRepository, IBaseAdapter<OrderDetail, OrderDetailDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
