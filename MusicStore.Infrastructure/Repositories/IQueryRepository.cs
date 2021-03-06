using MusicStore.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Infrastructure.Repositories
{
    public interface IQueryRepository<Model> where Model : BaseModel
    {
        public Task<Model> GetAsync(int id);
        public Task<List<Model>> GetAsync();
        public Task<List<Model>> GetAsync(Expression<Func<Model, bool>> expression);
        public Task<int> GetCountAsync();
        public Task<Model> GetFirstOrDefaultAsync(Expression<Func<Model, bool>> expression);
        public Task<Model> GetSingleOrDefaultAsync(Expression<Func<Model, bool>> expression);
        public Task<List<Model>> GetQueryAsync(string query);
    }
}