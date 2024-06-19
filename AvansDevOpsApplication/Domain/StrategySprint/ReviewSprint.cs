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
        public ReviewSprint(string name, DateTime startTime, DateTime endTime) : base(name, startTime, endTime)
        {
            activeState = new ActiveReviewState(this);
            createdState = new CreatedReviewState(this);
            pipelineState = new PipelineReviewState(this);
            finishedState = new FinishedReviewState();
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
    }
}
