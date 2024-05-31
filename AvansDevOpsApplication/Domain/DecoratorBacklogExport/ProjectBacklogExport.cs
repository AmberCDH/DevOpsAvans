using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.DecoratorBacklogExport
{
    abstract class ProjectBacklogExport : AbstractProjectBacklog
    {
        protected AbstractProjectBacklog projectBacklog;

        public ProjectBacklogExport(AbstractProjectBacklog projectBacklog)
        {
            this.projectBacklog = projectBacklog;
        }

        public override void export()
        {
            projectBacklog?.export();
        }

        public override List<BacklogItem> getBacklogItems()
        {
            return projectBacklog.getBacklogItems();
        }
    }
}
