using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class CancelReviewState : ISprintState
    {
        private ReviewSprint sprint;
        public CancelReviewState(ReviewSprint sprint)
        {
            this.sprint = sprint;
        }

        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint review is canceled");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint review is canceled");
        }
    }
}
