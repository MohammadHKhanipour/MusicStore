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
    public class ProductService : DomainService<Product, ProductDto>, IProductService
    {
        public ProductService(IQueryRepository<Product> queryRepository, ICommandRepository<Product> commandRepository, IBaseAdapter<Product, ProductDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
