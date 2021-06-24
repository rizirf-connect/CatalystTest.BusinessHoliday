using CatalystTest.BusinessHoliday.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain.Commands
{
    public class UpdateHolidayCommand : HolidayCommand
    {
        public UpdateHolidayCommand() { }
        public UpdateHolidayCommand(
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

        public override bool IsValid()
        {
            var validation = new HolidayValidation();
            validation.ValidateId();

            ValidationResult = validation.Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
