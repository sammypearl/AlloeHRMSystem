using AlloeHRMSystem.ApplicationServices.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AlloeHRMSystem.ApplicationServices.Interface
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
