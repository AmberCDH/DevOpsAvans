using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class PipelineReleaseState : ISprintState
    {
        private ReleaseSprint sprint;
        public PipelineReleaseState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint is released");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint is released");
        }
    }
}
