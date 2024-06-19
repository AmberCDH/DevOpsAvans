using AvansDevOpsApplication.Domain.SprintState;
using AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState;

namespace AvansDevOpsApplication.Domain.StrategySprint
{
    public class ReleaseSprint : Sprint
    {
        private readonly ISprintState createdState;
        private readonly ISprintState activeState;
        private readonly ISprintState finishedState;
        public ReleaseSprint(string name, DateTime startTime, DateTime endTime) : base(name, startTime, endTime)
        {
            activeState = new ActiveReleaseState(this);
            createdState = new CreatedReleaseState(this);
            finishedState = new FinishedReleaseState(this);
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
    }
}
