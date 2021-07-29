using MusicStore.Share.DTO;
using MusicStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Share.Adapter
{
    class ApplicationMessageAdapter : IBaseAdapter<ApplicationMessage, ApplicationMessageDto>
    {
        public ApplicationMessageDto GetDto(ApplicationMessage model)
        {
            if (model == null)
                return null;
            return new ApplicationMessageDto()
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Name = model.Name,
                Content = model.Content,
                MessageType = model.MessageType,
                MessageCode = model.MessageCode
            };
        }

        public IEnumerable<ApplicationMessageDto> GetDtos(List<ApplicationMessage> models)
        {
            foreach (var item in models)
            {
                if (item == null)
                    continue;
                yield return GetDto(item);
            }
        }

        public ApplicationMessage GetModel(ApplicationMessageDto dto)
        {
            if (dto == null)
                return null;
            return new ApplicationMessage()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                Name = dto.Name,
                Content = dto.Content,
                MessageType = dto.MessageType,
                MessageCode = dto.MessageCode
            };
        }

        public IEnumerable<ApplicationMessage> GetModels(List<ApplicationMessageDto> dtos)
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
