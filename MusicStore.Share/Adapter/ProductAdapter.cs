using MusicStore.Domain.Models;
using MusicStore.Framework;
using MusicStore.Share.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.Adapter
{
    class ProductAdapter : IBaseAdapter<Product, ProductDto>
    {
        public ProductDto GetDto(Product model)
        {
            if (model == null)
                return null;
            return new ProductDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Name = model.Name,
                Price = model.Price
            };
        }

        public IEnumerable<ProductDto> GetDtos(List<Product> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Product GetModel(ProductDto dto)
        {
            if (dto == null)
                return null;
            return new Product()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Name = dto.Name,
                Price = dto.Price
            };
        }

        public IEnumerable<Product> GetModels(List<ProductDto> dtos)
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
