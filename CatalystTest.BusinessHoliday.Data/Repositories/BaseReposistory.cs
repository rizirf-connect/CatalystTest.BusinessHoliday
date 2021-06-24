using CatalystTest.BusinessHoliday.Data.Contexts;
using CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Data.Repositories
{
    public abstract class BaseReposistory<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly BusinessHolidayContext _context;

        protected BaseReposistory(BusinessHolidayContext context) =>
            _context = context;

        public virtual async Task Add(TEntity obj)
        {
            await _context.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public void Dispose() =>
            _context.Dispose();

        public virtual async Task<IEnumerable<TEntity>> GetAll() =>
            await _context.Set<TEntity>().ToListAsync();

        public virtual async Task<TEntity> GetById(Guid? id) =>
            await _context.Set<TEntity>().FindAsync(id);

        public virtual async Task Remove(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
