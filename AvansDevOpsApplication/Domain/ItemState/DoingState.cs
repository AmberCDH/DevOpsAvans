namespace AvansDevOpsApplication.Domain.ItemState
{
    public class DoingState : IItemState
    {
        private BacklogItem backlogItem;
        public DoingState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void AssignUser(User user)
        {
            Console.WriteLine("Can't assign users when item has doing state");
        }

        public void ChangeState(IItemState state)
        {
            if (state == backlogItem.GetReadyForTestingState())
            {
                backlogItem.SetState(state);
            }
        }

        public void RemoveUser(User user)
        {
            Console.WriteLine("Can't remove users when item has doing state");
        }
    }
}
