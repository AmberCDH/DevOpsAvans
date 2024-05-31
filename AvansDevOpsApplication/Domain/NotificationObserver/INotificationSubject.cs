using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.NotificationObserver
{
    public interface INotificationSubject
    {
        void NotifyObserver(string message);
    }
}
