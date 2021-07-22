using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class ProductImageAdapter : IBaseAdapter<ProductImage, ProductImageDto>
    {
        public ProductImageDto GetDto(ProductImage model)
        {
            if (model == null)
                return null;
            return new ProductImageDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Num = model.Num,
                IsCover = model.IsCover,
                ImageLink = model.ImageLink,
                ProductId = model.ProductId
            };
        }

        public IEnumerable<ProductImageDto> GetDtos(List<ProductImage> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public ProductImage GetModel(ProductImageDto dto)
        {
            if (dto == null)
                return null;
            return new ProductImage()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Num = dto.Num,
                IsCover = dto.IsCover,
                ImageLink = dto.ImageLink,
                ProductId = dto.ProductId
            };
        }

        public IEnumerable<ProductImage> GetModels(List<ProductImageDto> dtos)
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
