using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuickWay.Application.Notifications
{
    public interface INotificationService
    {
        Task SendNotificationAsync(NotificationMessage message);
    }
}
