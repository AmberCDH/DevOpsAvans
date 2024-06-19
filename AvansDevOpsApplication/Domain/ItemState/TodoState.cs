namespace AvansDevOpsApplication.Domain.ItemState
{
    public class TodoState : IItemState
    {
        private BacklogItem backlogItem;

        public TodoState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void AssignUser(User user)
        {
            backlogItem.AssigedUsers.Add(user);
        }

        public void RemoveUser(User user)
        {
            backlogItem.AssigedUsers.Remove(user);
        }

        public void ChangeState(IItemState state)
        {
            if (backlogItem.AssigedUsers.Count() >= 1 && state == backlogItem.GetDoingState())
            {
                backlogItem.SetState(state);
            }
            else
            {
                Console.WriteLine("No assigned users");
            }
        }
    }
}
