namespace AvansDevOpsApplication.Domain.State
{
    public class PipelineState : ISprintState
    {
        private Sprint sprint;
        public PipelineState (Sprint sprint)
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
