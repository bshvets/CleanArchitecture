using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdealWay.Application.Notifications
{
    public interface INotificationService
    {
        Task SendNotificationAsync(NotificationMessage message);
    }
}
