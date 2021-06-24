using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain.Commands
{
    public class CreateHolidayCommand : HolidayCommand
    {
        public CreateHolidayCommand() { }
        public CreateHolidayCommand(
            DateTime fromDate,
            DateTime toDate,
            string holidayOccasion,
            bool active)
        {
            FromDate = fromDate;
            ToDate = toDate;
            HolidayOccasion = holidayOccasion;
            Active = active;
        }
    }
}
