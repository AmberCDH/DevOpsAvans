using AvansDevOpsApplication.Domain.ReportTemplate;

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

        public void AddItemToBacklog(BacklogItem backlogItem)
        {
            backlogItems.Add(backlogItem);
        }

        public List<BacklogItem> getBacklogItems()
        {
            return backlogItems;
        }

        public void RemoveFromBacklog(Guid id)
        {
            var item = backlogItems.Where(x => x.Id == id).FirstOrDefault();
            if (item != null)
            {
                backlogItems.Remove(item);
            }
        }
    }
}
