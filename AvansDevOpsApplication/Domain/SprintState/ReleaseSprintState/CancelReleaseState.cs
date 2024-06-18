using AvansDevOpsApplication.Domain.StrategySprint;

namespace AvansDevOpsApplication.Domain.SprintState.ReleaseSprintState
{
    public class CancelReleaseState : ISprintState
    {
        private ReleaseSprint sprint;
        public CancelReleaseState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }
        public void AddBacklogItem(BacklogItem backlogItem)
        {
            Console.WriteLine("Sprint release is canceled");
        }

        public void RemoveBacklogItem(Guid id)
        {
            Console.WriteLine("Sprint release is canceled");
        }
    }
}
