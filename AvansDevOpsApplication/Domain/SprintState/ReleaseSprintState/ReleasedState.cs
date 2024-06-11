using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class ReleaseState : ISprintState
    {
        private ReleaseSprint sprint;
        public ReleaseState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            sprint.AddItemToBacklog(backlogItem);
        }

        public void RemoveBacklogItem(Guid id)
        {
            sprint.RemoveFromBacklog(id);
        }
    }
}
