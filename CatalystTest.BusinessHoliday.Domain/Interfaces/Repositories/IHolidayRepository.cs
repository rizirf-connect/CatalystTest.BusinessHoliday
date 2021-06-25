using CatalystTest.BusinessHoliday.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories
{
    public interface IHolidayRepository : IBaseRepository<Holiday>
    {
        bool HolidayExists(Guid id);
        Task<int> CalculateWorkingDays(DateTime startDate, DateTime endDate);
    }
}
