using IdealWay.Application.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdealWay.Infrastructure.Notifications
{
    public class EmailNotificationService : INotificationService
    {
        public Task SendNotificationAsync(NotificationMessage message)
        {
            //Send email to target address
            return Task.CompletedTask;
        }
    }
}
