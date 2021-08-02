using MusicStore.Framework;
using MusicStore.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Infrastructure.Repositories
{
    public class CommandRepository<Model> : ICommandRepository<Model> where Model : BaseModel
    {
        private readonly MusicStoreDbContext _context;

        public CommandRepository(MusicStoreDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(Model entity)
        {
            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddRangeAsync(List<Model> entities)
        {
            try
            {
                await _context.AddRangeAsync(entities);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var model = _context.Set<Model>().FindAsync(id);
                if (model == null)
                    return false;
                _context.Remove(model);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Model entity)
        {
            try
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteRangeAsync(List<Model> entities)
        {
            try
            {
                _context.RemoveRange(entities);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Model entity)
        {
            try
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
