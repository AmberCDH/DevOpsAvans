namespace AvansDevOpsApplication.Domain.State
{
    public class FinishedState : ISprintState
    {
        private Sprint sprint;
        public FinishedState(Sprint sprint)
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
