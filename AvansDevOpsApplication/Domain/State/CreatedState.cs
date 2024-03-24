namespace AvansDevOpsApplication.Domain.State
{
    public class CreatedState : ISprintState
    {
        Sprint sprint;
        public CreatedState(Sprint sprint)
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
