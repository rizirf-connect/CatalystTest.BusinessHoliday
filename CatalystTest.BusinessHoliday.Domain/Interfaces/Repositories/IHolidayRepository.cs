using CatalystTest.BusinessHoliday.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories
{
    public interface IHolidayRepository : IBaseRepository<Holiday>
    {
        bool HolidayExists(Guid id);
        int CalculateWorkingDays(DateTime startDate, DateTime endDate);
    }
}
