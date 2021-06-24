using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity obj);
        Task<TEntity> GetById(Guid? id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Update(TEntity obj);
        Task Remove(TEntity obj);
    }
}
