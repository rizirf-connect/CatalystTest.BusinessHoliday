using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CatalystTest.BusinessHoliday.Domain.Notifications
{
    public class Handler : INotificationHandler<Notification>
    {
        public async Task Handle(Notification notification, CancellationToken cancellationToken)
        {
            var message = notification.Message;

            // Debug only
            System.Diagnostics.Debug.WriteLine(message);

            // Log Errors
            // Send e-mail
            // Others
        }
    }
}
