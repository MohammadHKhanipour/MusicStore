using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class ProductLinkAdapter : IBaseAdapter<ProductLink, ProductLinkDto>
    {
        public ProductLinkDto GetDto(ProductLink model)
        {
            if (model == null)
                return null;
            return new ProductLinkDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Num = model.Num,
                Link = model.Link,
                ProductId = model.ProductId
            };
        }

        public IEnumerable<ProductLinkDto> GetDtos(List<ProductLink> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public ProductLink GetModel(ProductLinkDto dto)
        {
            if (dto == null)
                return null;
            return new ProductLink()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Num = dto.Num,
                Link = dto.Link,
                ProductId = dto.ProductId
            };
        }

        public IEnumerable<ProductLink> GetModels(List<ProductLinkDto> dtos)
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
