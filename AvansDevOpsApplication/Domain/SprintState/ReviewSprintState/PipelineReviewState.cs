using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReviewSprintState
{
    public class PipelineReviewState : ISprintState
    {
        private ReviewSprint sprint;
        public PipelineReviewState(ReviewSprint sprint)
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
