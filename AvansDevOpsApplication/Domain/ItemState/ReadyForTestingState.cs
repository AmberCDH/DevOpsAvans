namespace AvansDevOpsApplication.Domain.ItemState
{
    public class ReadyForTestingState : IItemState
    {
        private BacklogItem backlogItem;
        public ReadyForTestingState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        public void AssignUser(User user)
        {
            if (user.Role == RoleType.TESTER)
            {
                backlogItem.AssigedUsers.Add(user);
            } else
            {
                Console.WriteLine("User is not a tester");
            }
        }

        public void ChangeState(IItemState state)
        {
            if (backlogItem.AssigedUsers.Where(x => x.Role == RoleType.TESTER).Count() >= 1 && state == backlogItem.GetTestingState())
            {
                backlogItem.SetState(state);
            } else
            {
                Console.WriteLine("At least one tester should be assigned");
            }
        }

        public void RemoveUser(User user)
        {
            if (user.Role == RoleType.TESTER)
            {
                backlogItem.AssigedUsers.Remove(user);
            }
        }
    }
}
