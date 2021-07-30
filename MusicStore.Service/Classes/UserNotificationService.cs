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
    public class UserNotificationService : DomainService<UserNotification, UserNotificationDto>, IUserNotificationService
    {
        public UserNotificationService(IQueryRepository<UserNotification> queryRepository, ICommandRepository<UserNotification> commandRepository, IBaseAdapter<UserNotification, UserNotificationDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
