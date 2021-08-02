using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using MusicStore.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MusicStore.Service.Interfaces;
using MusicStore.Share.Adapter;

namespace MusicStore.Business.Classes
{
    public class ProductBusiness : DomainBusiness<Product, ProductDto>, IProductBusiness
    {
        public ProductBusiness(IDomainService<Product, ProductDto> domainService, IBaseAdapter<Product, ProductDto> baseAdapter)
            : base(domainService, baseAdapter)
        {
        }

    }
}
