using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class ActiveReviewState : ISprintState
    {
        private ReleaseSprint sprint;
        public ActiveReviewState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            sprint.getBacklogItems().Add(backlogItem);
        }

        public void RemoveBacklogItem(Guid id)
        {
            sprint.getBacklogItems();
        }
    }
}
