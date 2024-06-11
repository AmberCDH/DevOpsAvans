using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class ActiveReleaseState : ISprintState
    {
        private ReleaseSprint sprint;
        public ActiveReleaseState(ReleaseSprint sprint)
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
