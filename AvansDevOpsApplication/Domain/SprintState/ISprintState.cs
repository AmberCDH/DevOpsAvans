namespace AvansDevOpsApplication.Domain.SprintState
{
    public interface ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem);
        public void RemoveBacklogItem(Guid id);
    }
}
