using AvansDevOpsApplication.Domain.SprintState;
using AvansDevOpsApplication.Domain.SprintState.ReviewSprintState;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    public class ReviewSprint : Sprint
    {
        private readonly ISprintState createdState;
        private readonly ISprintState activeState;
        private readonly ISprintState finishedState;
        private readonly ISprintState pipelineState;
        private readonly ISprintState cancelState;
        private readonly ISprintState reviewState;
        public ReviewSprint(string name, DateTime startTime, DateTime endTime) : base(name, startTime, endTime)
        {
            activeState = new ActiveReviewState(this);
            createdState = new CreatedReviewState(this);
            pipelineState = new PipelineReviewState();
            finishedState = new FinishedReviewState();
            cancelState = new CancelReviewState();
            reviewState = new ReviewState();
            base.SetState(createdState);
        }

        public ISprintState GetActiveState()
        {
            return activeState;
        }

        public ISprintState GetCreatedState()
        {
            return createdState;
        }

        public ISprintState GetFinishedState()
        {
            return finishedState;
        }

        public ISprintState GetPipelineState()
        {
            return pipelineState;
        }

        public ISprintState GetCancelState()
        {
            return cancelState;
        }

        public ISprintState GetReviewState()
        {
            return reviewState;
        }
    }
}
