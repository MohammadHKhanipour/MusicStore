using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class OrderAdapter : IBaseAdapter<Order, OrderDto>
    {
        public OrderDto GetDto(Order model)
        {
            if (model == null)
                return null;
            return new OrderDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                IsFinal = model.IsFinal,
                Total = model.Total,
                Date = model.Date,
                ApplicationUserId = model.ApplicationUserId
            };
        }

        public IEnumerable<OrderDto> GetDtos(List<Order> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Order GetModel(OrderDto dto)
        {
            if (dto == null)
                return null;
            return new Order()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Total = dto.Total,
                Date = dto.Date,
                IsFinal = dto.IsFinal,
                ApplicationUserId = dto.ApplicationUserId
            };
        }

        public IEnumerable<Order> GetModels(List<OrderDto> dtos)
        {
            foreach (var item in dtos)
            {
                if (item == null)
                    continue;
                yield return GetModel(item);
            }
        }
    }
}
