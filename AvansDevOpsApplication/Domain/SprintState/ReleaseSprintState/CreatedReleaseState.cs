using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class CreatedReleaseState : ISprintState
    {
        ReleaseSprint sprint;
        public CreatedReleaseState(ReleaseSprint sprint)
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
