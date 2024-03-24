namespace AvansDevOpsApplication.Domain.State
{
    public class ReleasedState : ISprintState
    {
        private Sprint sprint;
        public ReleasedState(Sprint sprint)
        {
            this.sprint = sprint;
        }
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            throw new NotImplementedException();
        }

        public void RemoveBacklogItem(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
