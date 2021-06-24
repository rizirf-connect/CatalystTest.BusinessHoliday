using CatalystTest.BusinessHoliday.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain.Commands
{
    public class DeleteHolidayCommand : HolidayCommand
    {
        public DeleteHolidayCommand(Guid id) =>
            Id = id;

        public override bool IsValid()
        {
            var validation = new HolidayValidation();
            validation.ValidateId();

            ValidationResult = validation.Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
