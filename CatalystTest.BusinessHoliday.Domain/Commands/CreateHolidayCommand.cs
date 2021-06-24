using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain.Commands
{
    public class CreateHolidayCommand : HolidayCommand
    {
        public CreateHolidayCommand() { }
        public CreateHolidayCommand(
            Guid id,
            DateTime fromDate,
            DateTime toDate,
            string holidayOccasion,
            bool active)
        {
            Id = id;
            FromDate = fromDate;
            ToDate = toDate;
            HolidayOccasion = holidayOccasion;
            Active = active;
        }
    }
}
