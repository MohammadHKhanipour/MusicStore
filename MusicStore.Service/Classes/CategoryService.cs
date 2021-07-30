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
    public class CategoryService : DomainService<Category, CategoryDto>, ICategoryService
    {
        public CategoryService(IQueryRepository<Category> queryRepository, ICommandRepository<Category> commandRepository, IBaseAdapter<Category, CategoryDto> baseAdapter)
            : base(queryRepository, commandRepository, baseAdapter)
        {
        }

    }
}
