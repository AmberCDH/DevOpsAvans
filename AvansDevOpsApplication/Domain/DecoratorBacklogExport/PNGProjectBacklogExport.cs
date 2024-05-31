using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.DecoratorBacklogExport
{
    class PNGProjectBacklogExport : ProjectBacklogExport
    {
        public PNGProjectBacklogExport(AbstractProjectBacklog projectBacklog) : base(projectBacklog)
        {
        }
        public override void export()
        {
            var items = base.getBacklogItems();

            Console.WriteLine("PNG EXPORT");
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
