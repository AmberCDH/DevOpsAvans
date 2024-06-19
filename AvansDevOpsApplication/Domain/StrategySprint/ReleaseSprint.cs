using AvansDevOpsApplication.Domain.SprintState;
using AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    public class ReleaseSprint : Sprint
    {
        private readonly ISprintState createdState;
        private readonly ISprintState activeState;
        private readonly ISprintState finishedState;
        private readonly ISprintState cancelState;
        private readonly ISprintState pipelineState;
        private readonly ISprintState releasedState;
        public ReleaseSprint(string name, DateTime startTime, DateTime endTime) : base(name, startTime, endTime)
        {
            activeState = new ActiveReleaseState(this);
            createdState = new CreatedReleaseState(this);
            finishedState = new FinishedReleaseState();
            cancelState = new CancelReleaseState();
            pipelineState = new PipelineReleaseState();
            releasedState = new ReleasedState();
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

        public ISprintState GetCancelState()
        {
            return cancelState;
        }

        public ISprintState GetPipelineState()
        {
            return pipelineState;
        }

        public ISprintState GetReleasedState()
        {
            return releasedState;
        }
    }
}
