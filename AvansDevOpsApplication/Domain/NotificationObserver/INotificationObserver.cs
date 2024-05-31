using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.NotificationObserver
{
    public interface INotificationObserver
    {
        void Update(string message);
    }
}
