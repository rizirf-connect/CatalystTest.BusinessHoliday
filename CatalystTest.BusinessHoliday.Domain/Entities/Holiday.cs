using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain.Entities
{
    public class Holiday
    {
        public Holiday(
            Guid id,
            string holidayOccasion,
            DateTime fromDate,
            DateTime toDate,
            bool active)
        {
            Id = id;
            HolidayOccasion = holidayOccasion;
            FromDate = fromDate;
            ToDate = toDate;
            Active = active;
        }

        public Guid Id { get; set; }
        public string HolidayOccasion { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool Active { get; set; }
    }
}
