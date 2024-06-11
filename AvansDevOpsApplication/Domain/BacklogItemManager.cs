namespace AvansDevOpsApplication.Domain
{
    public class BacklogItemManager
    {
    public void MoveBacklogItem(BacklogInterface from, BacklogInterface to, BacklogItem item)
        {
            to.AddItemToBacklog(item);
            from.RemoveFromBacklog(item.ID);
        }
    }
}
