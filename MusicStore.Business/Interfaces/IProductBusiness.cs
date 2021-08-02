using MusicStore.Domain.Models;
using MusicStore.Share.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Business.Interfaces
{
    public interface IProductBusiness : IDomainBusiness<Product, ProductDto>
    {
    }
}
