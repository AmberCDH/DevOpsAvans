using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain.DecoratorBacklogExport
{
    class ProjectBacklog : AbstractProjectBacklog
    {
        private Guid id;
        private List<BacklogItem> backlogItems = [];

        public ProjectBacklog(Guid id)
        {
            this.id = id;
            var item = new BacklogItem("Test", "Test", null, DateTime.Now, "1");
            backlogItems.Add(item);
        }

        public override List<BacklogItem> getBacklogItems()
        {
            return backlogItems;
        }

        public override void export()
        {
            Console.WriteLine("Yippie");
        }
    }
}
