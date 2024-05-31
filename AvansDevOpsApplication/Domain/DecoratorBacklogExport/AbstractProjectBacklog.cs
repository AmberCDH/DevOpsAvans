using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.DecoratorBacklogExport
{
    public abstract class AbstractProjectBacklog
    {
        public abstract void export();
        public abstract List<BacklogItem> getBacklogItems();
    }
}
