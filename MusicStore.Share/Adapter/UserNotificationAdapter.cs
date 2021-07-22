using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System.Collections.Generic;

namespace MusicStore.Share.Adapter
{
    class UserNotificationAdapter : IBaseAdapter<UserNotification, UserNotificationDto>
    {
        public UserNotificationDto GetDto(UserNotification model)
        {
            if (model == null)
                return null;
            return new UserNotificationDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Description = model.Description,
                Date = model.Date,
                MessageCode = model.MessageCode,
                IsSeen = model.IsSeen,
                ApplicationUserId = model.ApplicationUserId
            };
        }

        public IEnumerable<UserNotificationDto> GetDtos(List<UserNotification> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public UserNotification GetModel(UserNotificationDto dto)
        {
            if (dto == null)
                return null;
            return new UserNotification()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Description = dto.Description,
                Date = dto.Date,
                MessageCode = dto.MessageCode,
                IsSeen = dto.IsSeen,
                ApplicationUserId = dto.ApplicationUserId
            };
        }

        public IEnumerable<UserNotification> GetModels(List<UserNotificationDto> dtos)
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
