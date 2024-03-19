using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.Observer
{
    public interface ISubject
    {
        void RegisterObserver(User user);
        void RemoveObserver(User user);
        void NotifyObserver(string message);
    }
}
