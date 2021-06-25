using CatalystTest.BusinessHoliday.Domain.Interfaces.Repositories;
using CatalystTest.BusinessHoliday.Domain.Notifications;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Domain.Commands
{
    public class Handler : IRequestHandler<CreateHolidayCommand, Result>,
                           IRequestHandler<UpdateHolidayCommand, Result>,
                           IRequestHandler<DeleteHolidayCommand, Result>
    {
        private readonly IMediator _mediator;
        private readonly IHolidayRepository _holidayRepository;

        public Handler(IMediator mediator,
                       IHolidayRepository holidayRepository)
        {
            _mediator = mediator;
            _holidayRepository = holidayRepository;
        }

        private IEnumerable<string> GetErrors(HolidayCommand request) =>
            request.ValidationResult.Errors.Select(err => err.ErrorMessage);

        public async Task<Result> Handle(CreateHolidayCommand request, CancellationToken cancellationToken)
        {
            var result = new Result();

            if (request.IsValid())
                if (await _holidayRepository.GetById(request.Id) == null)
                    await _holidayRepository.Add(
                        new Entities.Holiday(request.Id, request.HolidayOccasion, request.FromDate, request.ToDate, request.Active)
                    );
                else
                {
                    var message = "The Holiday ID already exists.";
                    await _mediator.Publish(new Notification(message), cancellationToken);
                    result.AddError(message);
                }
            else
            {
                await _mediator.Publish(new Notification(request.ValidationResult), cancellationToken);
                result.AddErrors(GetErrors(request));
            }
            return result;
        }

        public async Task<Result> Handle(UpdateHolidayCommand request, CancellationToken cancellationToken)
        {
            var result = new Result();

            if (request.IsValid())
            {
                var holiday = await _holidayRepository.GetById(request.Id);
                if (holiday != null)
                {
                    holiday.HolidayOccasion = request.HolidayOccasion;
                    holiday.FromDate = request.FromDate;
                    holiday.ToDate = request.ToDate;
                    holiday.Active = request.Active;
                    await _holidayRepository.Update(holiday);
                }
                else
                {
                    var message = "The holiday cannot be found.";
                    await _mediator.Publish(new Notification(message), cancellationToken);
                    result.AddError(message);
                }
            }
            else
            {
                await _mediator.Publish(new Notification(request.ValidationResult), cancellationToken);
                result.AddErrors(GetErrors(request));
            }
            return result;
        }

        public async Task<Result> Handle(DeleteHolidayCommand request, CancellationToken cancellationToken)
        {
            var result = new Result();

            if (request.IsValid())
            {
                var holiday = await _holidayRepository.GetById(request.Id);
                if (holiday != null)
                    await _holidayRepository.Remove(holiday);
                else
                {
                    var message = "The holiday cannot be found.";
                    await _mediator.Publish(new Notification(message), cancellationToken);
                    result.AddError(message);
                }
            }
            else
            {
                await _mediator.Publish(new Notification(request.ValidationResult), cancellationToken);
                result.AddErrors(GetErrors(request));
            }

            return result;
        }

    }
}

