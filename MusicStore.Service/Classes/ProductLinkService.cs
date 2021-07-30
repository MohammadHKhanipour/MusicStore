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
    public class ProductLinkService : DomainService<ProductLink, ProductLinkDto>, IProductLinkService
    {
        public ProductLinkService(IQueryRepository<ProductLink> queryRepository, ICommandRepository<ProductLink> commandRepository, IBaseAdapter<ProductLink, ProductLinkDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
