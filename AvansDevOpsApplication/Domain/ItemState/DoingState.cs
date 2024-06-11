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
            throw new NotImplementedException();
        }

        public void ChangeState(IItemState state)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
