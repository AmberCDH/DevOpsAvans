using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansDevOpsApplication.Domain.Observer;

namespace AvansDevOpsApplication.Domain.Adapter
{
    internal class EmailObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
