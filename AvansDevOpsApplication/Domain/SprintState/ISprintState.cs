namespace AvansDevOpsApplication.Domain.State
{
    public interface ISprintState
    {
        public void AddBacklogItem(BacklogItem backlogItem);
        public void RemoveBacklogItem(Guid id);
    }
}
