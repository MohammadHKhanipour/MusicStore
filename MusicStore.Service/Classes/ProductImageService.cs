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
    public class ProductImageService : DomainService<ProductImage, ProductImageDto>, IProductImageService
    {
        public ProductImageService(IQueryRepository<ProductImage> queryRepository, ICommandRepository<ProductImage> commandRepository, IBaseAdapter<ProductImage, ProductImageDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
