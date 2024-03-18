namespace AvansDevOpsApplication.Domain
{
    public class Backlog
    {
        private Guid id;
        private List<BacklogItem> backlogItems;
        private List<Sprint> sprints;

        public Backlog()
        {
            backlogItems = [];
            id = Guid.NewGuid();
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {

        }

        public void RemoveBacklogItem(Guid id)
        {

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
