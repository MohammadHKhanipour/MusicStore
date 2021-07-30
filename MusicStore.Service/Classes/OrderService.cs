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
    public class OrderService : DomainService<Order, OrderDto>, IOrderService
    {
        public OrderService(IQueryRepository<Order> queryRepository, ICommandRepository<Order> commandRepository, IBaseAdapter<Order, OrderDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
