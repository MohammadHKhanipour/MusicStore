using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Service.Interfaces
{
   public interface IDomainService<Model, Dto> where Model : BaseModel where Dto : BaseDto
    {
        public Task<Dto> GetAsync(int id);
        public Task<List<Dto>> GetAsync();
        public Task<List<Dto>> GetAsync(Expression<Func<Model, bool>> expression);
        public Task<int> GetCountAsync();
        public Task<Dto> GetFirstOrDefaultAsync(Expression<Func<Model, bool>> expression);
        public Task<Dto> GetSingleOrDefaultAsync(Expression<Func<Model, bool>> expression);
        public Task<List<Dto>> GetQueryAsync(string query);
        public Task<bool> AddAsync(Model entity);
        public Task<bool> AddRangeAsync(List<Model> entities);
        public Task<bool> DeleteAsync(int id);
        public Task<bool> DeleteAsync(Model entity);
        public Task<bool> DeleteRangeAsync(List<Model> entities);
        public Task<bool> UpdateAsync(Model entity);
    }
}
