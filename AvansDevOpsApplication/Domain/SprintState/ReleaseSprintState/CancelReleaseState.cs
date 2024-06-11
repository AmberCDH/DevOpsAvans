using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class CancelReleaseState : ISprintState
    {
        private ReleaseSprint sprint;
        public CancelReleaseState(ReleaseSprint sprint)
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
