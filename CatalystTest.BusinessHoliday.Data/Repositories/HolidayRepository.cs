using CatalystTest.BusinessHoliday.Data.Contexts;
using CatalystTest.BusinessHoliday.Domain.Entities;
using CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Data.Repositories
{
    public class HolidayRepository : BaseReposistory<Holiday>, IHolidayRepository
    {
        public HolidayRepository(BusinessHolidayContext context) : base(context) { }

        public async Task<int> CalculateWorkingDays(DateTime startDate, DateTime endDate)
        {
            var holidayDates = new List<DateTime>();
            var holidays = await _context.Holidays.ToListAsync();
            for (int i = 0; i < holidays.Count(); i++)
            {
                var holiday = holidays.ElementAt(i);
                for (DateTime start = holiday.FromDate.Date; start.Date <= holiday.ToDate.Date; start = start.AddDays(1))
                {
                    holidayDates.Add(start.Date);
                }
            }

            var workingDays = 0;

            while (startDate.Date <= endDate.Date)
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday && !holidayDates.Contains(startDate.Date))
                    workingDays++;
                startDate = startDate.AddDays(1);
            }
            return workingDays;
        }

        public bool HolidayExists(Guid id) =>
            _context.Holidays.Any(holiday => holiday.Id == id);
    }
}
