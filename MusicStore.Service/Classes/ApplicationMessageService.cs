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
    public class ApplicationMessageService : DomainService<ApplicationMessage, ApplicationMessageDto>, IApplicationMessageService
    {
        public ApplicationMessageService(IQueryRepository<ApplicationMessage> queryRepository, ICommandRepository<ApplicationMessage> commandRepository, IBaseAdapter<ApplicationMessage, ApplicationMessageDto> baseAdapter)
            : base (queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
