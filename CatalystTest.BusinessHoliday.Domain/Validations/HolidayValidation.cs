using CatalystTest.BusinessHoliday.Domain.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalystTest.BusinessHoliday.Domain.Validations
{
    class HolidayValidation : AbstractValidator<HolidayCommand>
    {
        public void ValidateId()
        {
            RuleFor(h => h.Id)
                .NotEmpty().WithMessage("The ID cannot be empty.");
        }

        public void ValidateOccasion()
        {
            RuleFor(h => h.HolidayOccasion)
                .NotEmpty().WithMessage("The Holiday Occasion cannot be empty.")
                .MaximumLength(10).WithMessage("The Holiday Occasion cannot be greater than 10 characters.")
                .Matches("^[A-Z][A-Za-z0-9_-]{0,9}$").WithMessage("First letter of Holiday Occasion is always capital And length between 0 - 10 characters long.");
        }

        public void ValidateFromDate()
        {
            RuleFor(h => h.FromDate)
                .NotEmpty().WithMessage("The From Date cannot be empty.");
        }

        public void ValidateToDate()
        {
            RuleFor(h => h.ToDate)
                .GreaterThan(h => h.FromDate).WithMessage("ToDate should not be less than FromDate.")
                .NotEmpty().WithMessage("The To Date cannot be empty.");
        }

        public void ValidateActive()
        {
            RuleFor(h => h.Active)
                .NotEmpty().WithMessage("The Active cannot be empty.");
        }
    }
}
