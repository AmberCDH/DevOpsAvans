using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class CreatedReviewState : ISprintState
    {
        ReviewSprint sprint;
        public CreatedReviewState(ReviewSprint sprint)
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
