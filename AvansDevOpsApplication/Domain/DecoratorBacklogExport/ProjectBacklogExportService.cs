using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.DecoratorBacklogExport
{
    public class ProjectBacklogExportService
    {
        public void Export(AbstractProjectBacklog projectBacklog)
        {
            projectBacklog.export();
        }
    }
}
