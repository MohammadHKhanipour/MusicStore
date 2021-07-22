using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class CategoryAdapter : IBaseAdapter<Category, CategoryDto>
    {
        public CategoryDto GetDto(Category model)
        {
            if (model == null)
                return null;
            return new CategoryDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Name = model.Name,
                Description = model.Description,
                ProductId = model.ProductId
            };
        }

        public IEnumerable<CategoryDto> GetDtos(List<Category> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public Category GetModel(CategoryDto dto)
        {
            if (dto == null)
                return null;
            return new Category()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Name = dto.Name,
                Description = dto.Description,
                ProductId = dto.ProductId
            };
        }

        public IEnumerable<Category> GetModels(List<CategoryDto> dtos)
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
