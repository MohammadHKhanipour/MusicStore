using Microsoft.EntityFrameworkCore;
using MusicStore.Framework;
using MusicStore.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Infrastructure.Repositories
{
    public class QueryRepository<Model> : IQueryRepository<Model> where Model : BaseModel
    {
        private readonly MusicStoreDbContext _context;

        public QueryRepository(MusicStoreDbContext context)
        {
            _context = context;
        }

        public async Task<Model> GetAsync(int id)
        {
            return await _context.Set<Model>().FindAsync(id);
        }

        public async Task<List<Model>> GetAsync()
        {
            return await _context.Set<Model>().ToListAsync();
        }

        public async Task<List<Model>> GetAsync(Expression<Func<Model, bool>> expression)
        {
            return await _context.Set<Model>().Where(expression).ToListAsync();
        }

        public async Task<int> GetCountAsync()
        {
            return await _context.Set<Model>().CountAsync();
        }

        public async Task<Model> GetFirstOrDefaultAsync(Expression<Func<Model, bool>> expression)
        {
            return await _context.Set<Model>().Where(expression).FirstOrDefaultAsync();
        }

        public async Task<List<Model>> GetQueryAsync(string query)
        {
            return await _context.Set<Model>().FromSqlRaw(query).ToListAsync();
        }

        public async Task<Model> GetSingleOrDefaultAsync(Expression<Func<Model, bool>> expression)
        {
            return await _context.Set<Model>().Where(expression).SingleOrDefaultAsync();
        }
    }
}
