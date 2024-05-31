using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.DecoratorBacklogExport
{
    class PDFProjectBacklogExport : ProjectBacklogExport
    {
        public PDFProjectBacklogExport(AbstractProjectBacklog projectBacklog) : base(projectBacklog)
        {
        }

        public override void export()
        {
            var items = base.getBacklogItems();
            Console.WriteLine("PDF EXPORT");
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
