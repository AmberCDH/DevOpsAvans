using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.Observer
{
    internal class EmailObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
