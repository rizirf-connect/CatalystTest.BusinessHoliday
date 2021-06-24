using CatalystTest.BusinessHoliday.Data.Contexts;
using CatalystTest.BusinessHoliday.Domain.Entities;
using CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatalystTest.BusinessHoliday.Data.Repositories
{
    public class HolidayRepository : BaseReposistory<Holiday>, IHolidayRepository
    {
        public HolidayRepository(BusinessHolidayContext context) : base(context) { }

        public int CalculateWorkingDays(DateTime startDate, DateTime endDate)
        {
            var holidays = 0;

            while (startDate.Date <= endDate.Date)
            {
                if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
                    holidays++;
                startDate = startDate.AddDays(1);
            }
            throw new NotImplementedException();
        }

        public bool HolidayExists(Guid id) =>
            _context.Holidays.Any(holiday => holiday.Id == id);
    }
}
