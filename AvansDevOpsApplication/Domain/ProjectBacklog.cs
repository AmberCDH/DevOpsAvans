using AvansDevOpsApplication.Domain.ReportTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApplication.Domain
{
    public class ProjectBacklog : BacklogProvider, BacklogInterface
    {
        private Guid id;
        private List<BacklogItem> backlogItems = [];

        public ProjectBacklog(Guid id)
        {
            this.id = id;
        }

        public BacklogItem AddItemToBacklog(BacklogItem backlogItem)
        {
            backlogItems.Add(backlogItem);
            return backlogItem;
        }

        public List<BacklogItem> getBacklogItems()
        {
            return backlogItems;
        }

        public BacklogItem RemoveFromBacklog(Guid id)
        {
            var item = backlogItems.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                backlogItems.Remove(item);
                return item;
            }
            else
            {
                return null;
            }

        }
    }
}
