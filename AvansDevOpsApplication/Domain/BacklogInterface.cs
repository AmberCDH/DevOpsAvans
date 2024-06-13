namespace AvansDevOpsApplication.Domain
{
    public interface BacklogInterface
    {
        public void RemoveFromBacklog(Guid id);
        public void AddItemToBacklog(BacklogItem backlogItem);
    }
}
