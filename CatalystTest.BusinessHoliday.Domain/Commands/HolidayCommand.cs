using CatalystTest.BusinessHoliday.Domain.Interfaces.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation.Results;
using CatalystTest.BusinessHoliday.Domain.Validations;

namespace CatalystTest.BusinessHoliday.Domain.Commands
{
    public abstract class HolidayCommand : IRequest<Result>, ICommand
    {
        public Guid Id { get; set; }
        public string HolidayOccasion { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool Active { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public virtual bool IsValid()
        {
            var validation = new HolidayValidation();
            validation.ValidateId();
            validation.ValidateOccasion();
            validation.ValidateFromDate();
            validation.ValidateToDate();
            validation.ValidateActive();

            ValidationResult = validation.Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
