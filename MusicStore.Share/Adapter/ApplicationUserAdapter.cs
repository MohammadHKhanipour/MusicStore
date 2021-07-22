using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class ApplicationUserAdapter : IBaseAdapter<ApplicationUser, ApplicationUserDto>
    {
        public ApplicationUserDto GetDto(ApplicationUser model)
        {
            if (model == null)
                return null;
            return new ApplicationUserDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                FirstName = model.FirstName,
                LastName = model.LastName,
                NationalCode = model.NationalCode
            };
        }

        public IEnumerable<ApplicationUserDto> GetDtos(List<ApplicationUser> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public ApplicationUser GetModel(ApplicationUserDto dto)
        {
            if (dto == null)
                return null;
            return new ApplicationUser()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                NationalCode = dto.NationalCode
            };
        }

        public IEnumerable<ApplicationUser> GetModels(List<ApplicationUserDto> dtos)
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
