namespace AvansDevOpsApplication.Domain
{
    public class Backlog
    {
        private Guid id;
        private string name;
        private string description;
        private List<BacklogItem> backlogItems;
        private List<Sprint> sprints;

        public Backlog(string name, string description)
        {
            backlogItems = [];
            sprints = [];
            id = Guid.NewGuid();
            this.name = name;
            this.description = description;
        }

        public List<BacklogItem> BacklogItems { get { return backlogItems; } }
        public List<Sprint> Sprints { get {  return sprints; } }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            backlogItems.Add(backlogItem);
        }

        public void RemoveBacklogItem(Guid id)
        {
            backlogItems.RemoveAll(x => x.Id == id);
        }

        public void AddSprint(Sprint sprint)
        {
            sprints.Add(sprint);
        }

        public void RemoveSprint(Guid id)
        {
            sprints.RemoveAll(x => x.Id == id);
        }
    }
}
