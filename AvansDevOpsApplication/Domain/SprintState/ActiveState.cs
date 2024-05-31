namespace AvansDevOpsApplication.Domain.State
{
    public class ActiveState : ISprintState
    {
        Sprint sprint;
        public ActiveState(Sprint sprint) 
        {
            this.sprint = sprint;
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            sprint.BacklogItems.Add(backlogItem);
        }

        public void RemoveBacklogItem(Guid id)
        {
            sprint.BacklogItems.RemoveAll(x => x.Id == id);
        }
    }
}
