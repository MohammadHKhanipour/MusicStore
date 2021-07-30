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
    public class ApplicationUserService : DomainService<ApplicationUser, ApplicationUserDto>, IApplicationUserService
    {
        public ApplicationUserService(IQueryRepository<ApplicationUser> queryRepository, ICommandRepository<ApplicationUser> commandRepository, IBaseAdapter<ApplicationUser, ApplicationUserDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
