using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.Observer
{
    public interface ISubject
    {
        void NotifyObserver(string message);
    }
}
