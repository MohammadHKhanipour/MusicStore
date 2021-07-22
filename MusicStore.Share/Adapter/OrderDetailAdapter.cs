using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class OrderDetailAdapter : IBaseAdapter<OrderDetail, OrderDetailDto>
    {
        public OrderDetailDto GetDto(OrderDetail model)
        {
            if (model == null)
                return null;
            return new OrderDetailDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                OrderId = model.OrderId,
                ProductId = model.ProductId
            };
        }

        public IEnumerable<OrderDetailDto> GetDtos(List<OrderDetail> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public OrderDetail GetModel(OrderDetailDto dto)
        {
            if (dto == null)
                return null;
            return new OrderDetail()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                OrderId = dto.OrderId,
                ProductId = dto.ProductId
            };
        }

        public IEnumerable<OrderDetail> GetModels(List<OrderDetailDto> dtos)
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
