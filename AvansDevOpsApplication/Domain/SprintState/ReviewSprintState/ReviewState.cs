using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class ReviewState : ISprintState
    {
        private ReviewSprint sprint;
        public ReviewState(ReviewSprint sprint)
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
